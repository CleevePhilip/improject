using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace improject
{
    public partial class AddIngredients : Form
    {
        private string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";


        public AddIngredients()
        {
            InitializeComponent();

            FetchDataIngredient();
        }

        private void FetchDataIngredient()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Ingredients";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        IngredientTable.DataSource = dataTable;
                    }
                }
            }
        }

        private void RefreshTable()
        {
            FetchDataIngredient();
        }

        private void AddIngredients_Load(object sender, EventArgs e)
        {
        
        }

        private void AddIngredientBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string ingredientName = Ingredient.Text;
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_InsertIngredientAndUpdateInventory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IngredientName", ingredientName);                  

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ingredient Added Successfully");
                            Ingredient.Text = "";
                            RefreshTable();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Ingredient Failed to Add, Try again!");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ViewIngredients_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int ingredientID = Convert.ToInt32(IngredientID.Text);
                string ingredientName = "";
                string query = "SELECT IngredientName FROM Ingredients WHERE IngredientID = @IngredientID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IngredientID", ingredientID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ingredientName = reader["IngredientName"].ToString();

                        }
                    }
                }
                Ingredient.Text = ingredientName;
          

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int ingredientID = Convert.ToInt32(IngredientID.Text);

                    using (SqlCommand command = new SqlCommand("sp_DeleteIngredients", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IngredientID", ingredientID);

                        SqlParameter resultMessageParam = new SqlParameter("@ResultMessage", SqlDbType.NVarChar, 100);
                        resultMessageParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultMessageParam);

                        SqlParameter successFlagParam = new SqlParameter("@SuccessFlag", SqlDbType.Bit);
                        successFlagParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(successFlagParam);

                        int rowsAffected = command.ExecuteNonQuery();
                        bool successFlag = (bool)successFlagParam.Value;
                        string resultMessage = resultMessageParam.Value.ToString();

                        if (successFlag)
                        {
                            Console.WriteLine("Rows affected: " + rowsAffected);
                            RefreshTable();  
                            MessageBox.Show(resultMessage);
                        }
                        else
                        {
                            MessageBox.Show(resultMessage);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private void EditBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int ingredientID = Convert.ToInt32(IngredientID.Text);
                    string newIngredientName = Ingredient.Text;
   

                    using (SqlCommand command = new SqlCommand("usp_UpdateIngredient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IngredientID", ingredientID);
                        command.Parameters.AddWithValue("@NewIngredientName", newIngredientName);              

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ingredient Updated Successfully");
                            RefreshTable();
                        }
                        else
                        {
                            MessageBox.Show("Ingredient Not Found or Update Failed");
                            RefreshTable();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IngredientID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}