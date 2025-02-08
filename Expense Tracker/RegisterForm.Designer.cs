namespace Expense_Tracker
{
    partial class RegisterForm
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
            register_loginBtn = new Button();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            register_btn = new Button();
            register_showPass = new CheckBox();
            register_password = new TextBox();
            label5 = new Label();
            register_username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            close = new Label();
            register_cPassword = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(register_loginBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 436);
            panel1.TabIndex = 11;
            // 
            // register_loginBtn
            // 
            register_loginBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_loginBtn.Location = new Point(12, 343);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(194, 47);
            register_loginBtn.TabIndex = 11;
            register_loginBtn.Text = "Sign in";
            register_loginBtn.UseVisualStyleBackColor = true;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 311);
            label6.Name = "label6";
            label6.Size = new Size(154, 21);
            label6.TabIndex = 11;
            label6.Text = "Sign in here";
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
            // register_btn
            // 
            register_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_btn.Location = new Point(268, 376);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(121, 47);
            register_btn.TabIndex = 19;
            register_btn.Text = "Signup";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += login_btn_Click;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Location = new Point(435, 343);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(108, 19);
            register_showPass.TabIndex = 18;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // register_password
            // 
            register_password.Location = new Point(268, 217);
            register_password.Name = "register_password";
            register_password.Size = new Size(275, 23);
            register_password.TabIndex = 17;
            register_password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(268, 184);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 16;
            label5.Text = "Password";
            // 
            // register_username
            // 
            register_username.Location = new Point(268, 142);
            register_username.Name = "register_username";
            register_username.Size = new Size(275, 23);
            register_username.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(268, 109);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 14;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(340, 48);
            label3.Name = "label3";
            label3.Size = new Size(132, 27);
            label3.TabIndex = 13;
            label3.Text = "Register";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(774, 9);
            close.Name = "close";
            close.Size = new Size(20, 21);
            close.TabIndex = 12;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(268, 295);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.Size = new Size(275, 23);
            register_cPassword.TabIndex = 21;
            register_cPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 262);
            label1.Name = "label1";
            label1.Size = new Size(185, 19);
            label1.TabIndex = 20;
            label1.Text = "Confirm Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 436);
            Controls.Add(register_cPassword);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(register_btn);
            Controls.Add(register_showPass);
            Controls.Add(register_password);
            Controls.Add(label5);
            Controls.Add(register_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button register_loginBtn;
        private Label label6;
        private Label label2;
        private PictureBox pictureBox1;
        private Button register_btn;
        private CheckBox register_showPass;
        private TextBox register_password;
        private Label label5;
        private TextBox register_username;
        private Label label4;
        private Label label3;
        private Label close;
        private TextBox register_cPassword;
        private Label label1;
    }
}