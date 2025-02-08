using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Expense_Tracker
{
    internal class CategoryData
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulo\Documents\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Category { set; get; }
        public string Type { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<CategoryData> categoryListData()
        {
            List<CategoryData> categoryList = new List<CategoryData>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectQuery = "SELECT * FROM categories";
                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoryData categoryData = new CategoryData();
                            categoryData.ID = reader.GetInt32(0);
                            categoryData.Category = reader.GetString(1);
                            categoryData.Type = reader.GetString(2);
                            categoryData.Status = reader.GetString(3);
                            categoryData.Date = reader.GetDateTime(4).ToString("dd-MM-yyyy");

                            categoryList.Add(categoryData);
                        }
                    }
                }
            }
            return categoryList;
        }
    }
}
