using LibraryManagementSystemUAZ.Data.Entities;
using LibraryManagementSystemUAZ.Services;
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
    public partial class AuthorsDeleteForm : Form
    {
        private readonly IAuthorService _authorService;
        public AuthorsDeleteForm(IAuthorService authorService)
        {
            InitializeComponent();
            _authorService = authorService;
        }

        private async void AuthorDeleteForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _authorService.GetAllAuthorsAsync();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you want to delete the author?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                var author = (Author)(dataGridView1.SelectedRows[0].DataBoundItem);
                await _authorService.DeleteAuthorAsync(author.AuthorId);

                dataGridView1.DataSource = await _authorService.GetAllAuthorsAsync();
                dataGridView1.Refresh();
            }
        }
    }
}
