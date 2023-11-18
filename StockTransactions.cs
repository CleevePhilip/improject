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
using improject.UserController;

namespace improject
{
    public partial class StockTransactions : Form
    {
        private string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
        private InventoryDashboard inventoryDashboard;
        public StockTransactions(InventoryDashboard inventoryDashboard)
        {
            InitializeComponent();
            FetchIngredientID();
            FetchStockTable();
            TransOpt();
            this.inventoryDashboard = inventoryDashboard;
            Unit.Items.Add("OUNCE (OZ)");
            Unit.Items.Add("POUND (LB)");
            Unit.Items.Add("GRAM (G)");
            Unit.Items.Add("MILLIGRAM (MG)");
            Unit.Items.Add("KILOGRAM (KG)");
            Unit.Items.Add("METRIC TON (TONNE)");
      
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Ensure that the TransactionIDText.Text is a valid integer
            if (int.TryParse(TransactID.Text, out int transactionID))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Check if the Transaction with the specified ID exists
                        string checkQuery = "SELECT COUNT(*) FROM StockTransactions WHERE TransactionID = @TransactionID";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@TransactionID", transactionID);
                            int transactionCount = (int)checkCommand.ExecuteScalar();

                            if (transactionCount == 0)
                            {
                                MessageBox.Show("Transaction with the specified TransactionID does not exist.");
                                return;
                            }
                        }

                        using (SqlCommand command = new SqlCommand("sp_UpdateTransactionAndUpdateInventory", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@TransactionID", transactionID);
                            if (IngredientOpt.SelectedItem != null && int.TryParse(IngredientOpt.SelectedItem.ToString(), out int ingredientID))
                            {
                                command.Parameters.AddWithValue("@IngredientID", ingredientID);
                            }
                            else
                            {
                                MessageBox.Show("Please select a valid ingredient.");
                                return;
                            }
                            if (decimal.TryParse(Qty.Text, out decimal quantity))
                            {
                                command.Parameters.AddWithValue("@Quantity", quantity);
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid quantity.");
                                return;
                            }

                            command.Parameters.AddWithValue("@MeasurementUnit", Unit.SelectedItem);
                            command.Parameters.AddWithValue("@TransactionType", TransTypeOpt.SelectedItem != null ? TransTypeOpt.SelectedItem.ToString() : string.Empty);
                            command.Parameters.AddWithValue("@TransactionDate", Date.Value);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Transaction updated, and inventory updated successfully");
                                RefreshTable();
                             
                                inventoryDashboard.RefreshTable();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update the transaction");
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: " + error.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid TransactionID.");
            }
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("TransferToRemovedTransactions", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data transferred successfully");
                            RefreshTable();  // Refresh your table or UI as needed
                        }
                        else
                        {
                            MessageBox.Show("No rows transferred. Check your conditions.");
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


        private void ViewBtn_Click(object sender, EventArgs e)
        {
            // Ensure that the TransactionIDText.Text is a valid integer
            if (int.TryParse(TransactID.Text, out int transactionID))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT IngredientID, Quantity, MeasurementUnit, TransactionType, TransactionDate " +
                                       "FROM StockTransactions " +
                                       "WHERE TransactionID = @TransactionID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TransactionID", transactionID);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Populate the text boxes with the retrieved data
                                    IngredientOpt.SelectedItem = reader["IngredientID"].ToString();
                                 
                                    Qty.Text = reader["Quantity"].ToString();
                                    Unit.SelectedItem = reader["MeasurementUnit"].ToString();
                                    TransTypeOpt.SelectedItem = reader["TransactionType"].ToString();
                                    if (DateTime.TryParse(reader["TransactionDate"].ToString(), out DateTime transactionDate))
                                    {
                                        Date.Value = transactionDate;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error parsing TransactionDate.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Transaction with the specified TransactionID not found.");
                                  
                                }
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: " + error.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid TransactionID.");
            }
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_AddStock", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (IngredientOpt.SelectedItem != null && int.TryParse(IngredientOpt.SelectedItem.ToString(), out int ingredientID))
                        {
                            command.Parameters.AddWithValue("@IngredientID", ingredientID);
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid ingredient.");
                            return;
                        }
                        if (decimal.TryParse(Qty.Text, out decimal quantity))
                        {
                            command.Parameters.AddWithValue("@Quantity", quantity);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid quantity.");
                            return;
                        }

                        command.Parameters.AddWithValue("@MeasurementUnit", Unit.SelectedItem);
                        command.Parameters.AddWithValue("@TransactionType", TransTypeOpt.SelectedItem != null ? TransTypeOpt.SelectedItem.ToString() : string.Empty);
                        command.Parameters.AddWithValue("@TransactionDate", Date.Value);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock Added Successfully");
                            RefreshTable();
                            inventoryDashboard.RefreshTable();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add stock");
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
            }
        }

        private void FetchIngredientID()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                   connection.Open();
                    string query = "SELECT IngredientID FROM Ingredients";
                    using(SqlCommand command = new SqlCommand(query, connection)) 
                    {
                        using(SqlDataReader reader = command.ExecuteReader()) 
                        {
                            while(reader.Read()) 
                            {
                                int ingredientID = reader.GetInt32(0);  
                                IngredientOpt.Items.Add(ingredientID);
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void RefreshTable()
        {
            FetchStockTable();
        }
        private void TransOpt()
        {
            TransTypeOpt.Items.Add("Removal");
            TransTypeOpt.Items.Add("Addition");


            TransTypeOpt.SelectedItem = "Addition";
        }
        private void FetchStockTable() 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM StockTransactions";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        StockTable.DataSource= dataTable;   
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TransTypeOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void StockTransactions_Load(object sender, EventArgs e)
        {

        }
    }
}
