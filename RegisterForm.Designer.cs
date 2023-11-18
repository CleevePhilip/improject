namespace improject
{
    partial class RegisterForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.RedirectLogin = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfirmRegister = new System.Windows.Forms.TextBox();
            this.PasswordRegister = new System.Windows.Forms.TextBox();
            this.EmailRegister = new System.Windows.Forms.TextBox();
            this.ContactRegister = new System.Windows.Forms.TextBox();
            this.LastnameRegister = new System.Windows.Forms.TextBox();
            this.FirstnameRegister = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.RoleOpt = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.RoleOpt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RedirectLogin);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ConfirmRegister);
            this.panel1.Controls.Add(this.PasswordRegister);
            this.panel1.Controls.Add(this.EmailRegister);
            this.panel1.Controls.Add(this.ContactRegister);
            this.panel1.Controls.Add(this.LastnameRegister);
            this.panel1.Controls.Add(this.FirstnameRegister);
            this.panel1.Controls.Add(this.Confirm);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 713);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(116, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "REGISTER ACCOUNT";
            // 
            // RedirectLogin
            // 
            this.RedirectLogin.BackColor = System.Drawing.Color.OliveDrab;
            this.RedirectLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedirectLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedirectLogin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedirectLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RedirectLogin.Location = new System.Drawing.Point(123, 616);
            this.RedirectLogin.Name = "RedirectLogin";
            this.RedirectLogin.Size = new System.Drawing.Size(260, 44);
            this.RedirectLogin.TabIndex = 16;
            this.RedirectLogin.Text = "LOGIN ACCOUNT";
            this.RedirectLogin.UseVisualStyleBackColor = false;
            this.RedirectLogin.Click += new System.EventHandler(this.RedirectLogin_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisterBtn.Location = new System.Drawing.Point(123, 546);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(260, 44);
            this.RegisterBtn.TabIndex = 15;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "ROLE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ConfirmRegister
            // 
            this.ConfirmRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmRegister.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmRegister.Location = new System.Drawing.Point(270, 404);
            this.ConfirmRegister.Multiline = true;
            this.ConfirmRegister.Name = "ConfirmRegister";
            this.ConfirmRegister.Size = new System.Drawing.Size(216, 30);
            this.ConfirmRegister.TabIndex = 11;
            this.ConfirmRegister.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // PasswordRegister
            // 
            this.PasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordRegister.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegister.Location = new System.Drawing.Point(39, 404);
            this.PasswordRegister.Multiline = true;
            this.PasswordRegister.Name = "PasswordRegister";
            this.PasswordRegister.Size = new System.Drawing.Size(216, 30);
            this.PasswordRegister.TabIndex = 10;
            this.PasswordRegister.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // EmailRegister
            // 
            this.EmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailRegister.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailRegister.Location = new System.Drawing.Point(268, 328);
            this.EmailRegister.Multiline = true;
            this.EmailRegister.Name = "EmailRegister";
            this.EmailRegister.Size = new System.Drawing.Size(217, 29);
            this.EmailRegister.TabIndex = 9;
            this.EmailRegister.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ContactRegister
            // 
            this.ContactRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactRegister.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactRegister.Location = new System.Drawing.Point(37, 328);
            this.ContactRegister.Multiline = true;
            this.ContactRegister.Name = "ContactRegister";
            this.ContactRegister.Size = new System.Drawing.Size(217, 29);
            this.ContactRegister.TabIndex = 8;
            this.ContactRegister.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LastnameRegister
            // 
            this.LastnameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastnameRegister.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameRegister.Location = new System.Drawing.Point(268, 252);
            this.LastnameRegister.Multiline = true;
            this.LastnameRegister.Name = "LastnameRegister";
            this.LastnameRegister.Size = new System.Drawing.Size(216, 29);
            this.LastnameRegister.TabIndex = 7;
            this.LastnameRegister.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FirstnameRegister
            // 
            this.FirstnameRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstnameRegister.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameRegister.Location = new System.Drawing.Point(37, 252);
            this.FirstnameRegister.Multiline = true;
            this.FirstnameRegister.Name = "FirstnameRegister";
            this.FirstnameRegister.Size = new System.Drawing.Size(216, 29);
            this.FirstnameRegister.TabIndex = 6;
            this.FirstnameRegister.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(263, 378);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(186, 23);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "CONFIRM PASSWORD";
            this.Confirm.Click += new System.EventHandler(this.label6_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(35, 378);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(98, 23);
            this.Password.TabIndex = 4;
            this.Password.Text = "PASSWORD";
            this.Password.Click += new System.EventHandler(this.label5_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(263, 302);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(65, 23);
            this.Email.TabIndex = 3;
            this.Email.Text = "EMAIL";
            this.Email.Click += new System.EventHandler(this.label4_Click);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(33, 302);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(87, 23);
            this.Contact.TabIndex = 2;
            this.Contact.Text = "CONTACT";
            this.Contact.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "LASTNAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRSTNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::improject.Properties.Resources.undraw_Mobile_payments_re_7udl;
            this.pictureBox1.Location = new System.Drawing.Point(516, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Image = global::improject.Properties.Resources.button;
            this.ExitBtn.Location = new System.Drawing.Point(1060, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(57, 44);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RoleOpt
            // 
            this.RoleOpt.FormattingEnabled = true;
            this.RoleOpt.Location = new System.Drawing.Point(42, 482);
            this.RoleOpt.Name = "RoleOpt";
            this.RoleOpt.Size = new System.Drawing.Size(212, 28);
            this.RoleOpt.TabIndex = 18;
            this.RoleOpt.SelectedIndexChanged += new System.EventHandler(this.RoleOpt_SelectedIndexChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1129, 713);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConfirmRegister;
        private System.Windows.Forms.TextBox PasswordRegister;
        private System.Windows.Forms.TextBox EmailRegister;
        private System.Windows.Forms.TextBox ContactRegister;
        private System.Windows.Forms.TextBox LastnameRegister;
        private System.Windows.Forms.TextBox FirstnameRegister;
        private System.Windows.Forms.Label Confirm;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button RedirectLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ComboBox RoleOpt;
    }
}