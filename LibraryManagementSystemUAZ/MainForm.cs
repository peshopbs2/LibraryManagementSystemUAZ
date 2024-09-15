using LibraryManagementSystemUAZ.Data.Data;
using LibraryManagementSystemUAZ.Services.Interfaces;
using LibraryManagementSystemUAZ.UI.Authors;
using LibraryManagementSystemUAZ.UI.Books;
using LibraryManagementSystemUAZ.UI.Categories;
using LibraryManagementSystemUAZ.UI.Members;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementSystemUAZ
{
    public partial class MainForm : Form
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IMemberService _memberService;
        public MainForm(IBookService bookService, IAuthorService authorService, ICategoryService categoryService, IMemberService memberService)
        {
            InitializeComponent();
            _bookService = bookService;
            _authorService = authorService;
            _categoryService = categoryService;
            _memberService = memberService;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await ReloadData();
        }

        private async Task ReloadData()
        {
            lblCategories.Text = $"Categories: {await _categoryService.CountAsync()}";
            lblAuthors.Text = $"Authors: {await _authorService.CountAsync()}";
            lblBooks.Text = $"Books: {await _bookService.CountAsync()}";
            lblMembers.Text = $"Members: {await _memberService.CountAsync()}";
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryForm = Program.ServiceProvider.GetRequiredService<CategoryListForm>();
            categoryForm.ShowDialog();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var bookForm = Program.ServiceProvider.GetRequiredService<BookListForm>();
            bookForm.ShowDialog();
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var authorsForm = Program.ServiceProvider.GetRequiredService<AuthorsListForm>();
            authorsForm.ShowDialog();
        }

        private void listToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var membersForm = Program.ServiceProvider.GetRequiredService<MembersListForm>();
            membersForm.ShowDialog();
        }

        private async void addToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            var categoryForm = Program.ServiceProvider.GetRequiredService<CategoryAddForm>();
            categoryForm.ShowDialog();
            await ReloadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryForm = Program.ServiceProvider.GetRequiredService<CategoryEditForm>();
            categoryForm.ShowDialog();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryForm = Program.ServiceProvider.GetRequiredService<CategoryDeleteForm>();
            categoryForm.ShowDialog();
            await ReloadData();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private async void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var authorForm = Program.ServiceProvider.GetRequiredService<AuthorsAddForm>();
            authorForm.ShowDialog();
            await ReloadData();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var authorForm = Program.ServiceProvider.GetRequiredService<AuthorsEditForm>();
            authorForm.ShowDialog();
        }

        private async void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var authorForm = Program.ServiceProvider.GetRequiredService<AuthorsDeleteForm>();
            authorForm.ShowDialog();
            await ReloadData();
        }

        private async void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var bookForm = Program.ServiceProvider.GetRequiredService<BookAddForm>();
            bookForm.ShowDialog();
            await ReloadData();
        }
    }
}
