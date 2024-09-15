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

namespace LibraryManagementSystemUAZ.UI.Authors
{
    public partial class AuthorUpdateForm : Form
    {
        private readonly IAuthorService _authorService;
        private readonly Author _author;
        public AuthorUpdateForm(IAuthorService authorService, Author author)
        {
            InitializeComponent();
            _authorService = authorService;
            _author = author;
            txtName.Text = _author.Name;
            txtBio.Text = _author.Bio;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            _author.Name = txtName.Text;
            _author.Bio = txtBio.Text;
            await _authorService.UpdateAuthorAsync(_author);
            MessageBox.Show("Author updated successfully!", "Author update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void AuthorUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
