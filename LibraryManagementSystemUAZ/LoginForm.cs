using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemUAZ.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if(username == "legit" && password == "123456")
            {
                var mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Wrong credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
