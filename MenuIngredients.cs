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

namespace improject
{
    public partial class MenuIngredients : Form
    {
        private string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
   

        public MenuIngredients()
        {
            InitializeComponent();
            FetchIngredientId();
            FetchMenuIngTable();
            FetchFoodId();
        }

        public void FetchMenuIngTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM MenuItemIngredients";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    MenuIngredientTable.DataSource = dataTable;
                }
            }
        }
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM MenuItemIngredients WHERE MenuItemIngredientID = @MenuItemIngredientID ";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@MenuItemIngredientID", Mingredient.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {             
                            decimal reqMeasurement = reader.GetDecimal(reader.GetOrdinal("FoodMesReq"));
                            ReqMeasurement.Text = reqMeasurement.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified criteria.");
                        }
                    }
                }
            }
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
                            FName.Items.Add(selectedFood);
                        }
                    }
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Mingredient.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "DELETE FROM MenuItemIngredients WHERE MenuItemIngredientID = @MenuItemIngredientID";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MenuItemIngredientID", Mingredient.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.");

                            FetchMenuIngTable();
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted. Please check the MenuItemIngredientID.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid MenuItemIngredientID to delete.");
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
                            Iname.Items.Add(selectedIngredient);
                        }
                    }
                }
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Mingredient.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE MenuItemIngredients SET FoodName = @FoodName, IngredientName = @IngredientName, FoodMesReq = @FoodMesReq WHERE MenuItemIngredientID = @MenuItemIngredientID";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FoodName", FName.SelectedItem);
                        command.Parameters.AddWithValue("@IngredientName", Iname.SelectedItem);
                        command.Parameters.AddWithValue("@FoodMesReq", ReqMeasurement.Text);
                        command.Parameters.AddWithValue("@MenuItemIngredientID", Mingredient.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                     
                            MessageBox.Show("Row updated successfully.");
                            FetchMenuIngTable(); 
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Please check the MenuItemIngredientID.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid MenuItemIngredientID to update.");
            }
        }

        private void MenuIngredientTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuIngredients_Load(object sender, EventArgs e)
        {

        }
    }
}