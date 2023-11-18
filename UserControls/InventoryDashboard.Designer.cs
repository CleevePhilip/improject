namespace improject.UserController
{
    partial class InventoryDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuItemTable = new System.Windows.Forms.DataGridView();
            this.FoodIdOpt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IngredientIdOpt = new System.Windows.Forms.ComboBox();
            this.ReqMeasurement = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.StockRed = new System.Windows.Forms.Button();
            this.AddIngToFood = new System.Windows.Forms.Button();
            this.MenuIngredientRed = new System.Windows.Forms.Button();
            this.RedirectIngredients = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemTable)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 932);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1520, 26);
            this.panel2.TabIndex = 1;
            // 
            // MenuItemTable
            // 
            this.MenuItemTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuItemTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MenuItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuItemTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuItemTable.Location = new System.Drawing.Point(612, 219);
            this.MenuItemTable.Name = "MenuItemTable";
            this.MenuItemTable.RowHeadersWidth = 51;
            this.MenuItemTable.RowTemplate.Height = 24;
            this.MenuItemTable.Size = new System.Drawing.Size(877, 480);
            this.MenuItemTable.TabIndex = 2;
            this.MenuItemTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuItemTable_CellContentClick);
            // 
            // FoodIdOpt
            // 
            this.FoodIdOpt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodIdOpt.FormattingEnabled = true;
            this.FoodIdOpt.Location = new System.Drawing.Point(297, 72);
            this.FoodIdOpt.Name = "FoodIdOpt";
            this.FoodIdOpt.Size = new System.Drawing.Size(203, 31);
            this.FoodIdOpt.TabIndex = 22;
            this.FoodIdOpt.SelectedIndexChanged += new System.EventHandler(this.FoodIdOpt_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(13, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "INGREDIENT NAME:";
            // 
            // IngredientIdOpt
            // 
            this.IngredientIdOpt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientIdOpt.FormattingEnabled = true;
            this.IngredientIdOpt.Location = new System.Drawing.Point(297, 145);
            this.IngredientIdOpt.Name = "IngredientIdOpt";
            this.IngredientIdOpt.Size = new System.Drawing.Size(203, 31);
            this.IngredientIdOpt.TabIndex = 24;
            this.IngredientIdOpt.SelectedIndexChanged += new System.EventHandler(this.IngredientIdOpt_SelectedIndexChanged);
            // 
            // ReqMeasurement
            // 
            this.ReqMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReqMeasurement.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqMeasurement.Location = new System.Drawing.Point(297, 211);
            this.ReqMeasurement.Name = "ReqMeasurement";
            this.ReqMeasurement.Size = new System.Drawing.Size(203, 31);
            this.ReqMeasurement.TabIndex = 32;
            this.ReqMeasurement.TextChanged += new System.EventHandler(this.ReqMeasurement_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(101, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 33);
            this.label9.TabIndex = 30;
            this.label9.Text = "MENU ITEM INGREDIENTS";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Quantity.Location = new System.Drawing.Point(13, 219);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(241, 23);
            this.Quantity.TabIndex = 26;
            this.Quantity.Text = "MEASUREMENT REQUIRED:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(13, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "FOOD NAME:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ReqMeasurement);
            this.panel6.Controls.Add(this.FoodIdOpt);
            this.panel6.Controls.Add(this.Quantity);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.IngredientIdOpt);
            this.panel6.Location = new System.Drawing.Point(39, 219);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 276);
            this.panel6.TabIndex = 33;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(665, 759);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 115);
            this.panel5.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(11, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "0";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "ORDER COUNT";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(940, 759);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 115);
            this.panel3.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(3, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 36);
            this.label10.TabIndex = 2;
            this.label10.Text = "0";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "ORDERS AMOUNT";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(1214, 759);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 115);
            this.panel4.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "LAST ORDER DATE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(321, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 33);
            this.label12.TabIndex = 34;
            this.label12.Text = "INVENTORY STOCKS";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(39, 103);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 91);
            this.panel7.TabIndex = 35;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.StockRed);
            this.panel8.Controls.Add(this.AddIngToFood);
            this.panel8.Controls.Add(this.MenuIngredientRed);
            this.panel8.Controls.Add(this.RedirectIngredients);
            this.panel8.Location = new System.Drawing.Point(39, 591);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(534, 283);
            this.panel8.TabIndex = 36;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(612, 103);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(877, 91);
            this.panel9.TabIndex = 37;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label13);
            this.panel10.Location = new System.Drawing.Point(39, 513);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(534, 57);
            this.panel10.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(194, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 33);
            this.label13.TabIndex = 34;
            this.label13.Text = "ACTIONS";
            // 
            // StockRed
            // 
            this.StockRed.BackColor = System.Drawing.SystemColors.Desktop;
            this.StockRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StockRed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockRed.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StockRed.Image = global::improject.Properties.Resources.warehouse;
            this.StockRed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StockRed.Location = new System.Drawing.Point(231, 12);
            this.StockRed.Name = "StockRed";
            this.StockRed.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StockRed.Size = new System.Drawing.Size(269, 72);
            this.StockRed.TabIndex = 32;
            this.StockRed.Text = "    STOCK TRANSACTION";
            this.StockRed.UseVisualStyleBackColor = false;
            this.StockRed.Click += new System.EventHandler(this.StockRed_Click);
            // 
            // AddIngToFood
            // 
            this.AddIngToFood.BackColor = System.Drawing.SystemColors.Desktop;
            this.AddIngToFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddIngToFood.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngToFood.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddIngToFood.Image = global::improject.Properties.Resources.add__1_1;
            this.AddIngToFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddIngToFood.Location = new System.Drawing.Point(17, 12);
            this.AddIngToFood.Name = "AddIngToFood";
            this.AddIngToFood.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddIngToFood.Size = new System.Drawing.Size(154, 56);
            this.AddIngToFood.TabIndex = 31;
            this.AddIngToFood.Text = "ADD";
            this.AddIngToFood.UseVisualStyleBackColor = false;
            this.AddIngToFood.Click += new System.EventHandler(this.AddIngToFood_Click);
            // 
            // MenuIngredientRed
            // 
            this.MenuIngredientRed.BackColor = System.Drawing.SystemColors.Desktop;
            this.MenuIngredientRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuIngredientRed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuIngredientRed.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuIngredientRed.Image = global::improject.Properties.Resources.illustration;
            this.MenuIngredientRed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuIngredientRed.Location = new System.Drawing.Point(231, 101);
            this.MenuIngredientRed.Name = "MenuIngredientRed";
            this.MenuIngredientRed.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MenuIngredientRed.Size = new System.Drawing.Size(269, 72);
            this.MenuIngredientRed.TabIndex = 31;
            this.MenuIngredientRed.Text = "    MENU INGREDIENTS";
            this.MenuIngredientRed.UseVisualStyleBackColor = false;
            this.MenuIngredientRed.Click += new System.EventHandler(this.MenuIngredientRed_Click);
            // 
            // RedirectIngredients
            // 
            this.RedirectIngredients.BackColor = System.Drawing.SystemColors.Desktop;
            this.RedirectIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedirectIngredients.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedirectIngredients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RedirectIngredients.Image = global::improject.Properties.Resources.recipe__1_;
            this.RedirectIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RedirectIngredients.Location = new System.Drawing.Point(231, 192);
            this.RedirectIngredients.Name = "RedirectIngredients";
            this.RedirectIngredients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RedirectIngredients.Size = new System.Drawing.Size(269, 70);
            this.RedirectIngredients.TabIndex = 21;
            this.RedirectIngredients.Text = "INGREDIENTS";
            this.RedirectIngredients.UseVisualStyleBackColor = false;
            this.RedirectIngredients.Click += new System.EventHandler(this.RedirectIngredients_Click);
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.MenuItemTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryDashboard";
            this.Size = new System.Drawing.Size(1520, 958);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemTable)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView MenuItemTable;
        private System.Windows.Forms.Button RedirectIngredients;
        private System.Windows.Forms.ComboBox FoodIdOpt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox IngredientIdOpt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddIngToFood;
        private System.Windows.Forms.Button MenuIngredientRed;
        private System.Windows.Forms.TextBox ReqMeasurement;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button StockRed;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
    }
}
