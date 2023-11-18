using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace improject
{
    public partial class SalesDashboard : UserControl
    {
       
        public SalesDashboard()
        {
            InitializeComponent();
            FetchOrderTable();
            PopulateSalesChart();
            PopulateBestSellingProductChart();
        }
        private void FetchOrderTable()
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.OpenConnection();
                using (SqlCommand command = new SqlCommand("SELECT * FROM OrderDetails", connection))
                {
                    DataTable table = new DataTable();
                    table.Load(command.ExecuteReader());
                    OrderTable.DataSource = table;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            finally
            {
                if (connection != null)
                {
                    Connection.CloseConnection(connection);
                }
            }
        }
        private void PopulateSalesChart()
        {
            ChartSales.Series.Clear();
            SqlConnection connection = null;
            Series salesSeries = new Series("Sales");
            salesSeries.ChartType = SeriesChartType.StackedColumn;

            connection = Connection.OpenConnection();

            string query = "SELECT MONTH(OrderDate) AS Month, SUM(TotalAmount) AS TotalSales " +
                               "FROM Orders " +
                               "GROUP BY MONTH(OrderDate) " +
                               "ORDER BY Month";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int month = reader.GetInt32(0); 
                        decimal totalSales = reader.GetDecimal(1); 

                        string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

                        DataPoint dataPoint = new DataPoint(month, (double)totalSales);
                        dataPoint.AxisLabel = monthName;
                        salesSeries.Points.Add(dataPoint);
                    }
                }
            

            ChartSales.Series.Add(salesSeries);
        }

        private void PopulateBestSellingProductChart()
        {
            SqlConnection connection = null;
            connection = Connection.OpenConnection();


            if (BestSellingProduct.Series.FindByName("BestSellingProduct") == null)
            {
                BestSellingProduct.Series.Add("BestSellingProduct");
                BestSellingProduct.Series["BestSellingProduct"].ChartType = SeriesChartType.Pie;
            }

            string query = "SELECT M.foodName, SUM(OD.Quantity) AS TotalQuantitySold " +
                           "FROM Menu AS M " +
                           "JOIN OrderDetails AS OD ON M.foodID = OD.FoodID " +
                           "GROUP BY M.foodName";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                BestSellingProduct.Series["BestSellingProduct"].Points.Clear();


                foreach (DataRow row in dataTable.Rows)
                {
                    string foodName = row["foodName"].ToString();
                    int totalQuantitySold = Convert.ToInt32(row["TotalQuantitySold"]);

                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(totalQuantitySold);
                    dataPoint.AxisLabel = foodName;
                    BestSellingProduct.Series["BestSellingProduct"].Points.Add(dataPoint);
                }
            }
        }
        private void ExportExcelBtn_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }
        private void ExportToCSV()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        for (int i = 0; i < OrderTable.Columns.Count; i++)
                        {
                            writer.Write(OrderTable.Columns[i].HeaderText);
                            if (i < OrderTable.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();

                        foreach (DataGridViewRow row in OrderTable.Rows)
                        {
                            for (int i = 0; i < OrderTable.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < OrderTable.Columns.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Data exported to CSV successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ChartSales_Click(object sender, EventArgs e)
        {

        }
        private void SalesDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BestSellingProduct_Click(object sender, EventArgs e)
        {

        }

        
    }
}
