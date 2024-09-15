using LibraryManagementSystemUAZ.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemUAZ.UI.Members
{
    public partial class MembersListForm : Form
    {
        private readonly IMemberService _memberService;
        public MembersListForm(IMemberService memberService)
        {
            InitializeComponent();
            _memberService = memberService;
        }

        private async void MembersListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await _memberService.GetAllMembersAsync();
        }
    }
}
