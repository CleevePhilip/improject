using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace improject
{
    public partial class AddCategoryDashboard : Form
    {
        private MenuDashboard menuDashboard;
        public AddCategoryDashboard(MenuDashboard menuDashboard)
        {
            InitializeComponent();
            loadCategory();
            this.menuDashboard = menuDashboard;
        }
        private void refreshTable()
        {
            loadCategory();
        }
        private void loadCategory()
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM categoryMenu";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DataGridCat.DataSource = dataTable;
                        }
                       
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error" + err.Message);
                } 
                finally
                { 
                    connection.Close();
                }
            }
        }
        private void ViewCatBtn_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            int catID = Convert.ToInt32(CatId.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT categoryID, categoryName FROM categoryMenu WHERE categoryID = @CatID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CatID", catID);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            CatNameView.Text = reader["categoryName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid category ID");
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error" + err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void UpdateCatBtn_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            int catID = Convert.ToInt32(CatId.Text);
            string catName = CatNameView.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateCategoryName", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@CatID", SqlDbType.Int).Value = catID;
                        command.Parameters.Add("@CatName", SqlDbType.NVarChar, 255).Value = catName;

                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Successfully Updated " + catName);
                            refreshTable();
                            this.menuDashboard.RefreshTable();
                            return;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void AddCatBtn_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            string category = CatNameAdd.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (string.IsNullOrEmpty(category))
                    {
                        MessageBox.Show("Don't leave the Add category Empty!, Please try again.");
                        return;
                    }
                    string query = "INSERT INTO categoryMenu (categoryName) VALUES(@Category) ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", category);
                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Succesfully added" + category + "to category");
                            refreshTable();
                            return;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error" + err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void DeleteCatBtn_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
            int catID = Convert.ToInt32(CatId.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM categoryMenu WHERE categoryID = @CatID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CatID", catID);
                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Successfully Deleted " + catID);
                            refreshTable();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete category id: " + catID);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void CatId_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatNameView_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CatNameAdd_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddCatDPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCategoryDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

