using Microsoft.Data.SqlClient;


namespace Expense_Tracker
{
    public partial class IncomeForm : UserControl
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulo\Documents\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";
        public IncomeForm()
        {
            InitializeComponent();

            displayCategoryList("Income", "Active");
        }

        public void displayIncomeList()
        {
            IncomeData incomeData = new IncomeData();
            List<IncomeData> incomeList = incomeData.incomeListData();
            income_dataGridView.DataSource = incomeList;
        }

        public void displayCategoryList(string categoryType, string categoryStatus)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@type", categoryType);
                    cmd.Parameters.AddWithValue("@status", categoryStatus);

                    income_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        income_category.Items.Add(reader["category"].ToString());
                    }
                }
            }
        }

        private void category_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please fill out all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertquery = "INSERT INTO income (category, item, income, description, date_income, date_inserted) " + "VALUES (@category, @item, @income, @description, @date_in, @date)";
                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@category", income_category.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", income_item.Text.Trim());
                        cmd.Parameters.AddWithValue("@income", income_income.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", income_description.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_in", income_date.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Income added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void clearFields()
        {
            income_category.SelectedIndex = -1;
            income_item.Text = "";
            income_income.Text = "";
            income_description.Text = "";
            income_date.Value = DateTime.Today;
        }
        private void income_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void income_updateBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updatequery = "update income set (" +
                        "category = @category, " +
                        "item = @item, " +
                        "income = @income, " +
                        "description = @description, " +
                        "date_income = @date_in, " +
                        "where id = @id";
                    using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                    {
                        cmd.Parameters.AddWithValue("@category", income_category.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", income_item.Text.Trim());
                        cmd.Parameters.AddWithValue("@income", income_income.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", income_description.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_in", income_date.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Income updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void income_deleteBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please fill out all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string deletequery = "delete from income where id = @id";
                    using (SqlCommand cmd = new SqlCommand(deletequery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", getID);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Income deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private int getID = 0;
        private void income_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event here
        }
    }
}


