using LibraryManagementSystemUAZ.Services.Interfaces;
using LibraryManagementSystemUAZ.UI.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemUAZ.UI.Books
{
    public partial class BookListForm : Form
    {
        private readonly IBookService _bookService;
        public BookListForm(IBookService bookService)
        {
            _bookService = bookService;
            InitializeComponent();
        }

        private async void BookListForm_Load(object sender, EventArgs e)
        {
            var data = await _bookService.GetAllBooksAsync();

            dataGridView1.DataSource = data.Select(book => new
            BookDTO()
            {
                BookId = book.BookId,
                Title = book.Title,
                Description = book.Description,
                Category = book.Category.ToString(),
                Authors = string.Join(", ", book.BookAuthors.Select(item => item.Author.Name).ToList())
            }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
