﻿using LibraryManagementSystemUAZ.Services.Interfaces;
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
    public partial class AuthorsListForm : Form
    {
        private readonly IAuthorService _authorService;
        public AuthorsListForm(IAuthorService authorService)
        {
            InitializeComponent();
            _authorService = authorService;
        }

        private async void AuthorsListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (await _authorService.GetAllAuthorsAsync());
        }
    }
}
