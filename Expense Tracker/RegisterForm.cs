using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Expense_Tracker
{
    public partial class RegisterForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulo\Documents\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrEmpty(register_username.Text) ||
                string.IsNullOrEmpty(register_password.Text) ||
                string.IsNullOrEmpty(register_cPassword.Text))
            {
                MessageBox.Show("Please fill out all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text != register_cPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    // Check if the username already exists
                    string selectUsername = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@username", register_username.Text.Trim());

                        int userCount = (int)checkUser.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show($"{register_username.Text.Trim()} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO users (username, password, date_create) VALUES (@userName, @pass, @date)";
                    using (SqlCommand insertUser = new SqlCommand(insertQuery, connect))
                    {
                        insertUser.Parameters.AddWithValue("@userName", register_username.Text.Trim());
                        insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim()); // Hash the password
                        insertUser.Parameters.AddWithValue("@date", DateTime.Today);

                        insertUser.ExecuteNonQuery();
                        register_username.Clear();
                        register_password.Clear();
                        register_cPassword.Clear();
                        MessageBox.Show("User registered successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Open the login form
                        Form1 loginForm = new Form1();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.UseSystemPasswordChar = !register_showPass.Checked;
            register_cPassword.UseSystemPasswordChar = !register_showPass.Checked;
        }

    }
}
