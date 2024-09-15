namespace LibraryManagementSystemUAZ.UI.Books
{
    partial class BookAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbxAuthors = new ListBox();
            label5 = new Label();
            cmbCategories = new ComboBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            txtTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbxAuthors);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbCategories);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(42, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 481);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // lbxAuthors
            // 
            lbxAuthors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbxAuthors.FormattingEnabled = true;
            lbxAuthors.ItemHeight = 21;
            lbxAuthors.Location = new Point(15, 305);
            lbxAuthors.Name = "lbxAuthors";
            lbxAuthors.Size = new Size(617, 88);
            lbxAuthors.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 270);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 7;
            label5.Text = "Author/s";
            // 
            // cmbCategories
            // 
            cmbCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(15, 227);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(617, 29);
            cmbCategories.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 183);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 5;
            label4.Text = "Category";
            label4.Click += label4_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDescription.Location = new Point(15, 141);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(617, 29);
            txtDescription.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 437);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtTitle.Location = new Point(15, 54);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(617, 29);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 0;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(277, 37);
            label1.Name = "label1";
            label1.Size = new Size(160, 45);
            label1.TabIndex = 4;
            label1.Text = "Add Book";
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "BookAddForm";
            Text = "BookAddForm";
            Load += BookAddForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescription;
        private Label label3;
        private Button btnAdd;
        private TextBox txtTitle;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cmbCategories;
        private ListBox lbxAuthors;
        private Label label5;
    }
}