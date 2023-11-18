using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace improject
{
    public partial class HomeDashboard : UserControl
    {
        private string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
        public HomeDashboard()
        {
            InitializeComponent();
            PopulateOrderDetails();
            CreateChart();
            FetchCountLowStock();
            SetSoldOutMenuText();
            FetchLowIngredient();
            FetchSystemUser();
        }
       
        private void HomeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PopulateOrderDetails()
        {

            string query = "SELECT * FROM OrderDetails";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                DetailTable.DataSource = table;
            }
        }

        private void CreateChart()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("GetFoodQuantityTotals", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                chart1.Series.Clear();
                Series series = new Series("Quantity");
                series.ChartType = SeriesChartType.Bar;
                series.XValueMember = "FoodID";
                series.YValueMembers = "TotalQuantity";
                chart1.Series.Add(series);
                chart1.DataSource = table;
                chart1.DataBind();
            }
        }

     private void FetchLowIngredient()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Error" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void FetchCountLowStock()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT dbo.CountLowStock() AS LowStockCount";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int lowStockCount = reader.GetInt32(reader.GetOrdinal("LowStockCount"));
                            CountLowIng.Text = lowStockCount.ToString();
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
        private void SetSoldOutMenuText()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT dbo.CountZeroQuantityIngredients() AS ZeroQuantityCount", connection))
                    {
                        int zeroQuantityCount = (int)command.ExecuteScalar();
                        SoldOutMenu.Text = zeroQuantityCount.ToString() ;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void FetchSystemUser()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT dbo.GetUserCount() AS UserCount", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int userCount = Convert.ToInt32(reader["UserCount"]);
                        label8.Text = userCount.ToString();
                    }

                    reader.Close();
                }
            }
        }

        private void CountLowIng_Click(object sender, EventArgs e)
        {

        }

        private void SoldOutMenu_Click(object sender, EventArgs e)
        {

        }

        private void DetailTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
