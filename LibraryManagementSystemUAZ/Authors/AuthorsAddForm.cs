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
    public partial class AuthorsAddForm : Form
    {
        private readonly IAuthorService _authorService;
        public AuthorsAddForm(IAuthorService authorService)
        {
            _authorService = authorService;
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var bio = txtBio.Text;

            var author = new Author()
            {
                Name = name,
                Bio = bio
            };
            await _authorService.AddAuthorAsync(author);
            MessageBox.Show("The author has been added!", "Add author", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
