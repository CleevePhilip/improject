namespace improject
{
    partial class AddIngredients
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
            this.Ingredient = new System.Windows.Forms.TextBox();
            this.IngredientTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IngredientID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddIngredientBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ViewIngredients = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ingredient
            // 
            this.Ingredient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ingredient.Location = new System.Drawing.Point(265, 149);
            this.Ingredient.Multiline = true;
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.Size = new System.Drawing.Size(264, 32);
            this.Ingredient.TabIndex = 23;
            // 
            // IngredientTable
            // 
            this.IngredientTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IngredientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientTable.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IngredientTable.Location = new System.Drawing.Point(636, 198);
            this.IngredientTable.Name = "IngredientTable";
            this.IngredientTable.RowHeadersWidth = 51;
            this.IngredientTable.RowTemplate.Height = 24;
            this.IngredientTable.Size = new System.Drawing.Size(581, 512);
            this.IngredientTable.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 59);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "INGREDIENTS SETTING";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(53, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "INGREDIENT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(53, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "INGREDIENT ID: ";
            // 
            // IngredientID
            // 
            this.IngredientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IngredientID.Location = new System.Drawing.Point(265, 83);
            this.IngredientID.Multiline = true;
            this.IngredientID.Name = "IngredientID";
            this.IngredientID.Size = new System.Drawing.Size(264, 32);
            this.IngredientID.TabIndex = 32;
            this.IngredientID.TextChanged += new System.EventHandler(this.IngredientID_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Ingredient);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.IngredientID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(31, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 286);
            this.panel3.TabIndex = 37;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AddIngredientBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.ViewIngredients);
            this.panel2.Location = new System.Drawing.Point(28, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 109);
            this.panel2.TabIndex = 38;
            // 
            // AddIngredientBtn
            // 
            this.AddIngredientBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.AddIngredientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddIngredientBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredientBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddIngredientBtn.Image = global::improject.Properties.Resources.add__1_4;
            this.AddIngredientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddIngredientBtn.Location = new System.Drawing.Point(12, 31);
            this.AddIngredientBtn.Name = "AddIngredientBtn";
            this.AddIngredientBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddIngredientBtn.Size = new System.Drawing.Size(128, 54);
            this.AddIngredientBtn.TabIndex = 20;
            this.AddIngredientBtn.Text = "  ADD";
            this.AddIngredientBtn.UseVisualStyleBackColor = false;
            this.AddIngredientBtn.Click += new System.EventHandler(this.AddIngredientBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteBtn.Image = global::improject.Properties.Resources.delete3;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBtn.Location = new System.Drawing.Point(446, 31);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DeleteBtn.Size = new System.Drawing.Size(128, 54);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.Text = "  DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditBtn.Image = global::improject.Properties.Resources.system_update4;
            this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditBtn.Location = new System.Drawing.Point(300, 31);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EditBtn.Size = new System.Drawing.Size(128, 54);
            this.EditBtn.TabIndex = 21;
            this.EditBtn.Text = "  EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ViewIngredients
            // 
            this.ViewIngredients.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewIngredients.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewIngredients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewIngredients.Image = global::improject.Properties.Resources.file2;
            this.ViewIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewIngredients.Location = new System.Drawing.Point(155, 31);
            this.ViewIngredients.Name = "ViewIngredients";
            this.ViewIngredients.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ViewIngredients.Size = new System.Drawing.Size(128, 54);
            this.ViewIngredients.TabIndex = 34;
            this.ViewIngredients.Text = "  VIEW";
            this.ViewIngredients.UseVisualStyleBackColor = false;
            this.ViewIngredients.Click += new System.EventHandler(this.ViewIngredients_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(161, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = "INGREDIENTS LIST";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(635, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 59);
            this.panel4.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(31, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 59);
            this.panel5.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(161, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 39;
            this.label2.Text = "INGREDIENTS LIST";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(31, 521);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(583, 59);
            this.panel6.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(221, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 39;
            this.label4.Text = "ACTIONS";
            // 
            // AddIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 753);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.IngredientTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddIngredients";
            this.Text = "AddIngredients";
            this.Load += new System.EventHandler(this.AddIngredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngredientTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddIngredientBtn;
        private System.Windows.Forms.TextBox Ingredient;
        private System.Windows.Forms.DataGridView IngredientTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IngredientID;
        private System.Windows.Forms.Button ViewIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
    }
}