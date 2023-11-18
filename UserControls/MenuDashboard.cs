using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace improject
{
    public partial class MenuDashboard : UserControl
    {
    
        public MenuDashboard()
        {
       
            InitializeComponent();
            populateTableFoodMenu();
            LoadCategories();
            CategoryOption.Items.Add("All Categories");

        }

        public void RefreshTable()
        {
            populateTableFoodMenu();
        }
        private void populateTableFoodMenu() {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM menu";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable= new DataTable();   
                        adapter.Fill(dataTable);
                        TableFoodMenu.DataSource = dataTable;
                        connection.Close();
                    }
                }
            }

        }
        private void TableFoodMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadCategories()
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT categoryName FROM categoryMenu";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string categoryName = reader["categoryName"].ToString();
                            CategoryOption.Items.Add(categoryName); 
                           
                        }
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            string foodIdText = FoodIDManipulate.Text;

            if (string.IsNullOrEmpty(foodIdText))
            {
                MessageBox.Show("Error: Food ID is empty. Please enter a valid Food ID.");
                return;
            }

            if (!int.TryParse(foodIdText, out int foodIdManipulate))
            {
                MessageBox.Show("Error: Food ID is not a valid integer.");
                return;
            }

            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT foodName, foodPrice, Image, categoryID, description " +
                                   "FROM menu WHERE foodID = @FoodID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FoodID", foodIdManipulate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FoodManipulate.Text = reader["foodName"].ToString();
                                DescriptionManipulate.Text = reader["description"].ToString();
                                CategoryManipulate.Text = reader["categoryID"].ToString();
                                PriceManipulate.Text = reader["foodPrice"].ToString(); // Removed unnecessary conversion

                                string base64Image = reader["Image"].ToString();
                                byte[] imageBytes = Convert.FromBase64String(base64Image);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    MnptImg.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for Food ID: " + foodIdManipulate);
                            }
                        }
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

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            string foodIdText = FoodIDManipulate.Text;

            if (string.IsNullOrEmpty(foodIdText))
            {
                MessageBox.Show("Error: Cannot update if ID is empty!");
                return;
            }

            if (!int.TryParse(foodIdText, out int foodId))
            {
                MessageBox.Show("Error: Food ID is not a valid integer.");
                return;
            }

            string foodName = FoodManipulate.Text;
            string desc = DescriptionManipulate.Text;
            int cat = Convert.ToInt32(CategoryManipulate.Text);
            float price = float.Parse(PriceManipulate.Text);

            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(desc) || CategoryManipulate.Text == "" || PriceManipulate.Text == "")
                    {
                        MessageBox.Show("Please fill all the inputs");
                        return;
                    }
                    string query = "UPDATE menu " +
                                   "SET foodName = @FoodName, foodPrice = @FoodPrice, categoryID = @CategoryID, description = @Description, Image = @Picture " +
                                   "WHERE foodID = @FoodID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FoodName", foodName);
                        command.Parameters.AddWithValue("@FoodPrice", price);
                        command.Parameters.AddWithValue("@CategoryID", cat);
                        command.Parameters.AddWithValue("@Description", desc);
                        command.Parameters.AddWithValue("@FoodID", foodId);

                        if (!string.IsNullOrEmpty(base64Image))
                        {
                            command.Parameters.AddWithValue("@Picture", base64Image);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Picture", DBNull.Value);
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully updated Food menu.");
                            RefreshTable();
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Food ID not found.");
                        }
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

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            string foodIdText = FoodIDManipulate.Text;

            if (string.IsNullOrEmpty(foodIdText))
            {
                MessageBox.Show("Error: Cannot delete if ID is empty!");
                return;
            }

            if (!int.TryParse(foodIdText, out int foodId))
            {
                MessageBox.Show("Error: Food ID is not a valid integer.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DeleteCategoryAndRelatedData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FoodID", foodId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Food ID " + foodId + " deleted successfully.");
                        RefreshTable();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message);
                }
            }
        }

        private void CategoryOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategoryName = CategoryOption.SelectedItem.ToString();
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT foodID, foodName, foodPrice, categoryID, description, Image, categoryName FROM menu";

                if (selectedCategoryName != "All Categories")
                {
                    query += " WHERE categoryName = @CategoryName";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (selectedCategoryName != "All Categories")
                    {
                        command.Parameters.AddWithValue("@CategoryName", selectedCategoryName);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        TableFoodMenu.DataSource = dataTable;
                    }
                }
            }

            MessageBox.Show("Selected Category: " + selectedCategoryName);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            FoodIDManipulate.Text = "";
            FoodManipulate.Text = "";
            DescriptionManipulate.Text = "";
            CategoryManipulate.Text = "";
            PriceManipulate.Text = "";
        }

        private void AddMenuBtn_Click_1(object sender, EventArgs e)
        {
            AddFoodMenuDashboard addMenu = new AddFoodMenuDashboard(this);
            addMenu.Show();
        }
        private void CategoryBtn_Click_1(object sender, EventArgs e)
        {
            AddCategoryDashboard cat = new AddCategoryDashboard(this);
            cat.Show();
        }

        private string base64Image; // Declare it at the class level

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(openFile.FileName);
                    base64Image = ImageToBase64String(image);
                    MnptImg.Image = image;
                }
            }
        }

        private string ImageToBase64String(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }








        private void FoodIDManipulate_TextChanged(object sender, EventArgs e)
        {

        }

        private void FoodManipulate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionManipulate_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void PriceManipulate_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryManipulate_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void MnptImg_Click(object sender, EventArgs e)
        {

        }

  
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TableFoodMenu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
