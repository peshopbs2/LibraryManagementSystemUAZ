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

namespace LibraryManagementSystemUAZ.UI.Categories
{
    public partial class CategoryAddForm : Form
    {
        private readonly ICategoryService _categoryService;
        public CategoryAddForm(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var category = new Category()
            {
                Name = name
            };
            await _categoryService.AddCategoryAsync(category);
            MessageBox.Show("The category has been added!", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
