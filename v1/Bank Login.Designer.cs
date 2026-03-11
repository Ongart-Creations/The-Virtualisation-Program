namespace TVP.v1
{
    partial class Bank_Login
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
            this.bank = new System.Windows.Forms.Label();
            this.anmeldung = new System.Windows.Forms.GroupBox();
            this.DeveloperAccess = new System.Windows.Forms.LinkLabel();
            this.createAccount = new System.Windows.Forms.LinkLabel();
            this.login = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.selectBank = new System.Windows.Forms.ComboBox();
            this.anmeldung.SuspendLayout();
            this.SuspendLayout();
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bank.Location = new System.Drawing.Point(95, 41);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(62, 24);
            this.bank.TabIndex = 0;
            this.bank.Text = "Bank:";
            // 
            // anmeldung
            // 
            this.anmeldung.Controls.Add(this.DeveloperAccess);
            this.anmeldung.Controls.Add(this.createAccount);
            this.anmeldung.Controls.Add(this.login);
            this.anmeldung.Controls.Add(this.pass);
            this.anmeldung.Controls.Add(this.password);
            this.anmeldung.Controls.Add(this.user);
            this.anmeldung.Controls.Add(this.username);
            this.anmeldung.Controls.Add(this.selectBank);
            this.anmeldung.Controls.Add(this.bank);
            this.anmeldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anmeldung.Location = new System.Drawing.Point(12, 12);
            this.anmeldung.Name = "anmeldung";
            this.anmeldung.Size = new System.Drawing.Size(456, 206);
            this.anmeldung.TabIndex = 2;
            this.anmeldung.TabStop = false;
            this.anmeldung.Text = "Anmeldung";
            // 
            // DeveloperAccess
            // 
            this.DeveloperAccess.AutoSize = true;
            this.DeveloperAccess.Location = new System.Drawing.Point(38, 172);
            this.DeveloperAccess.Name = "DeveloperAccess";
            this.DeveloperAccess.Size = new System.Drawing.Size(96, 24);
            this.DeveloperAccess.TabIndex = 8;
            this.DeveloperAccess.TabStop = true;
            this.DeveloperAccess.Text = "Entwickler";
            this.DeveloperAccess.Visible = false;
            this.DeveloperAccess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeveloperAccess_LinkClicked);
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.Location = new System.Drawing.Point(140, 172);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(160, 24);
            this.createAccount.TabIndex = 7;
            this.createAccount.TabStop = true;
            this.createAccount.Text = "Noch kein Konto?";
            this.createAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccount_LinkClicked);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(306, 168);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(135, 32);
            this.login.TabIndex = 6;
            this.login.Text = "Anmelden";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(163, 133);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(278, 29);
            this.pass.TabIndex = 5;
            this.pass.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(53, 136);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(104, 24);
            this.password.TabIndex = 4;
            this.password.Text = "Kennwort:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(163, 98);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(278, 29);
            this.user.TabIndex = 3;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(6, 101);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(151, 24);
            this.username.TabIndex = 2;
            this.username.Text = "Benutzername:";
            // 
            // selectBank
            // 
            this.selectBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectBank.FormattingEnabled = true;
            this.selectBank.Items.AddRange(new object[] {
            "Bank of Ongart",
            "Bank of Germany",
            "Bank of Liberty"});
            this.selectBank.Location = new System.Drawing.Point(163, 38);
            this.selectBank.Name = "selectBank";
            this.selectBank.Size = new System.Drawing.Size(278, 32);
            this.selectBank.TabIndex = 1;
            this.selectBank.SelectedIndexChanged += new System.EventHandler(this.selectBank_SelectedIndexChanged);
            // 
            // Bank_Login
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 232);
            this.Controls.Add(this.anmeldung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bank_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmelden - The Virtualisation Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bank_Login_FormClosing);
            this.Load += new System.EventHandler(this.Bank_Login_Load);
            this.anmeldung.ResumeLayout(false);
            this.anmeldung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label bank;
        internal System.Windows.Forms.GroupBox anmeldung;
        internal System.Windows.Forms.LinkLabel DeveloperAccess;
        internal System.Windows.Forms.LinkLabel createAccount;
        internal System.Windows.Forms.Button login;
        internal System.Windows.Forms.TextBox pass;
        internal System.Windows.Forms.Label password;
        internal System.Windows.Forms.TextBox user;
        internal System.Windows.Forms.Label username;
        internal System.Windows.Forms.ComboBox selectBank;
    }
}