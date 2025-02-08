namespace Expense_Tracker
{
    partial class MainForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            logut_btn = new Button();
            expenses_btn = new Button();
            income_btn = new Button();
            addCategory_btn = new Button();
            dashboard_btn = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            incomeForm1 = new IncomeForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 51);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_avatar_profile_icon;
            pictureBox1.Location = new Point(3, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 21);
            label1.TabIndex = 14;
            label1.Text = "Income and Expense tracker";
            label1.Click += label1_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(775, 9);
            close.Name = "close";
            close.Size = new Size(20, 21);
            close.TabIndex = 13;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(logut_btn);
            panel2.Controls.Add(expenses_btn);
            panel2.Controls.Add(income_btn);
            panel2.Controls.Add(addCategory_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.Snow;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 422);
            panel2.TabIndex = 1;
            // 
            // logut_btn
            // 
            logut_btn.AutoSize = true;
            logut_btn.BackColor = Color.RosyBrown;
            logut_btn.FlatAppearance.BorderSize = 0;
            logut_btn.FlatStyle = FlatStyle.Flat;
            logut_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logut_btn.ForeColor = Color.WhiteSmoke;
            logut_btn.Image = Properties.Resources.clock_icon;
            logut_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logut_btn.Location = new Point(12, 390);
            logut_btn.Name = "logut_btn";
            logut_btn.Size = new Size(151, 29);
            logut_btn.TabIndex = 20;
            logut_btn.Text = "Logout";
            logut_btn.UseVisualStyleBackColor = false;
            logut_btn.Click += logut_btn_Click;
            // 
            // expenses_btn
            // 
            expenses_btn.AutoSize = true;
            expenses_btn.BackColor = Color.RosyBrown;
            expenses_btn.FlatAppearance.BorderSize = 0;
            expenses_btn.FlatStyle = FlatStyle.Flat;
            expenses_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expenses_btn.ForeColor = Color.WhiteSmoke;
            expenses_btn.Image = Properties.Resources.clock_icon;
            expenses_btn.ImageAlign = ContentAlignment.MiddleLeft;
            expenses_btn.Location = new Point(12, 278);
            expenses_btn.Name = "expenses_btn";
            expenses_btn.Size = new Size(151, 29);
            expenses_btn.TabIndex = 19;
            expenses_btn.Text = "Expenses";
            expenses_btn.UseVisualStyleBackColor = false;
            // 
            // income_btn
            // 
            income_btn.AutoSize = true;
            income_btn.BackColor = Color.RosyBrown;
            income_btn.FlatAppearance.BorderSize = 0;
            income_btn.FlatStyle = FlatStyle.Flat;
            income_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_btn.ForeColor = Color.WhiteSmoke;
            income_btn.Image = Properties.Resources.clock_icon;
            income_btn.ImageAlign = ContentAlignment.MiddleLeft;
            income_btn.Location = new Point(12, 243);
            income_btn.Name = "income_btn";
            income_btn.Size = new Size(151, 29);
            income_btn.TabIndex = 18;
            income_btn.Text = "Income";
            income_btn.UseVisualStyleBackColor = false;
            // 
            // addCategory_btn
            // 
            addCategory_btn.AutoSize = true;
            addCategory_btn.BackColor = Color.RosyBrown;
            addCategory_btn.FlatAppearance.BorderSize = 0;
            addCategory_btn.FlatStyle = FlatStyle.Flat;
            addCategory_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategory_btn.ForeColor = Color.WhiteSmoke;
            addCategory_btn.Image = Properties.Resources.clock_icon;
            addCategory_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addCategory_btn.Location = new Point(12, 208);
            addCategory_btn.Name = "addCategory_btn";
            addCategory_btn.Size = new Size(151, 29);
            addCategory_btn.TabIndex = 17;
            addCategory_btn.Text = "Add Category";
            addCategory_btn.UseVisualStyleBackColor = false;
            // 
            // dashboard_btn
            // 
            dashboard_btn.AutoSize = true;
            dashboard_btn.BackColor = Color.RosyBrown;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.WhiteSmoke;
            dashboard_btn.Image = Properties.Resources.clock_icon;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 163);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(151, 29);
            dashboard_btn.TabIndex = 16;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 15;
            label2.Text = "Welcome,";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_avatar_profile_icon;
            pictureBox2.Location = new Point(31, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(incomeForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(177, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(621, 422);
            panel3.TabIndex = 2;
            // 
            // incomeForm1
            // 
            incomeForm1.Location = new Point(0, 0);
            incomeForm1.Name = "incomeForm1";
            incomeForm1.Size = new Size(621, 422);
            incomeForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 473);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Button dashboard_btn;
        private Button logut_btn;
        private Button expenses_btn;
        private Button income_btn;
        private Button addCategory_btn;
        private Panel panel3;
        private CategoryForm categoryForm1;
        private IncomeForm incomeForm1;
    }
}