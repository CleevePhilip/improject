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

namespace improject.UserControls
{
    public partial class EmployeeDashboard : UserControl
    {
        private string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
        public EmployeeDashboard()
        {
            InitializeComponent();
            FetchUser();
            FetchRole();
        }
        public void Refresh()
        {
            FetchUser();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void FetchUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        connection.Open();
                        dataTable.Load(command.ExecuteReader());
                        SystemUsers.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public void FetchRole()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Role";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        connection.Open();
                        dataTable.Load(command.ExecuteReader());
                        RoleTable.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

  
        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
