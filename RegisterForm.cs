using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace improject
{
    public partial class RegisterForm : Form
    {
        private string connectionString =  "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";
        public RegisterForm()
        {
            InitializeComponent();
            Role();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void RedirectLogin_Click(object sender, EventArgs e)
        {
           LoginForm loginForm = new LoginForm();
           loginForm.Show();
           this.Hide();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string firstname = FirstnameRegister.Text;
            string lastname = LastnameRegister.Text;
            string password = PasswordRegister.Text;
            string confirmPassword = ConfirmRegister.Text;
            string email = EmailRegister.Text;
            string role = RoleOpt.SelectedItem.ToString();
            int contact;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname) ||
                    string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) ||
                    string.IsNullOrWhiteSpace(role) || !int.TryParse(ContactRegister.Text, out contact))
                {
                    MessageBox.Show("Please fill in all fields correctly.");
                    return;
                }
                else if (password != confirmPassword)
                {
                    MessageBox.Show("The passwords don't match. Try again !");
                    return;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(12));
                using (SqlCommand command = new SqlCommand("dbo.RegisterUser", connect))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Firstname", firstname);
                    command.Parameters.AddWithValue("@Lastname", lastname);
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Contact", contact);

                    SqlParameter returnParam = new SqlParameter("@ReturnValue", SqlDbType.Int);
                    returnParam.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(returnParam);

                    command.ExecuteNonQuery();

                    int returnValue = (int)returnParam.Value;

                    if (returnValue == 0)
                    {
                        MessageBox.Show("User registered successfully.");
                    }
                    else if (returnValue == -1)
                    {
                        MessageBox.Show("User with the provided email already exists.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user. Please try again.");
                    }
                }
            }
        }

        private void Role()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT RoleName FROM Role";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RoleOpt.Items.Add(reader["RoleName"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    


        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoleOpt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

  
}
