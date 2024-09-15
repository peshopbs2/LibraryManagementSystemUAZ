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
    public partial class CategoryDeleteForm : Form
    {
        private readonly ICategoryService _categoryService;
        public CategoryDeleteForm(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private async void CategoryDeleteForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _categoryService.GetAllCategoriesAsync();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you want to delete the category?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                var category = (Category)(dataGridView1.SelectedRows[0].DataBoundItem);

                await _categoryService.DeleteCategoryAsync(category.CategoryId);

                dataGridView1.DataSource = await _categoryService.GetAllCategoriesAsync();
                dataGridView1.Refresh();
            }
        }
    }
}
