namespace TVP.Managing
{
    partial class BankAccountManager
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
            this.BalanceSettingsBtn = new System.Windows.Forms.Button();
            this.BalanceLbl = new System.Windows.Forms.Label();
            this.BalanceInfoLbl = new System.Windows.Forms.Label();
            this.AccountNumberLbl = new System.Windows.Forms.Label();
            this.AccountNumberInfoLbl = new System.Windows.Forms.Label();
            this.UsernameSettingsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasswordSettingsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ändernToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BalanceSettingsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountManagerTabControl = new System.Windows.Forms.TabControl();
            this.AccountInfoTab = new System.Windows.Forms.TabPage();
            this.BankInfoTab = new System.Windows.Forms.TabPage();
            this.BankCodeLbl = new System.Windows.Forms.Label();
            this.BankCodeInfoLbl = new System.Windows.Forms.Label();
            this.MaxTransgressionLbl = new System.Windows.Forms.Label();
            this.MaxTransgressionInfoLbl = new System.Windows.Forms.Label();
            this.BankNameInfoLbl = new System.Windows.Forms.Label();
            this.BankNameLbl = new System.Windows.Forms.Label();
            this.GeneralAccountInformationPanel = new System.Windows.Forms.Panel();
            this.PasswordSettingsBtn = new System.Windows.Forms.Button();
            this.UsernameSettingsBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordInfoLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.UsernameInfoLbl = new System.Windows.Forms.Label();
            this.UsernameSettingsContext.SuspendLayout();
            this.PasswordSettingsContext.SuspendLayout();
            this.BalanceSettingsContext.SuspendLayout();
            this.AccountManagerTabControl.SuspendLayout();
            this.AccountInfoTab.SuspendLayout();
            this.BankInfoTab.SuspendLayout();
            this.GeneralAccountInformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BalanceSettingsBtn
            // 
            this.BalanceSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceSettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BalanceSettingsBtn.Location = new System.Drawing.Point(508, 94);
            this.BalanceSettingsBtn.Name = "BalanceSettingsBtn";
            this.BalanceSettingsBtn.Size = new System.Drawing.Size(40, 36);
            this.BalanceSettingsBtn.TabIndex = 15;
            this.BalanceSettingsBtn.Text = "...";
            this.BalanceSettingsBtn.UseVisualStyleBackColor = true;
            this.BalanceSettingsBtn.Click += new System.EventHandler(this.BalanceSettingsBtn_Click);
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceLbl.Location = new System.Drawing.Point(159, 100);
            this.BalanceLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(343, 24);
            this.BalanceLbl.TabIndex = 13;
            this.BalanceLbl.Text = "[tvp.account.bank.balance]";
            // 
            // BalanceInfoLbl
            // 
            this.BalanceInfoLbl.AutoSize = true;
            this.BalanceInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceInfoLbl.Location = new System.Drawing.Point(33, 100);
            this.BalanceInfoLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BalanceInfoLbl.Name = "BalanceInfoLbl";
            this.BalanceInfoLbl.Size = new System.Drawing.Size(120, 24);
            this.BalanceInfoLbl.TabIndex = 12;
            this.BalanceInfoLbl.Text = "Kontostand:";
            // 
            // AccountNumberLbl
            // 
            this.AccountNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNumberLbl.Location = new System.Drawing.Point(159, 20);
            this.AccountNumberLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.AccountNumberLbl.Name = "AccountNumberLbl";
            this.AccountNumberLbl.Size = new System.Drawing.Size(389, 24);
            this.AccountNumberLbl.TabIndex = 11;
            this.AccountNumberLbl.Text = "[tvp.account.bank.accountNumber]";
            // 
            // AccountNumberInfoLbl
            // 
            this.AccountNumberInfoLbl.AutoSize = true;
            this.AccountNumberInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberInfoLbl.Location = new System.Drawing.Point(6, 20);
            this.AccountNumberInfoLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.AccountNumberInfoLbl.Name = "AccountNumberInfoLbl";
            this.AccountNumberInfoLbl.Size = new System.Drawing.Size(147, 24);
            this.AccountNumberInfoLbl.TabIndex = 10;
            this.AccountNumberInfoLbl.Text = "Kontonummer:";
            // 
            // UsernameSettingsContext
            // 
            this.UsernameSettingsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändernToolStripMenuItem,
            this.Separator1,
            this.löschenToolStripMenuItem});
            this.UsernameSettingsContext.Name = "UsernameSettingsContext";
            this.UsernameSettingsContext.Size = new System.Drawing.Size(190, 54);
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ändernToolStripMenuItem.Text = "Ändern...";
            this.ändernToolStripMenuItem.Click += new System.EventHandler(this.ändernToolStripMenuItem_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(186, 6);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.löschenToolStripMenuItem.Text = "Mein Konto löschen...";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // PasswordSettingsContext
            // 
            this.PasswordSettingsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändernToolStripMenuItem1});
            this.PasswordSettingsContext.Name = "PasswordSettingsContext";
            this.PasswordSettingsContext.Size = new System.Drawing.Size(123, 26);
            // 
            // ändernToolStripMenuItem1
            // 
            this.ändernToolStripMenuItem1.Name = "ändernToolStripMenuItem1";
            this.ändernToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.ändernToolStripMenuItem1.Text = "Ändern...";
            this.ändernToolStripMenuItem1.Click += new System.EventHandler(this.ändernToolStripMenuItem1_Click);
            // 
            // BalanceSettingsContext
            // 
            this.BalanceSettingsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualisierenToolStripMenuItem});
            this.BalanceSettingsContext.Name = "BalanceSettingsContext";
            this.BalanceSettingsContext.Size = new System.Drawing.Size(152, 26);
            // 
            // aktualisierenToolStripMenuItem
            // 
            this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
            this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aktualisierenToolStripMenuItem.Text = "Aktualisieren...";
            this.aktualisierenToolStripMenuItem.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem_Click);
            // 
            // AccountManagerTabControl
            // 
            this.AccountManagerTabControl.Controls.Add(this.AccountInfoTab);
            this.AccountManagerTabControl.Controls.Add(this.BankInfoTab);
            this.AccountManagerTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccountManagerTabControl.Location = new System.Drawing.Point(0, 105);
            this.AccountManagerTabControl.Name = "AccountManagerTabControl";
            this.AccountManagerTabControl.SelectedIndex = 0;
            this.AccountManagerTabControl.Size = new System.Drawing.Size(562, 181);
            this.AccountManagerTabControl.TabIndex = 10;
            // 
            // AccountInfoTab
            // 
            this.AccountInfoTab.BackColor = System.Drawing.SystemColors.Control;
            this.AccountInfoTab.Controls.Add(this.BalanceSettingsBtn);
            this.AccountInfoTab.Controls.Add(this.BalanceLbl);
            this.AccountInfoTab.Controls.Add(this.AccountNumberInfoLbl);
            this.AccountInfoTab.Controls.Add(this.BalanceInfoLbl);
            this.AccountInfoTab.Controls.Add(this.AccountNumberLbl);
            this.AccountInfoTab.Location = new System.Drawing.Point(4, 33);
            this.AccountInfoTab.Name = "AccountInfoTab";
            this.AccountInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountInfoTab.Size = new System.Drawing.Size(554, 144);
            this.AccountInfoTab.TabIndex = 0;
            this.AccountInfoTab.Text = "Konto Info";
            // 
            // BankInfoTab
            // 
            this.BankInfoTab.BackColor = System.Drawing.SystemColors.Control;
            this.BankInfoTab.Controls.Add(this.BankCodeLbl);
            this.BankInfoTab.Controls.Add(this.BankCodeInfoLbl);
            this.BankInfoTab.Controls.Add(this.MaxTransgressionLbl);
            this.BankInfoTab.Controls.Add(this.MaxTransgressionInfoLbl);
            this.BankInfoTab.Controls.Add(this.BankNameInfoLbl);
            this.BankInfoTab.Controls.Add(this.BankNameLbl);
            this.BankInfoTab.Location = new System.Drawing.Point(4, 33);
            this.BankInfoTab.Name = "BankInfoTab";
            this.BankInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.BankInfoTab.Size = new System.Drawing.Size(554, 144);
            this.BankInfoTab.TabIndex = 1;
            this.BankInfoTab.Text = "Bank Info";
            // 
            // BankCodeLbl
            // 
            this.BankCodeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankCodeLbl.Location = new System.Drawing.Point(222, 60);
            this.BankCodeLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BankCodeLbl.Name = "BankCodeLbl";
            this.BankCodeLbl.Size = new System.Drawing.Size(326, 24);
            this.BankCodeLbl.TabIndex = 17;
            this.BankCodeLbl.Text = "[tvp.account.bank.code]";
            // 
            // BankCodeInfoLbl
            // 
            this.BankCodeInfoLbl.AutoSize = true;
            this.BankCodeInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankCodeInfoLbl.Location = new System.Drawing.Point(89, 60);
            this.BankCodeInfoLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BankCodeInfoLbl.Name = "BankCodeInfoLbl";
            this.BankCodeInfoLbl.Size = new System.Drawing.Size(127, 24);
            this.BankCodeInfoLbl.TabIndex = 16;
            this.BankCodeInfoLbl.Text = "Bankleitzahl:";
            // 
            // MaxTransgressionLbl
            // 
            this.MaxTransgressionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTransgressionLbl.Location = new System.Drawing.Point(222, 100);
            this.MaxTransgressionLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.MaxTransgressionLbl.Name = "MaxTransgressionLbl";
            this.MaxTransgressionLbl.Size = new System.Drawing.Size(326, 24);
            this.MaxTransgressionLbl.TabIndex = 15;
            this.MaxTransgressionLbl.Text = "[tvp.account.bank.transgression]";
            // 
            // MaxTransgressionInfoLbl
            // 
            this.MaxTransgressionInfoLbl.AutoSize = true;
            this.MaxTransgressionInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTransgressionInfoLbl.Location = new System.Drawing.Point(6, 100);
            this.MaxTransgressionInfoLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.MaxTransgressionInfoLbl.Name = "MaxTransgressionInfoLbl";
            this.MaxTransgressionInfoLbl.Size = new System.Drawing.Size(210, 24);
            this.MaxTransgressionInfoLbl.TabIndex = 14;
            this.MaxTransgressionInfoLbl.Text = "Max. Überschreitung:";
            // 
            // BankNameInfoLbl
            // 
            this.BankNameInfoLbl.AutoSize = true;
            this.BankNameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNameInfoLbl.Location = new System.Drawing.Point(102, 20);
            this.BankNameInfoLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BankNameInfoLbl.Name = "BankNameInfoLbl";
            this.BankNameInfoLbl.Size = new System.Drawing.Size(114, 24);
            this.BankNameInfoLbl.TabIndex = 12;
            this.BankNameInfoLbl.Text = "Bankname:";
            // 
            // BankNameLbl
            // 
            this.BankNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankNameLbl.Location = new System.Drawing.Point(222, 20);
            this.BankNameLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BankNameLbl.Name = "BankNameLbl";
            this.BankNameLbl.Size = new System.Drawing.Size(326, 24);
            this.BankNameLbl.TabIndex = 13;
            this.BankNameLbl.Text = "[tvp.account.bank.longName] ([tvp.account.bank.shortName])";
            // 
            // GeneralAccountInformationPanel
            // 
            this.GeneralAccountInformationPanel.BackColor = System.Drawing.Color.LightGray;
            this.GeneralAccountInformationPanel.Controls.Add(this.PasswordSettingsBtn);
            this.GeneralAccountInformationPanel.Controls.Add(this.UsernameSettingsBtn);
            this.GeneralAccountInformationPanel.Controls.Add(this.PasswordLbl);
            this.GeneralAccountInformationPanel.Controls.Add(this.PasswordInfoLbl);
            this.GeneralAccountInformationPanel.Controls.Add(this.UsernameLbl);
            this.GeneralAccountInformationPanel.Controls.Add(this.UsernameInfoLbl);
            this.GeneralAccountInformationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralAccountInformationPanel.Location = new System.Drawing.Point(0, 0);
            this.GeneralAccountInformationPanel.Name = "GeneralAccountInformationPanel";
            this.GeneralAccountInformationPanel.Size = new System.Drawing.Size(562, 105);
            this.GeneralAccountInformationPanel.TabIndex = 11;
            // 
            // PasswordSettingsBtn
            // 
            this.PasswordSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordSettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordSettingsBtn.Location = new System.Drawing.Point(519, 54);
            this.PasswordSettingsBtn.Name = "PasswordSettingsBtn";
            this.PasswordSettingsBtn.Size = new System.Drawing.Size(40, 36);
            this.PasswordSettingsBtn.TabIndex = 15;
            this.PasswordSettingsBtn.Text = "...";
            this.PasswordSettingsBtn.UseVisualStyleBackColor = true;
            this.PasswordSettingsBtn.Click += new System.EventHandler(this.PasswordSettingsBtn_Click);
            // 
            // UsernameSettingsBtn
            // 
            this.UsernameSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameSettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsernameSettingsBtn.Location = new System.Drawing.Point(519, 14);
            this.UsernameSettingsBtn.Name = "UsernameSettingsBtn";
            this.UsernameSettingsBtn.Size = new System.Drawing.Size(40, 36);
            this.UsernameSettingsBtn.TabIndex = 14;
            this.UsernameSettingsBtn.Text = "...";
            this.UsernameSettingsBtn.UseVisualStyleBackColor = true;
            this.UsernameSettingsBtn.Click += new System.EventHandler(this.UsernameSettingsBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLbl.Location = new System.Drawing.Point(114, 60);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(399, 24);
            this.PasswordLbl.TabIndex = 13;
            this.PasswordLbl.Text = "[tvp.account.password]";
            // 
            // PasswordInfoLbl
            // 
            this.PasswordInfoLbl.AutoSize = true;
            this.PasswordInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInfoLbl.Location = new System.Drawing.Point(9, 60);
            this.PasswordInfoLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.PasswordInfoLbl.Name = "PasswordInfoLbl";
            this.PasswordInfoLbl.Size = new System.Drawing.Size(99, 24);
            this.PasswordInfoLbl.TabIndex = 12;
            this.PasswordInfoLbl.Text = "Passwort:";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLbl.Location = new System.Drawing.Point(114, 20);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(399, 24);
            this.UsernameLbl.TabIndex = 11;
            this.UsernameLbl.Text = "[tvp.account.username]";
            // 
            // UsernameInfoLbl
            // 
            this.UsernameInfoLbl.AutoSize = true;
            this.UsernameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInfoLbl.Location = new System.Drawing.Point(9, 20);
            this.UsernameInfoLbl.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.UsernameInfoLbl.Name = "UsernameInfoLbl";
            this.UsernameInfoLbl.Size = new System.Drawing.Size(99, 24);
            this.UsernameInfoLbl.TabIndex = 10;
            this.UsernameInfoLbl.Text = "Benutzer:";
            // 
            // BankAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 286);
            this.Controls.Add(this.GeneralAccountInformationPanel);
            this.Controls.Add(this.AccountManagerTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankAccountManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[account] - Bank Account Manager (TVP)";
            this.UsernameSettingsContext.ResumeLayout(false);
            this.PasswordSettingsContext.ResumeLayout(false);
            this.BalanceSettingsContext.ResumeLayout(false);
            this.AccountManagerTabControl.ResumeLayout(false);
            this.AccountInfoTab.ResumeLayout(false);
            this.AccountInfoTab.PerformLayout();
            this.BankInfoTab.ResumeLayout(false);
            this.BankInfoTab.PerformLayout();
            this.GeneralAccountInformationPanel.ResumeLayout(false);
            this.GeneralAccountInformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BalanceLbl;
        private System.Windows.Forms.Label BalanceInfoLbl;
        private System.Windows.Forms.Label AccountNumberLbl;
        private System.Windows.Forms.Label AccountNumberInfoLbl;
        private System.Windows.Forms.Button BalanceSettingsBtn;
        private System.Windows.Forms.ContextMenuStrip UsernameSettingsContext;
        private System.Windows.Forms.ContextMenuStrip PasswordSettingsContext;
        private System.Windows.Forms.ContextMenuStrip BalanceSettingsContext;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.TabControl AccountManagerTabControl;
        private System.Windows.Forms.TabPage AccountInfoTab;
        private System.Windows.Forms.TabPage BankInfoTab;
        private System.Windows.Forms.Label BankCodeLbl;
        private System.Windows.Forms.Label BankCodeInfoLbl;
        private System.Windows.Forms.Label MaxTransgressionLbl;
        private System.Windows.Forms.Label MaxTransgressionInfoLbl;
        private System.Windows.Forms.Label BankNameInfoLbl;
        private System.Windows.Forms.Label BankNameLbl;
        private System.Windows.Forms.Panel GeneralAccountInformationPanel;
        private System.Windows.Forms.Button PasswordSettingsBtn;
        private System.Windows.Forms.Button UsernameSettingsBtn;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label PasswordInfoLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label UsernameInfoLbl;
    }
}