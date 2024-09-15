using LibraryManagementSystemUAZ.Data.Entities;
using LibraryManagementSystemUAZ.Services;
using LibraryManagementSystemUAZ.Services.Interfaces;
using LibraryManagementSystemUAZ.UI.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemUAZ.UI.Authors
{
    public partial class AuthorsEditForm : Form
    {
        private readonly IAuthorService _authorService;
        public AuthorsEditForm(IAuthorService authorService)
        {
            _authorService = authorService;
            InitializeComponent();
        }

        private async void AuthorEditForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _authorService.GetAllAuthorsAsync();
            dataGridView1.SelectionMode = DataGridViewSelectionMode
                .FullRowSelect;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Author author = (Author)dataGridView1.SelectedRows[0].DataBoundItem;
            AuthorUpdateForm authorUpdateForm =
                new AuthorUpdateForm(_authorService, author);
            authorUpdateForm.ShowDialog();
            dataGridView1.Refresh();
        }
    }
}
