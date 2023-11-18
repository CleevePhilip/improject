namespace improject
{
    partial class LoginForm
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
            this.EmailLogin = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterBtnRedirect = new System.Windows.Forms.Button();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLogin
            // 
            this.EmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmailLogin.Location = new System.Drawing.Point(111, 268);
            this.EmailLogin.Multiline = true;
            this.EmailLogin.Name = "EmailLogin";
            this.EmailLogin.Size = new System.Drawing.Size(245, 31);
            this.EmailLogin.TabIndex = 0;
            this.EmailLogin.TextChanged += new System.EventHandler(this.EmailLogin_TextChanged);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.View.Controls.Add(this.ExitBtn);
            this.View.Controls.Add(this.checkBox1);
            this.View.Controls.Add(this.label3);
            this.View.Controls.Add(this.EmailLogin);
            this.View.Controls.Add(this.label1);
            this.View.Controls.Add(this.button1);
            this.View.Controls.Add(this.RegisterBtnRedirect);
            this.View.Controls.Add(this.PasswordLogin);
            this.View.Controls.Add(this.label2);
            this.View.Dock = System.Windows.Forms.DockStyle.Right;
            this.View.Location = new System.Drawing.Point(506, 0);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(418, 655);
            this.View.TabIndex = 4;
            this.View.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Image = global::improject.Properties.Resources.button;
            this.ExitBtn.Location = new System.Drawing.Point(358, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(57, 44);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(111, 399);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 27);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "VIEW PASSWORD";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(104, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOGIN ACCOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ENTER EMAIL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(111, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterBtnRedirect
            // 
            this.RegisterBtnRedirect.BackColor = System.Drawing.Color.OliveDrab;
            this.RegisterBtnRedirect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterBtnRedirect.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtnRedirect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterBtnRedirect.Location = new System.Drawing.Point(111, 506);
            this.RegisterBtnRedirect.Name = "RegisterBtnRedirect";
            this.RegisterBtnRedirect.Size = new System.Drawing.Size(245, 39);
            this.RegisterBtnRedirect.TabIndex = 8;
            this.RegisterBtnRedirect.Text = "REGISTER";
            this.RegisterBtnRedirect.UseVisualStyleBackColor = false;
            this.RegisterBtnRedirect.Click += new System.EventHandler(this.RegisterBtnRedirect_Click);
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasswordLogin.Location = new System.Drawing.Point(111, 348);
            this.PasswordLogin.Multiline = true;
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.PasswordChar = '*';
            this.PasswordLogin.Size = new System.Drawing.Size(245, 31);
            this.PasswordLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTER PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(105, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "SYSTEM AUTHENTICATION";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::improject.Properties.Resources.undraw_two_factor_authentication_namy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(924, 655);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.View);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.View.ResumeLayout(false);
            this.View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailLogin;
        private System.Windows.Forms.Panel View;
        private System.Windows.Forms.Button RegisterBtnRedirect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ExitBtn;
    }
}

