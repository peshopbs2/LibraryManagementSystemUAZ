



namespace LibraryManagementSystemUAZ
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem1 = new ToolStripMenuItem();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            authorsToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem2 = new ToolStripMenuItem();
            addToolStripMenuItem2 = new ToolStripMenuItem();
            editToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem3 = new ToolStripMenuItem();
            addToolStripMenuItem3 = new ToolStripMenuItem();
            editToolStripMenuItem3 = new ToolStripMenuItem();
            deleteToolStripMenuItem3 = new ToolStripMenuItem();
            lblCategories = new Label();
            lblBooks = new Label();
            lblMembers = new Label();
            lblAuthors = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, categoriesToolStripMenuItem, booksToolStripMenuItem, authorsToolStripMenuItem, membersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem, addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(75, 20);
            categoriesToolStripMenuItem.Text = "Categories";
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(107, 22);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(107, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_ClickAsync;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem1, addToolStripMenuItem1, editToolStripMenuItem1, deleteToolStripMenuItem1, toolStripMenuItem2 });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(51, 20);
            booksToolStripMenuItem.Text = "Books";
            // 
            // listToolStripMenuItem1
            // 
            listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            listToolStripMenuItem1.Size = new Size(180, 22);
            listToolStripMenuItem1.Text = "List";
            listToolStripMenuItem1.Click += listToolStripMenuItem1_Click;
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(180, 22);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(180, 22);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(180, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "...";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // authorsToolStripMenuItem
            // 
            authorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem2, addToolStripMenuItem2, editToolStripMenuItem2, deleteToolStripMenuItem2, toolStripMenuItem3 });
            authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            authorsToolStripMenuItem.Size = new Size(61, 20);
            authorsToolStripMenuItem.Text = "Authors";
            // 
            // listToolStripMenuItem2
            // 
            listToolStripMenuItem2.Name = "listToolStripMenuItem2";
            listToolStripMenuItem2.Size = new Size(180, 22);
            listToolStripMenuItem2.Text = "List";
            listToolStripMenuItem2.Click += listToolStripMenuItem2_Click;
            // 
            // addToolStripMenuItem2
            // 
            addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            addToolStripMenuItem2.Size = new Size(180, 22);
            addToolStripMenuItem2.Text = "Add";
            addToolStripMenuItem2.Click += addToolStripMenuItem2_Click;
            // 
            // editToolStripMenuItem2
            // 
            editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            editToolStripMenuItem2.Size = new Size(180, 22);
            editToolStripMenuItem2.Text = "Edit";
            editToolStripMenuItem2.Click += editToolStripMenuItem2_Click;
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(180, 22);
            deleteToolStripMenuItem2.Text = "Delete";
            deleteToolStripMenuItem2.Click += deleteToolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "...";
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem3, addToolStripMenuItem3, editToolStripMenuItem3, deleteToolStripMenuItem3 });
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Size = new Size(69, 20);
            membersToolStripMenuItem.Text = "Members";
            // 
            // listToolStripMenuItem3
            // 
            listToolStripMenuItem3.Name = "listToolStripMenuItem3";
            listToolStripMenuItem3.Size = new Size(107, 22);
            listToolStripMenuItem3.Text = "List";
            listToolStripMenuItem3.Click += listToolStripMenuItem3_Click;
            // 
            // addToolStripMenuItem3
            // 
            addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            addToolStripMenuItem3.Size = new Size(107, 22);
            addToolStripMenuItem3.Text = "Add";
            // 
            // editToolStripMenuItem3
            // 
            editToolStripMenuItem3.Name = "editToolStripMenuItem3";
            editToolStripMenuItem3.Size = new Size(107, 22);
            editToolStripMenuItem3.Text = "Edit";
            // 
            // deleteToolStripMenuItem3
            // 
            deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            deleteToolStripMenuItem3.Size = new Size(107, 22);
            deleteToolStripMenuItem3.Text = "Delete";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCategories.ForeColor = Color.Black;
            lblCategories.Location = new Point(39, 45);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(172, 45);
            lblCategories.TabIndex = 1;
            lblCategories.Text = "Categories";
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBooks.ForeColor = Color.Black;
            lblBooks.Location = new Point(39, 130);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(106, 45);
            lblBooks.TabIndex = 2;
            lblBooks.Text = "Books";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMembers.ForeColor = Color.Black;
            lblMembers.Location = new Point(461, 130);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(155, 45);
            lblMembers.TabIndex = 4;
            lblMembers.Text = "Members";
            // 
            // lblAuthors
            // 
            lblAuthors.AutoSize = true;
            lblAuthors.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAuthors.ForeColor = Color.Black;
            lblAuthors.Location = new Point(461, 45);
            lblAuthors.Name = "lblAuthors";
            lblAuthors.Size = new Size(132, 45);
            lblAuthors.TabIndex = 3;
            lblAuthors.Text = "Authors";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMembers);
            Controls.Add(lblAuthors);
            Controls.Add(lblBooks);
            Controls.Add(lblCategories);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem authorsToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem2;
        private ToolStripMenuItem addToolStripMenuItem2;
        private ToolStripMenuItem editToolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Label lblCategories;
        private Label lblBooks;
        private Label lblMembers;
        private Label lblAuthors;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem3;
        private ToolStripMenuItem addToolStripMenuItem3;
        private ToolStripMenuItem editToolStripMenuItem3;
        private ToolStripMenuItem deleteToolStripMenuItem3;
    }
}
