using LibraryManagementSystemUAZ.Data.Entities;
using LibraryManagementSystemUAZ.Services.Interfaces;
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
    public partial class BookAddForm : Form
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthorService _authorService;
        public BookAddForm(IBookService bookService, ICategoryService categoryService,
            IAuthorService authorService)
        {
            InitializeComponent();
            _bookService = bookService;
            _categoryService = categoryService;
            _authorService = authorService;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void BookAddForm_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = await _categoryService.GetAllCategoriesAsync();
            lbxAuthors.DataSource = await _authorService.GetAllAuthorsAsync();
            lbxAuthors.SelectionMode = SelectionMode.MultiExtended;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var description = txtDescription.Text;
            var category = (Category)cmbCategories.SelectedItem;
            var authors = lbxAuthors.SelectedItems
                .Cast<Author>()
                .ToList();

            if(category == null)
            {
                MessageBox.Show("Please select category", "Select category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(authors.Count() == 0)
            {
                MessageBox.Show("Please select author", "Select author", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var book = new Book()
            {
                Title = title,
                Description = description,
                CategoryId = category.CategoryId
            };
            await _bookService.AddBookAsync(book);

            var bookId = book.BookId;
            book.BookAuthors = new List<BookAuthor>();

            foreach (var author in authors)
            {
                book.BookAuthors.Add(new BookAuthor() { BookId = bookId, AuthorId = author.AuthorId });
            }

            await _bookService.UpdateBookAsync(book);
            MessageBox.Show("Book added");
        }
    }
}
