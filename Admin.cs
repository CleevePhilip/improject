using System;
using System.Windows.Forms;
using improject.UserController;
using improject.UserControls;

namespace improject
{
    public partial class Admin : Form
    {
        public int userID;
        public Admin(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            AdminID.Text = "Admin ID:" + userID.ToString();
            HomeDashboard home = new HomeDashboard();
            addUserControll(home);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            AdminPanel.Controls.Clear();
            AdminPanel.Controls.Add(userControl);
            AdminPanel.BringToFront();

        }
    
        private void DashboardBtn_Click_1(object sender, EventArgs e)
        {
            HomeDashboard home = new HomeDashboard();
            addUserControll(home);
        }

        private void MenuBtn_Click_1(object sender, EventArgs e)
        {
            MenuDashboard menu = new MenuDashboard();
            addUserControll(menu);
        }

        private void InventoryBtn_Click_1(object sender, EventArgs e)
        {
            InventoryDashboard inventoryDashboard = new InventoryDashboard();
            addUserControll(inventoryDashboard);
        }

        private void SalesBtn_Click_1(object sender, EventArgs e)
        {
            SalesDashboard sales = new SalesDashboard();
            addUserControll(sales);
        }

        private void EmployeeBtn_Click_1(object sender, EventArgs e)
        {
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            addUserControll(employeeDashboard); 
        }
        private void Inventory_Products_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminID_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
