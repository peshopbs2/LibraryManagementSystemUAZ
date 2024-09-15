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
    public partial class CategoryListForm : Form
    {
        private ICategoryService _categoryService;
        public CategoryListForm(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private async void CategoryListForm_LoadAsync(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await
                _categoryService.GetAllCategoriesAsync();
        }
    }
}
