namespace improject.UserControls
{
    partial class EmployeeDashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SystemUsers = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RoleTable = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ViewCatBtn = new System.Windows.Forms.Button();
            this.DeleteCatBtn = new System.Windows.Forms.Button();
            this.UpdateCatBtn = new System.Windows.Forms.Button();
            this.AddCatBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailLogin = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemUsers)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1544, 72);
            this.panel4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "SYSTEM EMPLOYEES DATA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 981);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1544, 33);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SystemUsers);
            this.panel2.Location = new System.Drawing.Point(154, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 363);
            this.panel2.TabIndex = 16;
            // 
            // SystemUsers
            // 
            this.SystemUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SystemUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SystemUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemUsers.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SystemUsers.Location = new System.Drawing.Point(0, 0);
            this.SystemUsers.Name = "SystemUsers";
            this.SystemUsers.RowHeadersWidth = 51;
            this.SystemUsers.RowTemplate.Height = 24;
            this.SystemUsers.Size = new System.Drawing.Size(898, 361);
            this.SystemUsers.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RoleTable);
            this.panel3.Location = new System.Drawing.Point(1128, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 363);
            this.panel3.TabIndex = 17;
            // 
            // RoleTable
            // 
            this.RoleTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleTable.Location = new System.Drawing.Point(0, 0);
            this.RoleTable.Name = "RoleTable";
            this.RoleTable.RowHeadersWidth = 51;
            this.RoleTable.RowTemplate.Height = 24;
            this.RoleTable.Size = new System.Drawing.Size(392, 361);
            this.RoleTable.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(154, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 64);
            this.panel5.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(276, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 33);
            this.label9.TabIndex = 32;
            this.label9.Text = "SYSTEM USER ACCOUNTS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(1128, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(394, 64);
            this.panel6.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(248, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "ROLE ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.ViewCatBtn);
            this.panel7.Controls.Add(this.DeleteCatBtn);
            this.panel7.Controls.Add(this.UpdateCatBtn);
            this.panel7.Controls.Add(this.AddCatBtn);
            this.panel7.Location = new System.Drawing.Point(154, 699);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(662, 212);
            this.panel7.TabIndex = 20;
            // 
            // ViewCatBtn
            // 
            this.ViewCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.ViewCatBtn.Image = global::improject.Properties.Resources.file1;
            this.ViewCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewCatBtn.Location = new System.Drawing.Point(127, 20);
            this.ViewCatBtn.Name = "ViewCatBtn";
            this.ViewCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ViewCatBtn.Size = new System.Drawing.Size(177, 64);
            this.ViewCatBtn.TabIndex = 51;
            this.ViewCatBtn.Text = "VIEW";
            this.ViewCatBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteCatBtn
            // 
            this.DeleteCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.DeleteCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.DeleteCatBtn.Image = global::improject.Properties.Resources.delete1;
            this.DeleteCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteCatBtn.Location = new System.Drawing.Point(358, 116);
            this.DeleteCatBtn.Name = "DeleteCatBtn";
            this.DeleteCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DeleteCatBtn.Size = new System.Drawing.Size(177, 64);
            this.DeleteCatBtn.TabIndex = 50;
            this.DeleteCatBtn.Text = "DELETE";
            this.DeleteCatBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateCatBtn
            // 
            this.UpdateCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.UpdateCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.UpdateCatBtn.Image = global::improject.Properties.Resources.system_update2;
            this.UpdateCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateCatBtn.Location = new System.Drawing.Point(358, 20);
            this.UpdateCatBtn.Name = "UpdateCatBtn";
            this.UpdateCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateCatBtn.Size = new System.Drawing.Size(177, 64);
            this.UpdateCatBtn.TabIndex = 49;
            this.UpdateCatBtn.Text = "UPDATE";
            this.UpdateCatBtn.UseVisualStyleBackColor = false;
            // 
            // AddCatBtn
            // 
            this.AddCatBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.AddCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCatBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCatBtn.ForeColor = System.Drawing.Color.Snow;
            this.AddCatBtn.Image = global::improject.Properties.Resources.add__1_2;
            this.AddCatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCatBtn.Location = new System.Drawing.Point(127, 116);
            this.AddCatBtn.Name = "AddCatBtn";
            this.AddCatBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AddCatBtn.Size = new System.Drawing.Size(177, 64);
            this.AddCatBtn.TabIndex = 48;
            this.AddCatBtn.Text = "ADD";
            this.AddCatBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "ACTIONS";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.EmailLogin);
            this.panel8.Location = new System.Drawing.Point(861, 614);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(660, 106);
            this.panel8.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "ROLE ";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(366, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 34);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "ROLE ID";
            // 
            // EmailLogin
            // 
            this.EmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLogin.Location = new System.Drawing.Point(61, 46);
            this.EmailLogin.Multiline = true;
            this.EmailLogin.Name = "EmailLogin";
            this.EmailLogin.Size = new System.Drawing.Size(252, 34);
            this.EmailLogin.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(155, 614);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(660, 65);
            this.panel11.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 33);
            this.label6.TabIndex = 33;
            this.label6.Text = "ACTIONS";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.button4);
            this.panel13.Controls.Add(this.button3);
            this.panel13.Controls.Add(this.button2);
            this.panel13.Controls.Add(this.button1);
            this.panel13.Location = new System.Drawing.Point(861, 740);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(660, 171);
            this.panel13.TabIndex = 24;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Desktop;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Image = global::improject.Properties.Resources.delete1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(431, 87);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(148, 51);
            this.button4.TabIndex = 54;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = global::improject.Properties.Resources.system_update2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(431, 18);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(148, 51);
            this.button3.TabIndex = 53;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::improject.Properties.Resources.file1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(255, 87);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(148, 51);
            this.button2.TabIndex = 52;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = global::improject.Properties.Resources.add__1_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(255, 18);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 49;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "EmployeeDashboard";
            this.Size = new System.Drawing.Size(1544, 1014);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SystemUsers)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailLogin;
        private System.Windows.Forms.Button ViewCatBtn;
        private System.Windows.Forms.Button DeleteCatBtn;
        private System.Windows.Forms.Button UpdateCatBtn;
        private System.Windows.Forms.Button AddCatBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView SystemUsers;
        private System.Windows.Forms.DataGridView RoleTable;
    }
}
