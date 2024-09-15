namespace LibraryManagementSystemUAZ.UI.Authors
{
    partial class AuthorsAddForm
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
            btnAdd = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtBio = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 323);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(15, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(617, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(268, 19);
            label1.Name = "label1";
            label1.Size = new Size(186, 45);
            label1.TabIndex = 2;
            label1.Text = "Add Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(48, 32);
            label3.TabIndex = 3;
            label3.Text = "Bio";
            // 
            // txtBio
            // 
            txtBio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBio.Location = new Point(15, 141);
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(617, 29);
            txtBio.TabIndex = 4;
            // 
            // AuthorsAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "AuthorsAddForm";
            Text = "AuthorsAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtBio;
        private Label label3;
    }
}