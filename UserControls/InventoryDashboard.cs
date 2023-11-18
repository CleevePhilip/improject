using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace improject.UserController
{
    public partial class InventoryDashboard : UserControl
    {
        private string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";

        public InventoryDashboard()
        {
            InitializeComponent();
            FetchFoodId();
            FetchIngredientId();
            FetchMenu();
            FetchOrderCount();
            FetchOrderAmount();
            FetchLastOrderDate();
        }
        public void RefreshTable() 
        {
            FetchMenu();
        }
        private void FetchFoodId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT foodName FROM menu";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string selectedFood = reader["foodName"].ToString();
                            FoodIdOpt.Items.Add(selectedFood);
                        }
                    }
                }
            }
        }

        public void FetchIngredientId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IngredientName FROM Ingredients";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string selectedIngredient = reader["IngredientName"].ToString();
                            IngredientIdOpt.Items.Add(selectedIngredient);
                        }
                    }
                }
            }
        }

        public void FetchMenu()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Inventory";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable menuTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(menuTable);
                    }
                    MenuItemTable.DataSource = menuTable;
                }
            }
        }

        private void RedirectIngredients_Click(object sender, EventArgs e)
        {
            AddIngredients addIngredients = new AddIngredients();
            addIngredients.Show();
        }

        private void MenuIngredientRed_Click(object sender, EventArgs e)
        {
            MenuIngredients menuIngredients = new MenuIngredients();
            menuIngredients.Show();
        }

        private void AddIngToFood_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string foodName = FoodIdOpt.Text;
                    string ingredient = IngredientIdOpt.Text;
                    decimal reqMes = decimal.Parse(ReqMeasurement.Text);

                    if (!string.IsNullOrEmpty(foodName) && !string.IsNullOrEmpty(ingredient))
                    {
                        SqlCommand cmd = new SqlCommand("InsertMenuIngredient", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@foodName", foodName);
                        cmd.Parameters.AddWithValue("@IngredientName", ingredient);
                        cmd.Parameters.AddWithValue("@FoodMesReq", reqMes);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Successfully added ingredients in " + ingredient);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Food or ingredient name cannot be empty.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void FoodIdOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFood = FoodIdOpt.SelectedItem.ToString();
            MessageBox.Show("Food Name: " + selectedFood);
        }

        private void IngredientIdOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIngredient = IngredientIdOpt.SelectedItem.ToString();
            MessageBox.Show($"{selectedIngredient} is added as an ingredient");
        }

        private void ReqMeasurement_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void MenuItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void label8_Click(object sender, EventArgs e)
        {
          
        }
        public void FetchOrderCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.CountAllOrders()", connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            label8.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public void FetchOrderAmount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.CalculateTotalOrderAmount()", connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            label10.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public void FetchLastOrderDate()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.GetLastOrderDate()", connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            DateTime lastOrderDate = (DateTime)result;
                            label11.Text = lastOrderDate.ToString("yyyy-MM-dd");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void StockRed_Click(object sender, EventArgs e)
        {
            StockTransactions stockTransactions = new StockTransactions(this); // Pass a reference to the current form
            stockTransactions.Show();

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}