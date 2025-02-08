using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Expense_Tracker
{
    public partial class CategoryForm : UserControl
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulo\Documents\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";
        public CategoryForm()
        {
            InitializeComponent();
            displayCategoryList();
        }

        public void displayCategoryList()
        {
            CategoryData categoryData = new CategoryData();
            List<CategoryData> categoryList = categoryData.categoryListData();
            category_dataGridView.DataSource = categoryList;
        }

        private void category_addBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertquery = "INSERT INTO categories (category, type, status, date_insert) " + "VALUES (@category, @type, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", category_type.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@status", category_status.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Category added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
            displayCategoryList();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        private int getID = 0;
        private void category_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = category_dataGridView.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    getID = Convert.ToInt32(row.Cells[0].Value);
                }
                category_category.Text = row.Cells[1].Value.ToString();
                category_type.SelectedItem = row.Cells[2].Value.ToString();
                category_status.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void category_updateBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this item (" + getID + ")?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string updatequery = "update categories set category = @category, type = @type, status = @status, date_insert = @date where id = @id";

                        using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", category_type.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", category_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@date", DateTime.Today);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Category updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }
                        conn.Close();
                    }
                }
            }
            displayCategoryList();
        }

        private void clearFields()
        {
            category_category.Clear();
            category_type.SelectedIndex = -1;
            category_status.SelectedIndex = -1;
        }
        private void category_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_deleteBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this item (" + getID + ")?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string updatequery = "delete from categories where id = @id";

                        using (SqlCommand cmd = new SqlCommand(updatequery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Category deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            displayCategoryList();
        }
    }
}
