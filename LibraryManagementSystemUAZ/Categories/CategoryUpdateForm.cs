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
    public partial class CategoryUpdateForm : Form
    {
        private readonly ICategoryService _categoryService;
        private readonly Category _category;
        public CategoryUpdateForm(ICategoryService categoryService, Category category)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _category = category;
        }

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            txtName.Text = _category.Name;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            _category.Name = txtName.Text;
            await _categoryService.UpdateCategoryAsync(_category);
            MessageBox.Show("Category updated successfully!", "Category update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
