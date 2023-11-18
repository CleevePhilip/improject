namespace improject
{
    partial class StockTransactions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddStock = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TransTypeOpt = new System.Windows.Forms.ComboBox();
            this.Qty = new System.Windows.Forms.TextBox();
            this.TransactID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngredientOpt = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StockTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label13);
            this.panel10.Location = new System.Drawing.Point(208, 629);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(534, 57);
            this.panel10.TabIndex = 44;
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(781, 112);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1116, 91);
            this.panel9.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(459, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 33);
            this.label12.TabIndex = 34;
            this.label12.Text = "STOCKS TABLE ";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.TransferBtn);
            this.panel8.Controls.Add(this.ViewBtn);
            this.panel8.Controls.Add(this.UpdateBtn);
            this.panel8.Controls.Add(this.AddStock);
            this.panel8.Location = new System.Drawing.Point(208, 703);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(534, 225);
            this.panel8.TabIndex = 42;
            // 
            // TransferBtn
            // 
            this.TransferBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.TransferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TransferBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TransferBtn.Image = global::improject.Properties.Resources.delete2;
            this.TransferBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransferBtn.Location = new System.Drawing.Point(299, 127);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TransferBtn.Size = new System.Drawing.Size(188, 66);
            this.TransferBtn.TabIndex = 35;
            this.TransferBtn.Text = "TRANSFER";
            this.TransferBtn.UseVisualStyleBackColor = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewBtn.Image = global::improject.Properties.Resources.file;
            this.ViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewBtn.Location = new System.Drawing.Point(299, 27);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ViewBtn.Size = new System.Drawing.Size(188, 66);
            this.ViewBtn.TabIndex = 34;
            this.ViewBtn.Text = "VIEW";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateBtn.Image = global::improject.Properties.Resources.system_update3;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(57, 127);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateBtn.Size = new System.Drawing.Size(188, 66);
            this.UpdateBtn.TabIndex = 33;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddStock
            // 
            this.AddStock.BackColor = System.Drawing.SystemColors.Desktop;
            this.AddStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddStock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddStock.Image = global::improject.Properties.Resources.add__1_;
            this.AddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStock.Location = new System.Drawing.Point(57, 27);
            this.AddStock.Name = "AddStock";
            this.AddStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddStock.Size = new System.Drawing.Size(188, 66);
            this.AddStock.TabIndex = 31;
            this.AddStock.Text = "ADD";
            this.AddStock.UseVisualStyleBackColor = false;
            this.AddStock.Click += new System.EventHandler(this.AddStock_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(208, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 91);
            this.panel7.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(101, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 33);
            this.label9.TabIndex = 30;
            this.label9.Text = "STOCK SETTINGS";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Unit);
            this.panel6.Controls.Add(this.Date);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.TransTypeOpt);
            this.panel6.Controls.Add(this.Qty);
            this.panel6.Controls.Add(this.TransactID);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.IngredientOpt);
            this.panel6.Controls.Add(this.Quantity);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(208, 228);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 377);
            this.panel6.TabIndex = 40;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // Unit
            // 
            this.Unit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.FormattingEnabled = true;
            this.Unit.Location = new System.Drawing.Point(305, 204);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(203, 31);
            this.Unit.TabIndex = 48;
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(107, 326);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(401, 31);
            this.Date.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "DATE: ";
            // 
            // TransTypeOpt
            // 
            this.TransTypeOpt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransTypeOpt.FormattingEnabled = true;
            this.TransTypeOpt.Location = new System.Drawing.Point(305, 266);
            this.TransTypeOpt.Name = "TransTypeOpt";
            this.TransTypeOpt.Size = new System.Drawing.Size(203, 31);
            this.TransTypeOpt.TabIndex = 38;
            this.TransTypeOpt.SelectedIndexChanged += new System.EventHandler(this.TransTypeOpt_SelectedIndexChanged);
            // 
            // Qty
            // 
            this.Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qty.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.Location = new System.Drawing.Point(305, 138);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(203, 31);
            this.Qty.TabIndex = 37;
            // 
            // TransactID
            // 
            this.TransactID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactID.Location = new System.Drawing.Point(305, 22);
            this.TransactID.Name = "TransactID";
            this.TransactID.Size = new System.Drawing.Size(203, 31);
            this.TransactID.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "TRANSACTION ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(21, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "TRANSACTION TYPE:";
            // 
            // IngredientOpt
            // 
            this.IngredientOpt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientOpt.FormattingEnabled = true;
            this.IngredientOpt.Location = new System.Drawing.Point(305, 79);
            this.IngredientOpt.Name = "IngredientOpt";
            this.IngredientOpt.Size = new System.Drawing.Size(203, 31);
            this.IngredientOpt.TabIndex = 22;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Quantity.Location = new System.Drawing.Point(21, 212);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(208, 23);
            this.Quantity.TabIndex = 26;
            this.Quantity.Text = "MEASUREMENT UNIT: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(21, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "QUANTITY:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(21, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "INGREDIENTS ID: ";
            // 
            // StockTable
            // 
            this.StockTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StockTable.Location = new System.Drawing.Point(781, 228);
            this.StockTable.Name = "StockTable";
            this.StockTable.RowHeadersWidth = 51;
            this.StockTable.RowTemplate.Height = 24;
            this.StockTable.Size = new System.Drawing.Size(1116, 700);
            this.StockTable.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 81);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "STOCKS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 966);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 34);
            this.panel2.TabIndex = 46;
            // 
            // StockTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.StockTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockTransactions";
            this.Text = "StockTransactions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockTransactions_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button AddStock;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox IngredientOpt;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView StockTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox TransactID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.ComboBox TransTypeOpt;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Unit;
    }
}