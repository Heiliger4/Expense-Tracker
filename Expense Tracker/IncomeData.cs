using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Expense_Tracker
{
    internal class IncomeData
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\paulo\Documents\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Income { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }

        public List<IncomeData> incomeListData()
        {
            List<IncomeData> incomeList = new List<IncomeData>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM income";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData incomeData = new IncomeData();
                        incomeData.ID = Convert.ToInt32(reader["id"]);
                        incomeData.Category = reader["category"].ToString();
                        incomeData.Item = reader["item"].ToString();
                        incomeData.Income = reader["income"].ToString();
                        incomeData.Description = reader["description"].ToString();
                        incomeData.Date = Convert.ToDateTime(reader["date_income"]).ToString("MM-dd-yyyy");
                        incomeList.Add(incomeData);
                    }
                }
            }
            return incomeList;
        }
    }
}
