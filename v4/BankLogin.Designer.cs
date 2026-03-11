namespace TVP.v4
{
    partial class BankLogin
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
            this.components = new System.ComponentModel.Container();
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.BankSelectorBtn = new System.Windows.Forms.Button();
            this.DeveloperAccessLinkLbl = new System.Windows.Forms.LinkLabel();
            this.CreateAccountLinkLbl = new System.Windows.Forms.LinkLabel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PasswordInfoLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameInfoLbl = new System.Windows.Forms.Label();
            this.BankSelectorCbx = new System.Windows.Forms.ComboBox();
            this.BankInfoLbl = new System.Windows.Forms.Label();
            this.BankSelectorContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FetchBanksBgw = new System.ComponentModel.BackgroundWorker();
            this.LoginGroup.SuspendLayout();
            this.BankSelectorContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroup
            // 
            this.LoginGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginGroup.Controls.Add(this.BankSelectorBtn);
            this.LoginGroup.Controls.Add(this.DeveloperAccessLinkLbl);
            this.LoginGroup.Controls.Add(this.CreateAccountLinkLbl);
            this.LoginGroup.Controls.Add(this.LoginBtn);
            this.LoginGroup.Controls.Add(this.PasswordTxt);
            this.LoginGroup.Controls.Add(this.PasswordInfoLbl);
            this.LoginGroup.Controls.Add(this.UsernameTxt);
            this.LoginGroup.Controls.Add(this.UsernameInfoLbl);
            this.LoginGroup.Controls.Add(this.BankSelectorCbx);
            this.LoginGroup.Controls.Add(this.BankInfoLbl);
            this.LoginGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroup.Location = new System.Drawing.Point(12, 12);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.Size = new System.Drawing.Size(495, 206);
            this.LoginGroup.TabIndex = 3;
            this.LoginGroup.TabStop = false;
            this.LoginGroup.Text = "Anmeldung";
            // 
            // BankSelectorBtn
            // 
            this.BankSelectorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BankSelectorBtn.Location = new System.Drawing.Point(454, 38);
            this.BankSelectorBtn.Name = "BankSelectorBtn";
            this.BankSelectorBtn.Size = new System.Drawing.Size(35, 32);
            this.BankSelectorBtn.TabIndex = 9;
            this.BankSelectorBtn.Text = "...";
            this.BankSelectorBtn.UseVisualStyleBackColor = true;
            this.BankSelectorBtn.Click += new System.EventHandler(this.BankSelectorBtn_Click);
            // 
            // DeveloperAccessLinkLbl
            // 
            this.DeveloperAccessLinkLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeveloperAccessLinkLbl.AutoSize = true;
            this.DeveloperAccessLinkLbl.Location = new System.Drawing.Point(77, 172);
            this.DeveloperAccessLinkLbl.Name = "DeveloperAccessLinkLbl";
            this.DeveloperAccessLinkLbl.Size = new System.Drawing.Size(96, 24);
            this.DeveloperAccessLinkLbl.TabIndex = 8;
            this.DeveloperAccessLinkLbl.TabStop = true;
            this.DeveloperAccessLinkLbl.Text = "Entwickler";
            this.DeveloperAccessLinkLbl.Visible = false;
            this.DeveloperAccessLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeveloperAccessLinkLbl_LinkClicked);
            // 
            // CreateAccountLinkLbl
            // 
            this.CreateAccountLinkLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateAccountLinkLbl.AutoSize = true;
            this.CreateAccountLinkLbl.Location = new System.Drawing.Point(179, 172);
            this.CreateAccountLinkLbl.Name = "CreateAccountLinkLbl";
            this.CreateAccountLinkLbl.Size = new System.Drawing.Size(160, 24);
            this.CreateAccountLinkLbl.TabIndex = 7;
            this.CreateAccountLinkLbl.TabStop = true;
            this.CreateAccountLinkLbl.Text = "Noch kein Konto?";
            this.CreateAccountLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLinkLbl_LinkClicked);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.Enabled = false;
            this.LoginBtn.Location = new System.Drawing.Point(345, 168);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(135, 32);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Anmelden";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.Location = new System.Drawing.Point(163, 133);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(317, 29);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // PasswordInfoLbl
            // 
            this.PasswordInfoLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PasswordInfoLbl.AutoSize = true;
            this.PasswordInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInfoLbl.Location = new System.Drawing.Point(53, 136);
            this.PasswordInfoLbl.Name = "PasswordInfoLbl";
            this.PasswordInfoLbl.Size = new System.Drawing.Size(104, 24);
            this.PasswordInfoLbl.TabIndex = 4;
            this.PasswordInfoLbl.Text = "Kennwort:";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxt.Location = new System.Drawing.Point(163, 98);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(317, 29);
            this.UsernameTxt.TabIndex = 3;
            // 
            // UsernameInfoLbl
            // 
            this.UsernameInfoLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UsernameInfoLbl.AutoSize = true;
            this.UsernameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInfoLbl.Location = new System.Drawing.Point(6, 101);
            this.UsernameInfoLbl.Name = "UsernameInfoLbl";
            this.UsernameInfoLbl.Size = new System.Drawing.Size(151, 24);
            this.UsernameInfoLbl.TabIndex = 2;
            this.UsernameInfoLbl.Text = "Benutzername:";
            // 
            // BankSelectorCbx
            // 
            this.BankSelectorCbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankSelectorCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BankSelectorCbx.FormattingEnabled = true;
            this.BankSelectorCbx.Items.AddRange(new object[] {
            "-- Wählen Sie eine Bank aus --"});
            this.BankSelectorCbx.Location = new System.Drawing.Point(163, 38);
            this.BankSelectorCbx.Name = "BankSelectorCbx";
            this.BankSelectorCbx.Size = new System.Drawing.Size(285, 32);
            this.BankSelectorCbx.TabIndex = 1;
            this.BankSelectorCbx.SelectedIndexChanged += new System.EventHandler(this.BankSelectorCbx_SelectedIndexChanged);
            // 
            // BankInfoLbl
            // 
            this.BankInfoLbl.AutoSize = true;
            this.BankInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankInfoLbl.Location = new System.Drawing.Point(95, 41);
            this.BankInfoLbl.Name = "BankInfoLbl";
            this.BankInfoLbl.Size = new System.Drawing.Size(62, 24);
            this.BankInfoLbl.TabIndex = 0;
            this.BankInfoLbl.Text = "Bank:";
            // 
            // BankSelectorContext
            // 
            this.BankSelectorContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem});
            this.BankSelectorContext.Name = "BankSelectorContext";
            this.BankSelectorContext.Size = new System.Drawing.Size(152, 26);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.RefreshToolStripMenuItem.Text = "Aktualisieren...";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // FetchBanksBgw
            // 
            this.FetchBanksBgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FetchBanksBgw_DoWork);
            // 
            // BankLogin
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 232);
            this.Controls.Add(this.LoginGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anmelden - The Virtualisation Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankLogin_FormClosing);
            this.Load += new System.EventHandler(this.BankLogin_Load);
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.BankSelectorContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox LoginGroup;
        internal System.Windows.Forms.LinkLabel DeveloperAccessLinkLbl;
        internal System.Windows.Forms.LinkLabel CreateAccountLinkLbl;
        internal System.Windows.Forms.Button LoginBtn;
        internal System.Windows.Forms.TextBox PasswordTxt;
        internal System.Windows.Forms.Label PasswordInfoLbl;
        internal System.Windows.Forms.TextBox UsernameTxt;
        internal System.Windows.Forms.Label UsernameInfoLbl;
        internal System.Windows.Forms.ComboBox BankSelectorCbx;
        internal System.Windows.Forms.Label BankInfoLbl;
        private System.Windows.Forms.Button BankSelectorBtn;
        private System.Windows.Forms.ContextMenuStrip BankSelectorContext;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker FetchBanksBgw;
    }
}