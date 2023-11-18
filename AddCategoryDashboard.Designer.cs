namespace improject
{
    partial class AddCategoryDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CatNameAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CatId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CatNameView = new System.Windows.Forms.TextBox();
            this.DataGridCat = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewCatBtn = new System.Windows.Forms.Button();
            this.DeleteCatBtn = new System.Windows.Forms.Button();
            this.UpdateCatBtn = new System.Windows.Forms.Button();
            this.AddCatBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCat)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CatNameAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CatId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CatNameView);
            this.panel1.Location = new System.Drawing.Point(122, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 369);
            this.panel1.TabIndex = 0;
            // 
            // CatNameAdd
            // 
            this.CatNameAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatNameAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameAdd.Location = new System.Drawing.Point(249, 247);
            this.CatNameAdd.Name = "CatNameAdd";
            this.CatNameAdd.Size = new System.Drawing.Size(270, 31);
            this.CatNameAdd.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(31, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "ADD CATEGORY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(199, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 27);
            this.label6.TabIndex = 50;
            this.label6.Text = "CATEGORY SETTINGS";
            // 
            // CatId
            // 
            this.CatId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatId.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatId.Location = new System.Drawing.Point(249, 142);
            this.CatId.Name = "CatId";
            this.CatId.Size = new System.Drawing.Size(270, 31);
            this.CatId.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(31, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "CATEGORY NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(31, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "CATEGORY ID: ";
            // 
            // CatNameView
            // 
            this.CatNameView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatNameView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameView.Location = new System.Drawing.Point(249, 191);
            this.CatNameView.Name = "CatNameView";
            this.CatNameView.Size = new System.Drawing.Size(270, 31);
            this.CatNameView.TabIndex = 48;
            // 
            // DataGridCat
            // 
            this.DataGridCat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCat.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridCat.Location = new System.Drawing.Point(748, 130);
            this.DataGridCat.Name = "DataGridCat";
            this.DataGridCat.RowHeadersWidth = 51;
            this.DataGridCat.RowTemplate.Height = 24;
            this.DataGridCat.Size = new System.Drawing.Size(474, 626);
            this.DataGridCat.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ViewCatBtn);
            this.panel2.Controls.Add(this.DeleteCatBtn);
            this.panel2.Controls.Add(this.UpdateCatBtn);
            this.panel2.Controls.Add(this.AddCatBtn);
            this.panel2.Location = new System.Drawing.Point(122, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 297);
            this.panel2.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(199, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 51;
            this.label1.Text = "CATEGORY ACTIONS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(748, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 53);
            this.panel3.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(143, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "CATEGORY TABLE";
            // 
            // ViewCatBtn
            // 
            this.ViewCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.ViewCatBtn.Image = global::improject.Properties.Resources.file1;
            this.ViewCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewCatBtn.Location = new System.Drawing.Point(99, 108);
            this.ViewCatBtn.Name = "ViewCatBtn";
            this.ViewCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ViewCatBtn.Size = new System.Drawing.Size(177, 64);
            this.ViewCatBtn.TabIndex = 47;
            this.ViewCatBtn.Text = "VIEW";
            this.ViewCatBtn.UseVisualStyleBackColor = false;
            this.ViewCatBtn.Click += new System.EventHandler(this.ViewCatBtn_Click_1);
            // 
            // DeleteCatBtn
            // 
            this.DeleteCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.DeleteCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.DeleteCatBtn.Image = global::improject.Properties.Resources.delete1;
            this.DeleteCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteCatBtn.Location = new System.Drawing.Point(330, 187);
            this.DeleteCatBtn.Name = "DeleteCatBtn";
            this.DeleteCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DeleteCatBtn.Size = new System.Drawing.Size(177, 64);
            this.DeleteCatBtn.TabIndex = 46;
            this.DeleteCatBtn.Text = "DELETE";
            this.DeleteCatBtn.UseVisualStyleBackColor = false;
            this.DeleteCatBtn.Click += new System.EventHandler(this.DeleteCatBtn_Click_1);
            // 
            // UpdateCatBtn
            // 
            this.UpdateCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.UpdateCatBtn.Image = global::improject.Properties.Resources.system_update2;
            this.UpdateCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateCatBtn.Location = new System.Drawing.Point(330, 108);
            this.UpdateCatBtn.Name = "UpdateCatBtn";
            this.UpdateCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateCatBtn.Size = new System.Drawing.Size(177, 64);
            this.UpdateCatBtn.TabIndex = 45;
            this.UpdateCatBtn.Text = "UPDATE";
            this.UpdateCatBtn.UseVisualStyleBackColor = false;
            this.UpdateCatBtn.Click += new System.EventHandler(this.UpdateCatBtn_Click_1);
            // 
            // AddCatBtn
            // 
            this.AddCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.AddCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.AddCatBtn.Image = global::improject.Properties.Resources.add__1_2;
            this.AddCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCatBtn.Location = new System.Drawing.Point(99, 187);
            this.AddCatBtn.Name = "AddCatBtn";
            this.AddCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddCatBtn.Size = new System.Drawing.Size(177, 64);
            this.AddCatBtn.TabIndex = 44;
            this.AddCatBtn.Text = "ADD";
            this.AddCatBtn.UseVisualStyleBackColor = false;
            this.AddCatBtn.Click += new System.EventHandler(this.AddCatBtn_Click_1);
            // 
            // AddCategoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridCat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCategoryDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategoryDashboard";
            this.Load += new System.EventHandler(this.AddCategoryDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewCatBtn;
        private System.Windows.Forms.Button DeleteCatBtn;
        private System.Windows.Forms.TextBox CatNameAdd;
        private System.Windows.Forms.Button AddCatBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateCatBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CatId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CatNameView;
        private System.Windows.Forms.DataGridView DataGridCat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}