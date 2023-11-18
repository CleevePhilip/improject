using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
namespace improject
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black)) // You can change the color here
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; // Set the dash style to dotted

                int startX = 10; // Starting X coordinate
                int endX = panel1.Width - 10; // Ending X coordinate
                int y = panel1.Height / 2; // Y coordinate (centered vertically)

                e.Graphics.DrawLine(pen, startX, y, endX, y);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black)) // You can change the color here
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; // Set the dash style to dotted

                int startX = 10; // Starting X coordinate
                int endX = panel1.Width - 10; // Ending X coordinate
                int y = panel1.Height / 2; // Y coordinate (centered vertically)

                e.Graphics.DrawLine(pen, startX, y, endX, y);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            using (Pen pen = new Pen(Color.Black)) // You can change the color here
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; // Set the dash style to dotted

                int startX = 10; // Starting X coordinate
                int endX = panel1.Width - 10; // Ending X coordinate
                int y = panel1.Height / 2; // Y coordinate (centered vertically)

                e.Graphics.DrawLine(pen, startX, y, endX, y);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black)) // You can change the color here
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; // Set the dash style to dotted

                int startX = 10; // Starting X coordinate
                int endX = panel1.Width - 10; // Ending X coordinate
                int y = panel1.Height / 2; // Y coordinate (centered vertically)

                e.Graphics.DrawLine(pen, startX, y, endX, y);
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter()
            { Format = BarcodeFormat.CODE_128 };
            Barcode.Image = writer.Write(Encode.Text);
        }
    }
}
