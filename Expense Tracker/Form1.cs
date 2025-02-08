using Microsoft.Data.SqlClient;
using System.Data;
namespace Expense_Tracker
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulo\Documents\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Check if username or password is empty
            if (string.IsNullOrWhiteSpace(login_username.Text))
            {
                MessageBox.Show("Please enter a username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Please enter a password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // SQL query to select user based on username and password
                    string selectData = "SELECT * FROM users WHERE username = @username AND password = @pass";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        // Add parameters to the SQL query
                        cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the result of the query
                        adapter.Fill(dataTable);

                        // Check if any record exists for the entered username and password
                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            login_password.Clear();
                            login_username.Clear();

                            MainForm mForm = new MainForm();
                            mForm.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Catch SQL-specific exceptions, such as connection issues
                MessageBox.Show($"An error occurred while connecting to the database: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Catch any general exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.UseSystemPasswordChar = !login_showPass.Checked;
        }
    }
}
