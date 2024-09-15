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
    public partial class CategoryEditForm : Form
    {
        private readonly ICategoryService _categoryService;
        public CategoryEditForm(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Category category = (Category)dataGridView1.SelectedRows[0].DataBoundItem;
            CategoryUpdateForm categoryUpdateForm =
                new CategoryUpdateForm(_categoryService, category);
            categoryUpdateForm.ShowDialog();
            dataGridView1.Refresh();
        }

        private async void CategoryEditForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _categoryService.GetAllCategoriesAsync();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
