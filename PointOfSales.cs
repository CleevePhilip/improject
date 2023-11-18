using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace improject
{
    public partial class PointOfSales : Form
    {
        public int userID;
        private Panel CardContainer;
        private DataTable cartDataTable;
        string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
        public PointOfSales(int UserID)
        {
            InitializeComponent();
            this.userID = UserID;
            InitializeCartDataTable();
            InitializeUIComponents();
            FetchCardMenu();
         

        }

        private void InitializeUIComponents()
        {
            this.CardContainer = new Panel();
            this.Controls.Add(this.CardContainer);
            CreateCategoryButtons();
            Firstname.Text = "NA";
            Lastname.Text = "NA";
            Email.Text = "NA";
            Phone.Text = "0";

        }
        private void CreateCategoryButtons()
        {
            // Create an "All Menu" button
            Button allMenuButton = CreateCategoryButton(0, "All Menu");
            CategorySortPanel.Controls.Add(allMenuButton);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT categoryID, categoryName FROM categoryMenu";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int categoryID = reader.GetInt32(0);
                            string categoryName = reader.GetString(1);

                            Button categoryButton = CreateCategoryButton(categoryID, categoryName);
                            CategorySortPanel.Controls.Add(categoryButton);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private Button CreateCategoryButton(int categoryID, string categoryName)
        {
            Button categoryButton = new Button
            {
                Text = categoryName,
                Tag = categoryID,
                Dock = DockStyle.Top,
                Font = new Font("Consolas", 12),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(150, 50), 
            };
            categoryButton.Click += CategoryButtonClick;
            return categoryButton;
        }

        private void CategoryButtonClick(object sender, EventArgs e)
        {
            Button categoryButton = sender as Button;

            if (categoryButton != null)
            {
                int categoryID = (int)categoryButton.Tag;
                FilterAndDisplayMenuItems(categoryID);
            }
        }

        private void FilterAndDisplayMenuItems(int categoryID)
        {
            FlowPanelMenu.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query;
                    if (categoryID == 0)
                    {
                        // Show all categories
                        query = "SELECT foodID, foodName, foodPrice, description, categoryName, Image FROM menu";
                    }
                    else
                    {
                        // Show items for the selected category
                        query = "SELECT foodID, foodName, foodPrice, description, categoryName, Image FROM menu WHERE categoryID = @categoryID";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (categoryID != 0)
                        {
                            command.Parameters.AddWithValue("@categoryID", categoryID);
                        }
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int foodID = reader.GetInt32(0);
                                string foodName = reader.GetString(1);
                                decimal foodPrice = reader.GetDecimal(2);
                                string description = reader.GetString(3);
                                string categoryName = reader.GetString(4);

                                string base64Image = reader.GetString(reader.GetOrdinal("Image"));
                                byte[] imageBytes = Convert.FromBase64String(base64Image);

                                Panel cardPanel = CreateCardPanel(foodID, foodName, foodPrice, imageBytes);
                                FlowPanelMenu.Controls.Add(cardPanel);
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }


        private void InitializeCartDataTable()
        {
            cartDataTable = new DataTable();
            cartDataTable.Columns.Add("ID", typeof(int));
            cartDataTable.Columns.Add("NAME", typeof(string));
            cartDataTable.Columns.Add("QTY", typeof(int));
            cartDataTable.Columns.Add("PRICE", typeof(decimal));
            cartDataTable.Columns.Add("COST", typeof(decimal));


            DataTableOrder.DataSource = cartDataTable;
            DataTableOrder.AutoGenerateColumns = true;
        }

        private void PointOfSales_Load(object sender, EventArgs e)
        {

        }

        private void  FetchCardMenu()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT foodID, foodName, foodPrice, description, categoryName, Image FROM menu";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int foodID = reader.GetInt32(0);
                                string foodName = reader.GetString(1);
                                decimal foodPrice = reader.GetDecimal(2);
                                string description = reader.GetString(3);
                                string categoryName = reader.GetString(4);

                                string base64Image = reader.GetString(reader.GetOrdinal("Image"));
                                byte[] imageBytes = Convert.FromBase64String(base64Image);

                                Panel cardPanel = CreateCardPanel(foodID, foodName, foodPrice, imageBytes);
                                FlowPanelMenu.Controls.Add(cardPanel);
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private Panel CreateCardPanel(int foodID, string foodName, decimal foodPrice, byte[] imageBytes)
        {
            Panel cardPanel = new Panel();
            cardPanel.Width = 320; // Increased width to provide more space
            cardPanel.Height = 350; // Increased height to provide more space
            cardPanel.BorderStyle = BorderStyle.FixedSingle;

            PictureBox pictureBox = CreatePictureBox(imageBytes);
            pictureBox.Location = new Point(10, 10); // Adjust the position of the PictureBox
            Label nameLabel = CreateLabel(foodName, 14, FontStyle.Bold, System.Drawing.ContentAlignment.TopLeft);
            nameLabel.Location = new Point(10, 220); // Adjust the position of the name label
            Label priceLabel = CreateLabel($"Price: PHP {foodPrice.ToString("0.00")}", 12, FontStyle.Italic, System.Drawing.ContentAlignment.TopLeft);
            priceLabel.Location = new Point(10, 250); // Adjust the position of the price label
            Button addButton = CreateAddToCartButton(foodID);
            addButton.Location = new Point(10, 290); // Adjust the position of the "Add to Cart" button
            Button decButton = CreateDecreaseCartButton(foodID);
            decButton.Location = new Point(120, 290); // Adjust the position of the "Decrease" button

            cardPanel.Controls.Add(pictureBox);
            cardPanel.Controls.Add(nameLabel);
            cardPanel.Controls.Add(priceLabel);
            cardPanel.Controls.Add(addButton);
            cardPanel.Controls.Add(decButton);

            return cardPanel;
        }

        private PictureBox CreatePictureBox(byte[] imageBytes)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 300;
            pictureBox.Height = 200;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                pictureBox.Image = Image.FromStream(ms);
            }

            return pictureBox;
        }

        private Label CreateLabel(string text, int fontSize, FontStyle fontStyle, System.Drawing.ContentAlignment alignment)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font("Consolas", fontSize, fontStyle);
            label.Dock = DockStyle.Bottom;
            label.AutoSize = false;
            label.Size = new Size(300, 20);
            label.TextAlign = alignment;

            return label;
        }

        private Button CreateAddToCartButton(int foodID)
        {
            Button addButton = new Button();
            addButton.Text = "ADD TO CART";
            addButton.Font = new Font("Consolas", 12);
            addButton.Tag = foodID;
            addButton.Dock = DockStyle.Bottom;
            addButton.Click += AddToCartButtonClick;
            addButton.Size = new Size(100, 40);
            addButton.BackColor = SystemColors.Highlight;
            addButton.ForeColor = SystemColors.HighlightText;
            return addButton;
        }
        private Button CreateDecreaseCartButton(int foodID)
        {
            Button decButton = new Button();
            decButton.Text = "DECREASE ORDER";
            decButton.Font = new Font("Consolas", 12);
            decButton.Tag = foodID;
            decButton.Dock = DockStyle.Bottom;
            decButton.Click += DecreaseToCartButtonClick;
            decButton.Size = new Size(100, 40);
            decButton.BackColor = Color.Brown;
            decButton.ForeColor = SystemColors.HighlightText;
            return decButton;
        }

        private void DecreaseToCartButtonClick(object sender, EventArgs e)
        {
            Button decButton = sender as Button;
            if (decButton != null)
            {
                int foodID = (int)decButton.Tag;
                DecreaseItemToCart(foodID);

            }
        }




        private bool HasSufficientStock(int foodID, int totalQuantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("CheckIngredientStockForFood", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FoodID", foodID);
                        command.Parameters.AddWithValue("@OrderedQuantity", totalQuantity); // Use the parameter passed to this method

                        int result = (int)command.ExecuteScalar();

                        return result == 1;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void AddToCartButtonClick(object sender, EventArgs e)
        {
            Button addButton = sender as Button;

            if (addButton != null)
            {
                int foodID = (int)addButton.Tag;

                int existsInMenuIngredients = CheckFoodExistsInMenuItemIngredients(foodID);

                if (existsInMenuIngredients == 1)
                {
                    int totalQuantity = AddItemToCart(foodID);

                    bool hasStock = HasSufficientStock(foodID, totalQuantity);

                    if (hasStock)
                    {
                  
                        UpdateTotalCostLabel();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Stock for this amount of orders");
                        return;
                    }
                }
                else if (existsInMenuIngredients == 0)
                {
                    MessageBox.Show("This food item does not exist in the menu.");
                    return;
                }
                else
                {
                    MessageBox.Show("Error checking menu ingredients.");
                }
            }
        }



        private int CheckFoodExistsInMenuItemIngredients(int foodId)
        {
            int result = -1; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("CheckFoodExistsInMenuItemIngredients", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FoodID", foodId);

                        // Execute the stored procedure
                        result = (int)command.ExecuteScalar();
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

          
            return result; 
        }
        public int AddItemToCart(int foodID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if there is sufficient stock before adding to the cart
                    int totalQuantity = cartDataTable.AsEnumerable().Sum(row => row.Field<int>("QTY")) + 1;
                    bool hasStock = HasSufficientStock(foodID, totalQuantity);

                    if (!hasStock)
                    {
                        MessageBox.Show("Insufficient Stock for this amount of orders");
                        return -1; // Indicate failure to add to the cart
                    }

                    // Proceed with adding to the cart
                    DataRow existingRow = cartDataTable.AsEnumerable()
                        .SingleOrDefault(row => row.Field<int>("ID") == foodID);

                    if (existingRow != null)
                    {
                        // If the item exists, update the quantity and cost
                        existingRow.SetField("QTY", existingRow.Field<int>("QTY") + 1);
                        existingRow.SetField("COST", existingRow.Field<decimal>("PRICE") * existingRow.Field<int>("QTY"));
                    }
                    else
                    {
                        // Add the item to the cart
                        string query = "SELECT foodName, foodPrice FROM menu WHERE foodID = @foodID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@foodID", foodID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string foodName = reader.GetString(0);
                                    decimal foodPrice = reader.GetDecimal(1);

                                    cartDataTable.Rows.Add(foodID, foodName, 1, foodPrice, foodPrice);
                                }
                            }
                        }
                    }

                    UpdateTotalCostLabel();
                    int quantity = cartDataTable.AsEnumerable().Sum(row => row.Field<int>("QTY"));
                    return quantity;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return -1; // Indicate failure to add to the cart
                }
                finally
                {
                    connection.Close();
                }
            }
        }




        private void DecreaseItemToCart(int foodID)
        {
            DataRow existingRow = cartDataTable.AsEnumerable()
                .SingleOrDefault(row => row.Field<int>("ID") == foodID);

            if (existingRow != null)
            {
                int currentQuantity = existingRow.Field<int>("QTY");

                if (currentQuantity > 1)
                {
                    existingRow.SetField("QTY", currentQuantity - 1);
                    existingRow.SetField("COST", existingRow.Field<decimal>("PRICE") * (currentQuantity - 1));
                }
                else
                {

                    cartDataTable.Rows.Remove(existingRow);
                }

                UpdateTotalCostLabel();
            }
        }

       
        private void UpdateTotalCostLabel()
        {
            decimal totalCost = CalculateTotalCost();
            TotalCost.Text = $"Total Cost: PHP{totalCost.ToString("0.00")}";
        }

        private decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (DataRow row in cartDataTable.Rows)
            {
                decimal foodCost = row.Field<decimal>("COST");
                totalCost += foodCost;
            }
            return totalCost;
        }
        private void FinishPayOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(CashInput.Text, out int cash))
                {
                    decimal totalCost = CalculateTotalCost();

                    if (cash >= totalCost)
                    {
                        decimal change = cash - totalCost;
                        string firstName = Firstname.Text;
                        string lastName = Lastname.Text;
                        string email = Email.Text;
                        int phone = Convert.ToInt32(Phone.Text);

                        int customerId = InsertCustomer(firstName, lastName, email, phone);
                        if (customerId > 0)
                        {
                            int orderId = CreateOrder(customerId, totalCost);
                            if (orderId > 0)
                            {
                                InsertOrderDetails(orderId);

                                ChangeTxt.Text = $"Change: {change}";

                                MessageBox.Show("Order completed successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to create an order.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to create a customer record.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient cash. Please provide enough cash to cover the total cost.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid cash input. Please enter a valid numeric value.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private int InsertCustomer(string firstName, string lastName, string email, int phone)
        {
        

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_InsertCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Firstname", firstName);
                    command.Parameters.AddWithValue("@Lastname", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private int CreateOrder(int customerID, decimal totalCost)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_InsertOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@TotalAmount", totalCost);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void InsertOrderDetails(int orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataRow row in cartDataTable.Rows)
                    {
                        int foodID = row.Field<int>("ID");
                        int quantity = row.Field<int>("QTY");
                        decimal foodPrice = row.Field<decimal>("PRICE");

                        decimal subtotal = quantity * foodPrice; 

                        using (SqlCommand command = new SqlCommand("sp_InsertOrderDetail", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@OrderID", orderId);
                            command.Parameters.AddWithValue("@FoodID", foodID);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@Subtotal", subtotal);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                Console.WriteLine($"Inserted order detail for foodID: {foodID}");
                            }
                            else
                            {
                                Console.WriteLine($"Failed to insert order detail for foodID: {foodID}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting order details: {ex.Message}");
            }

        }


        private void card_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImgCard_Click(object sender, EventArgs e)
        {

        }

        private void CostCard_Click(object sender, EventArgs e)
        {

        }

        private void LabelCard_Click(object sender, EventArgs e)
        {

        }

        private void DataTableOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void FlowPanelMenu_Paint(object sender, PaintEventArgs e)
        {


        }

        private void TotalCost_Click(object sender, EventArgs e)
        {


        }

        private void TotalCostAmount_Click(object sender, EventArgs e)
        {

        }

        private void CashInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeTxt_Click(object sender, EventArgs e)
        {

        }

        private void CategorySortPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PrintReceipt_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.Show();
        }

        private void AdminMode_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterForm registerForm = new RegisterForm();
                registerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void OrderDetail_Click(object sender, EventArgs e)
        {
            OrderDetails order = new OrderDetails();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderHistory history = new OrderHistory();
            history.Show();
        }

        private void CategorySortPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DataTableOrder_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}