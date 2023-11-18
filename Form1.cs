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
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;

namespace improject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

        }

        private void RegisterBtnRedirect_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailLogin.Text;
                string password = PasswordLogin.Text;

                string connectionString = "Data Source=XENOKING\\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True";

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand("GetUserByEmail", connect))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader read = command.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                string storedHashedPassword = read["PasswordHash"].ToString();
                                int UserID = Convert.ToInt32(read["UserID"].ToString());

                                if (int.TryParse(read["RoleID"].ToString(), out int role))
                                {
                                    if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                                    {
                                        if (role == 2)
                                        {
                                            MessageBox.Show("Logged in successfully, Welcome: " + email);
                                            PointOfSales pos = new PointOfSales(UserID);
                                            pos.Show();
                                            this.Hide();
                                        }
                                        else if (role == 1)
                                        {
                                            MessageBox.Show("Logged in successfully, Welcome: " + email);
                                            Admin admin = new Admin(UserID);
                                            admin.Show();
                                            this.Hide();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password, Try again!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error: RoleID is not a valid integer.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email not found, Please check your Email and try again!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void EmailLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, View.Width, View.Height);
            int borderRadius = 20;

            path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();
            View.Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(View.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordLogin.PasswordChar = '\0';
            }
            else
            {
                PasswordLogin.PasswordChar = '*';
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
