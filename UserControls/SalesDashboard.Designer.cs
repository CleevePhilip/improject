namespace improject
{
    partial class SalesDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BestSellingProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportExcelBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BestSellingProduct)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1617, 59);
            this.panel3.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(78, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 33);
            this.label9.TabIndex = 32;
            this.label9.Text = "SALES REPORT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ChartSales);
            this.panel2.Location = new System.Drawing.Point(76, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 349);
            this.panel2.TabIndex = 15;
            // 
            // ChartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartSales.ChartAreas.Add(chartArea1);
            this.ChartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartSales.Legends.Add(legend1);
            this.ChartSales.Location = new System.Drawing.Point(0, 0);
            this.ChartSales.Name = "ChartSales";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartSales.Series.Add(series1);
            this.ChartSales.Size = new System.Drawing.Size(739, 347);
            this.ChartSales.TabIndex = 0;
            this.ChartSales.Text = "chart1";
            this.ChartSales.Click += new System.EventHandler(this.ChartSales_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(75, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(741, 79);
            this.panel4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "MONTHLY SALES CHART";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.ExportExcelBtn);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(853, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(711, 79);
            this.panel5.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "SALES BREAKDOWN";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.OrderTable);
            this.panel6.Location = new System.Drawing.Point(854, 184);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(711, 743);
            this.panel6.TabIndex = 17;
            // 
            // OrderTable
            // 
            this.OrderTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderTable.Location = new System.Drawing.Point(0, 0);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.RowHeadersWidth = 51;
            this.OrderTable.RowTemplate.Height = 24;
            this.OrderTable.Size = new System.Drawing.Size(709, 741);
            this.OrderTable.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.BestSellingProduct);
            this.panel7.Location = new System.Drawing.Point(76, 613);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(740, 314);
            this.panel7.TabIndex = 19;
            // 
            // BestSellingProduct
            // 
            chartArea2.Name = "ChartArea1";
            this.BestSellingProduct.ChartAreas.Add(chartArea2);
            this.BestSellingProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.BestSellingProduct.Legends.Add(legend2);
            this.BestSellingProduct.Location = new System.Drawing.Point(0, 0);
            this.BestSellingProduct.Name = "BestSellingProduct";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.BestSellingProduct.Series.Add(series2);
            this.BestSellingProduct.Size = new System.Drawing.Size(738, 312);
            this.BestSellingProduct.TabIndex = 1;
            this.BestSellingProduct.Text = "chart2";
            this.BestSellingProduct.Click += new System.EventHandler(this.BestSellingProduct_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(74, 541);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(741, 66);
            this.panel8.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 33);
            this.label3.TabIndex = 36;
            this.label3.Text = "TOP SELLING PRODUCTS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 949);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 19);
            this.panel1.TabIndex = 23;
            // 
            // ExportExcelBtn
            // 
            this.ExportExcelBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.ExportExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportExcelBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportExcelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExportExcelBtn.Image = global::improject.Properties.Resources.excel;
            this.ExportExcelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportExcelBtn.Location = new System.Drawing.Point(434, 11);
            this.ExportExcelBtn.Name = "ExportExcelBtn";
            this.ExportExcelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExportExcelBtn.Size = new System.Drawing.Size(259, 53);
            this.ExportExcelBtn.TabIndex = 35;
            this.ExportExcelBtn.Text = "   DOWNLOAD EXCEL";
            this.ExportExcelBtn.UseVisualStyleBackColor = false;
            this.ExportExcelBtn.Click += new System.EventHandler(this.ExportExcelBtn_Click);
            // 
            // SalesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "SalesDashboard";
            this.Size = new System.Drawing.Size(1617, 968);
            this.Load += new System.EventHandler(this.SalesDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BestSellingProduct)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart BestSellingProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExportExcelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSales;
    }
}
