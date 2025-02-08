namespace Expense_Tracker
{
    partial class Form1
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
            panel1 = new Panel();
            login_signupBtn = new Button();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            close = new Label();
            label3 = new Label();
            label4 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label5 = new Label();
            login_showPass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(login_signupBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 420);
            panel1.TabIndex = 0;
            // 
            // login_signupBtn
            // 
            login_signupBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_signupBtn.Location = new Point(12, 337);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(194, 47);
            login_signupBtn.TabIndex = 11;
            login_signupBtn.Text = "Sign up";
            login_signupBtn.UseVisualStyleBackColor = true;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 297);
            label6.Name = "label6";
            label6.Size = new Size(132, 27);
            label6.TabIndex = 11;
            label6.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 124);
            label2.Name = "label2";
            label2.Size = new Size(194, 12);
            label2.TabIndex = 1;
            label2.Text = "Income and Expenses Tracker";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_avatar_profile_icon;
            pictureBox1.Location = new Point(41, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(768, 9);
            close.Name = "close";
            close.Size = new Size(20, 21);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 48);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 2;
            label3.Text = "Sign in";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(262, 109);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // login_username
            // 
            login_username.Location = new Point(262, 142);
            login_username.Name = "login_username";
            login_username.Size = new Size(275, 23);
            login_username.TabIndex = 5;
            // 
            // login_password
            // 
            login_password.Location = new Point(262, 228);
            login_password.Name = "login_password";
            login_password.Size = new Size(275, 23);
            login_password.TabIndex = 7;
            login_password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(262, 195);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(429, 257);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(108, 19);
            login_showPass.TabIndex = 9;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(262, 297);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(121, 47);
            login_btn.TabIndex = 10;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(label5);
            Controls.Add(login_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label close;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox login_username;
        private TextBox login_password;
        private Label label5;
        private CheckBox login_showPass;
        private Button login_btn;
        private Button login_signupBtn;
        private Label label6;
    }
}
