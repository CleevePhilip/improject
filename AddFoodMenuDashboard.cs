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

namespace improject
{   
    public partial class AddFoodMenuDashboard : Form
    {
        private MenuDashboard menuDashboard;
        private string base64Image;
        public AddFoodMenuDashboard(MenuDashboard dashboard)
        {
            InitializeComponent();
            LoadCategory();
            this.menuDashboard = dashboard;
        }
        private void AddFoodMenuBtn_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            string foodName = AddFoodName.Text;
            string foodPriceText = AddFoodPrice.Text;
            string category = AddFoodCat.Text;
            string desc = AddFoodDesc.Text;
            if (string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(foodPriceText) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Please fill in all the fields before adding the food menu.");
                return;
            }

            if (!float.TryParse(foodPriceText, out float foodPrice))
            {
                MessageBox.Show("Invalid food price. Please enter a valid numeric value.");
                return;
            }
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM menu WHERE foodName = @Foodname";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Foodname", foodName);
                        int existingMenuCount = (int)checkCommand.ExecuteScalar();
                        if (existingMenuCount > 0)
                        {
                            MessageBox.Show("Menu already exists. Please choose a different name.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO menu (foodName, foodPrice, Image, description, categoryName) " +
                                        "VALUES (@Foodname, @Foodprice, @Image, @Desc, @CategoryName)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Foodname", foodName);
                        command.Parameters.AddWithValue("@Foodprice", foodPrice);
                        command.Parameters.AddWithValue("@CategoryName", category);
                        command.Parameters.AddWithValue("@Desc", desc);
                        command.Parameters.AddWithValue("@Image", base64Image);

                        int rowAffected = command.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Food Menu successfully added " + foodName);
                            this.menuDashboard.RefreshTable();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Food Menu failed to add. Please try again!");
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error " + error.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string ImageToBase64String(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void UploadImgBtn_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFile.FileName);
                    base64Image = ImageToBase64String(image);
                    FoodImgBox.Image = image;
                }
            }
        }

        private void FoodImgBox_Click(object sender, EventArgs e)
        {

        }
        private void AddFoodCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCat = AddFoodCat.SelectedItem.ToString();
            MessageBox.Show("Category: " + selectedCat);
        }
            private void LoadCategory()
            {
                string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT categoryName FROM categoryMenu";
                        using (SqlCommand command = new SqlCommand(query,connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                string selectedCat = reader["categoryName"].ToString();
                                AddFoodCat.Items.Add(selectedCat);
                            }
                        }
                    }
                catch(Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void CancelBtnAdd_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddFoodPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void AddFoodMenuDashboard_Load(object sender, EventArgs e)
        {

        }

   
   
    }
}
