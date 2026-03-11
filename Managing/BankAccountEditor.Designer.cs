namespace TVP.Managing
{
    partial class BankAccountEditor
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
            this.ButtonContainerPanel = new System.Windows.Forms.Panel();
            this.CancelOperationBtn = new System.Windows.Forms.Button();
            this.ChangeInformationBtn = new System.Windows.Forms.Button();
            this.EditorTabControl = new System.Windows.Forms.TabControl();
            this.UsernameEditorTab = new System.Windows.Forms.TabPage();
            this.DisplayNameHelpLinkLbl = new System.Windows.Forms.LinkLabel();
            this.DisplayNameLbl = new System.Windows.Forms.Label();
            this.DisplayNameInfoLbl = new System.Windows.Forms.Label();
            this.NewUsernameOptionsBtn = new System.Windows.Forms.Button();
            this.NewUsernameTxt = new System.Windows.Forms.TextBox();
            this.NewUsernameInfoLbl = new System.Windows.Forms.Label();
            this.CurrentUsernameLbl = new System.Windows.Forms.Label();
            this.CurrentUsernameInfoLbl = new System.Windows.Forms.Label();
            this.PasswordEditorTab = new System.Windows.Forms.TabPage();
            this.RepeatNewPasswordOptionsBtn = new System.Windows.Forms.Button();
            this.NewPasswordOptionsBtn = new System.Windows.Forms.Button();
            this.OldPasswordOptionsBtn = new System.Windows.Forms.Button();
            this.RepeatNewPasswordTxt = new System.Windows.Forms.TextBox();
            this.RepeatNewPasswordInfoLbl = new System.Windows.Forms.Label();
            this.NewPasswordTxt = new System.Windows.Forms.TextBox();
            this.NewPasswordInfoLbl = new System.Windows.Forms.Label();
            this.OldPasswordTxt = new System.Windows.Forms.TextBox();
            this.OldPasswordInfoLbl = new System.Windows.Forms.Label();
            this.NewUsernameContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AccountExistenceCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonContainerPanel.SuspendLayout();
            this.EditorTabControl.SuspendLayout();
            this.UsernameEditorTab.SuspendLayout();
            this.PasswordEditorTab.SuspendLayout();
            this.NewUsernameContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonContainerPanel
            // 
            this.ButtonContainerPanel.Controls.Add(this.CancelOperationBtn);
            this.ButtonContainerPanel.Controls.Add(this.ChangeInformationBtn);
            this.ButtonContainerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonContainerPanel.Location = new System.Drawing.Point(0, 181);
            this.ButtonContainerPanel.Name = "ButtonContainerPanel";
            this.ButtonContainerPanel.Size = new System.Drawing.Size(523, 46);
            this.ButtonContainerPanel.TabIndex = 1;
            // 
            // CancelOperationBtn
            // 
            this.CancelOperationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelOperationBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelOperationBtn.Location = new System.Drawing.Point(211, 6);
            this.CancelOperationBtn.Name = "CancelOperationBtn";
            this.CancelOperationBtn.Size = new System.Drawing.Size(147, 32);
            this.CancelOperationBtn.TabIndex = 1;
            this.CancelOperationBtn.Text = "Abbrechen";
            this.CancelOperationBtn.UseVisualStyleBackColor = true;
            this.CancelOperationBtn.Click += new System.EventHandler(this.CancelOperationBtn_Click);
            // 
            // ChangeInformationBtn
            // 
            this.ChangeInformationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeInformationBtn.Location = new System.Drawing.Point(364, 6);
            this.ChangeInformationBtn.Name = "ChangeInformationBtn";
            this.ChangeInformationBtn.Size = new System.Drawing.Size(147, 32);
            this.ChangeInformationBtn.TabIndex = 0;
            this.ChangeInformationBtn.Text = "Ändern";
            this.ChangeInformationBtn.UseVisualStyleBackColor = true;
            this.ChangeInformationBtn.Click += new System.EventHandler(this.ChangeInformationBtn_Click);
            // 
            // EditorTabControl
            // 
            this.EditorTabControl.Controls.Add(this.UsernameEditorTab);
            this.EditorTabControl.Controls.Add(this.PasswordEditorTab);
            this.EditorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTabControl.Location = new System.Drawing.Point(0, 0);
            this.EditorTabControl.Name = "EditorTabControl";
            this.EditorTabControl.SelectedIndex = 0;
            this.EditorTabControl.Size = new System.Drawing.Size(523, 181);
            this.EditorTabControl.TabIndex = 2;
            // 
            // UsernameEditorTab
            // 
            this.UsernameEditorTab.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameEditorTab.Controls.Add(this.DisplayNameHelpLinkLbl);
            this.UsernameEditorTab.Controls.Add(this.DisplayNameLbl);
            this.UsernameEditorTab.Controls.Add(this.DisplayNameInfoLbl);
            this.UsernameEditorTab.Controls.Add(this.NewUsernameOptionsBtn);
            this.UsernameEditorTab.Controls.Add(this.NewUsernameTxt);
            this.UsernameEditorTab.Controls.Add(this.NewUsernameInfoLbl);
            this.UsernameEditorTab.Controls.Add(this.CurrentUsernameLbl);
            this.UsernameEditorTab.Controls.Add(this.CurrentUsernameInfoLbl);
            this.UsernameEditorTab.Location = new System.Drawing.Point(4, 33);
            this.UsernameEditorTab.Name = "UsernameEditorTab";
            this.UsernameEditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsernameEditorTab.Size = new System.Drawing.Size(515, 144);
            this.UsernameEditorTab.TabIndex = 0;
            this.UsernameEditorTab.Tag = TVP.Enums.EditorTab.Username;
            this.UsernameEditorTab.Text = "Nutzername ändern";
            // 
            // DisplayNameHelpLinkLbl
            // 
            this.DisplayNameHelpLinkLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayNameHelpLinkLbl.Location = new System.Drawing.Point(479, 106);
            this.DisplayNameHelpLinkLbl.Name = "DisplayNameHelpLinkLbl";
            this.DisplayNameHelpLinkLbl.Size = new System.Drawing.Size(28, 24);
            this.DisplayNameHelpLinkLbl.TabIndex = 7;
            this.DisplayNameHelpLinkLbl.TabStop = true;
            this.DisplayNameHelpLinkLbl.Text = "?";
            this.DisplayNameHelpLinkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisplayNameHelpLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DisplayNameHelpLinkLbl_LinkClicked);
            // 
            // DisplayNameLbl
            // 
            this.DisplayNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayNameLbl.Location = new System.Drawing.Point(231, 106);
            this.DisplayNameLbl.Name = "DisplayNameLbl";
            this.DisplayNameLbl.Size = new System.Drawing.Size(242, 24);
            this.DisplayNameLbl.TabIndex = 6;
            this.DisplayNameLbl.Text = "{username.filteredName}";
            // 
            // DisplayNameInfoLbl
            // 
            this.DisplayNameInfoLbl.AutoSize = true;
            this.DisplayNameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameInfoLbl.Location = new System.Drawing.Point(80, 106);
            this.DisplayNameInfoLbl.Name = "DisplayNameInfoLbl";
            this.DisplayNameInfoLbl.Size = new System.Drawing.Size(145, 24);
            this.DisplayNameInfoLbl.TabIndex = 5;
            this.DisplayNameInfoLbl.Text = "Anzeigename:";
            // 
            // NewUsernameOptionsBtn
            // 
            this.NewUsernameOptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewUsernameOptionsBtn.Location = new System.Drawing.Point(469, 58);
            this.NewUsernameOptionsBtn.Name = "NewUsernameOptionsBtn";
            this.NewUsernameOptionsBtn.Size = new System.Drawing.Size(40, 36);
            this.NewUsernameOptionsBtn.TabIndex = 4;
            this.NewUsernameOptionsBtn.Text = "...";
            this.NewUsernameOptionsBtn.UseVisualStyleBackColor = true;
            this.NewUsernameOptionsBtn.Click += new System.EventHandler(this.NewUsernameOptionsBtn_Click);
            // 
            // NewUsernameTxt
            // 
            this.NewUsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewUsernameTxt.Location = new System.Drawing.Point(231, 61);
            this.NewUsernameTxt.MaxLength = 20;
            this.NewUsernameTxt.Name = "NewUsernameTxt";
            this.NewUsernameTxt.Size = new System.Drawing.Size(232, 29);
            this.NewUsernameTxt.TabIndex = 3;
            this.NewUsernameTxt.TextChanged += new System.EventHandler(this.NewUsernameTxt_TextChanged);
            // 
            // NewUsernameInfoLbl
            // 
            this.NewUsernameInfoLbl.AutoSize = true;
            this.NewUsernameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUsernameInfoLbl.Location = new System.Drawing.Point(32, 64);
            this.NewUsernameInfoLbl.Name = "NewUsernameInfoLbl";
            this.NewUsernameInfoLbl.Size = new System.Drawing.Size(193, 24);
            this.NewUsernameInfoLbl.TabIndex = 2;
            this.NewUsernameInfoLbl.Text = "Neuer Nutzername:";
            // 
            // CurrentUsernameLbl
            // 
            this.CurrentUsernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentUsernameLbl.Location = new System.Drawing.Point(231, 15);
            this.CurrentUsernameLbl.Name = "CurrentUsernameLbl";
            this.CurrentUsernameLbl.Size = new System.Drawing.Size(276, 24);
            this.CurrentUsernameLbl.TabIndex = 1;
            this.CurrentUsernameLbl.Text = "{account.name}";
            // 
            // CurrentUsernameInfoLbl
            // 
            this.CurrentUsernameInfoLbl.AutoSize = true;
            this.CurrentUsernameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUsernameInfoLbl.Location = new System.Drawing.Point(8, 15);
            this.CurrentUsernameInfoLbl.Name = "CurrentUsernameInfoLbl";
            this.CurrentUsernameInfoLbl.Size = new System.Drawing.Size(217, 24);
            this.CurrentUsernameInfoLbl.TabIndex = 0;
            this.CurrentUsernameInfoLbl.Text = "Aktueller Nutzername:";
            // 
            // PasswordEditorTab
            // 
            this.PasswordEditorTab.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordEditorTab.Controls.Add(this.RepeatNewPasswordOptionsBtn);
            this.PasswordEditorTab.Controls.Add(this.NewPasswordOptionsBtn);
            this.PasswordEditorTab.Controls.Add(this.OldPasswordOptionsBtn);
            this.PasswordEditorTab.Controls.Add(this.RepeatNewPasswordTxt);
            this.PasswordEditorTab.Controls.Add(this.RepeatNewPasswordInfoLbl);
            this.PasswordEditorTab.Controls.Add(this.NewPasswordTxt);
            this.PasswordEditorTab.Controls.Add(this.NewPasswordInfoLbl);
            this.PasswordEditorTab.Controls.Add(this.OldPasswordTxt);
            this.PasswordEditorTab.Controls.Add(this.OldPasswordInfoLbl);
            this.PasswordEditorTab.Location = new System.Drawing.Point(4, 33);
            this.PasswordEditorTab.Name = "PasswordEditorTab";
            this.PasswordEditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordEditorTab.Size = new System.Drawing.Size(515, 144);
            this.PasswordEditorTab.TabIndex = 1;
            this.PasswordEditorTab.Tag = TVP.Enums.EditorTab.Password;
            this.PasswordEditorTab.Text = "Passwort ändern";
            // 
            // RepeatNewPasswordOptionsBtn
            // 
            this.RepeatNewPasswordOptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatNewPasswordOptionsBtn.Location = new System.Drawing.Point(469, 100);
            this.RepeatNewPasswordOptionsBtn.Name = "RepeatNewPasswordOptionsBtn";
            this.RepeatNewPasswordOptionsBtn.Size = new System.Drawing.Size(40, 36);
            this.RepeatNewPasswordOptionsBtn.TabIndex = 9;
            this.RepeatNewPasswordOptionsBtn.TabStop = false;
            this.RepeatNewPasswordOptionsBtn.Text = "...";
            this.RepeatNewPasswordOptionsBtn.UseVisualStyleBackColor = true;
            this.RepeatNewPasswordOptionsBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RepeatNewPasswordOptionsBtn_MouseDown);
            this.RepeatNewPasswordOptionsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RepeatNewPasswordOptionsBtn_MouseUp);
            // 
            // NewPasswordOptionsBtn
            // 
            this.NewPasswordOptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordOptionsBtn.Location = new System.Drawing.Point(469, 58);
            this.NewPasswordOptionsBtn.Name = "NewPasswordOptionsBtn";
            this.NewPasswordOptionsBtn.Size = new System.Drawing.Size(40, 36);
            this.NewPasswordOptionsBtn.TabIndex = 6;
            this.NewPasswordOptionsBtn.TabStop = false;
            this.NewPasswordOptionsBtn.Text = "...";
            this.NewPasswordOptionsBtn.UseVisualStyleBackColor = true;
            this.NewPasswordOptionsBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewPasswordOptionsBtn_MouseDown);
            this.NewPasswordOptionsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewPasswordOptionsBtn_MouseUp);
            // 
            // OldPasswordOptionsBtn
            // 
            this.OldPasswordOptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordOptionsBtn.Location = new System.Drawing.Point(469, 9);
            this.OldPasswordOptionsBtn.Name = "OldPasswordOptionsBtn";
            this.OldPasswordOptionsBtn.Size = new System.Drawing.Size(40, 36);
            this.OldPasswordOptionsBtn.TabIndex = 2;
            this.OldPasswordOptionsBtn.TabStop = false;
            this.OldPasswordOptionsBtn.Text = "...";
            this.OldPasswordOptionsBtn.UseVisualStyleBackColor = true;
            this.OldPasswordOptionsBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OldPasswordOptionsBtn_MouseDown);
            this.OldPasswordOptionsBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OldPasswordOptionsBtn_MouseUp);
            // 
            // RepeatNewPasswordTxt
            // 
            this.RepeatNewPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatNewPasswordTxt.Location = new System.Drawing.Point(231, 103);
            this.RepeatNewPasswordTxt.MaxLength = 20;
            this.RepeatNewPasswordTxt.Name = "RepeatNewPasswordTxt";
            this.RepeatNewPasswordTxt.Size = new System.Drawing.Size(232, 29);
            this.RepeatNewPasswordTxt.TabIndex = 8;
            this.RepeatNewPasswordTxt.UseSystemPasswordChar = true;
            // 
            // RepeatNewPasswordInfoLbl
            // 
            this.RepeatNewPasswordInfoLbl.AutoSize = true;
            this.RepeatNewPasswordInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatNewPasswordInfoLbl.Location = new System.Drawing.Point(8, 106);
            this.RepeatNewPasswordInfoLbl.Name = "RepeatNewPasswordInfoLbl";
            this.RepeatNewPasswordInfoLbl.Size = new System.Drawing.Size(217, 24);
            this.RepeatNewPasswordInfoLbl.TabIndex = 7;
            this.RepeatNewPasswordInfoLbl.Text = "Neues Passwort wdh.:";
            // 
            // NewPasswordTxt
            // 
            this.NewPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordTxt.Location = new System.Drawing.Point(231, 61);
            this.NewPasswordTxt.MaxLength = 20;
            this.NewPasswordTxt.Name = "NewPasswordTxt";
            this.NewPasswordTxt.Size = new System.Drawing.Size(232, 29);
            this.NewPasswordTxt.TabIndex = 4;
            this.NewPasswordTxt.UseSystemPasswordChar = true;
            // 
            // NewPasswordInfoLbl
            // 
            this.NewPasswordInfoLbl.AutoSize = true;
            this.NewPasswordInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordInfoLbl.Location = new System.Drawing.Point(59, 64);
            this.NewPasswordInfoLbl.Name = "NewPasswordInfoLbl";
            this.NewPasswordInfoLbl.Size = new System.Drawing.Size(166, 24);
            this.NewPasswordInfoLbl.TabIndex = 3;
            this.NewPasswordInfoLbl.Text = "Neues Passwort:";
            // 
            // OldPasswordTxt
            // 
            this.OldPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordTxt.Location = new System.Drawing.Point(231, 12);
            this.OldPasswordTxt.Name = "OldPasswordTxt";
            this.OldPasswordTxt.Size = new System.Drawing.Size(232, 29);
            this.OldPasswordTxt.TabIndex = 1;
            this.OldPasswordTxt.UseSystemPasswordChar = true;
            // 
            // OldPasswordInfoLbl
            // 
            this.OldPasswordInfoLbl.AutoSize = true;
            this.OldPasswordInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPasswordInfoLbl.Location = new System.Drawing.Point(74, 15);
            this.OldPasswordInfoLbl.Name = "OldPasswordInfoLbl";
            this.OldPasswordInfoLbl.Size = new System.Drawing.Size(151, 24);
            this.OldPasswordInfoLbl.TabIndex = 0;
            this.OldPasswordInfoLbl.Text = "Altes Passwort:";
            // 
            // NewUsernameContext
            // 
            this.NewUsernameContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountExistenceCheckToolStripMenuItem});
            this.NewUsernameContext.Name = "NewUsernameContext";
            this.NewUsernameContext.Size = new System.Drawing.Size(214, 26);
            // 
            // AccountExistenceCheckToolStripMenuItem
            // 
            this.AccountExistenceCheckToolStripMenuItem.Name = "AccountExistenceCheckToolStripMenuItem";
            this.AccountExistenceCheckToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.AccountExistenceCheckToolStripMenuItem.Text = "Auf Verfügbarkeit prüfen...";
            this.AccountExistenceCheckToolStripMenuItem.Click += new System.EventHandler(this.AccountExistenceCheckToolStripMenuItem_Click);
            // 
            // BankAccountEditor
            // 
            this.AcceptButton = this.ChangeInformationBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelOperationBtn;
            this.ClientSize = new System.Drawing.Size(523, 227);
            this.Controls.Add(this.EditorTabControl);
            this.Controls.Add(this.ButtonContainerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankAccountEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account Editor (TVP)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankAccountEditor_FormClosing);
            this.Load += new System.EventHandler(this.BankAccountEditor_Load);
            this.ButtonContainerPanel.ResumeLayout(false);
            this.EditorTabControl.ResumeLayout(false);
            this.UsernameEditorTab.ResumeLayout(false);
            this.UsernameEditorTab.PerformLayout();
            this.PasswordEditorTab.ResumeLayout(false);
            this.PasswordEditorTab.PerformLayout();
            this.NewUsernameContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonContainerPanel;
        private System.Windows.Forms.Button ChangeInformationBtn;
        private System.Windows.Forms.TabControl EditorTabControl;
        private System.Windows.Forms.TabPage UsernameEditorTab;
        private System.Windows.Forms.TabPage PasswordEditorTab;
        private System.Windows.Forms.Button CancelOperationBtn;
        private System.Windows.Forms.TextBox OldPasswordTxt;
        private System.Windows.Forms.Label OldPasswordInfoLbl;
        private System.Windows.Forms.Button OldPasswordOptionsBtn;
        private System.Windows.Forms.TextBox RepeatNewPasswordTxt;
        private System.Windows.Forms.Label RepeatNewPasswordInfoLbl;
        private System.Windows.Forms.TextBox NewPasswordTxt;
        private System.Windows.Forms.Label NewPasswordInfoLbl;
        private System.Windows.Forms.Button RepeatNewPasswordOptionsBtn;
        private System.Windows.Forms.Button NewPasswordOptionsBtn;
        private System.Windows.Forms.Label CurrentUsernameInfoLbl;
        private System.Windows.Forms.Label CurrentUsernameLbl;
        private System.Windows.Forms.Label NewUsernameInfoLbl;
        private System.Windows.Forms.Button NewUsernameOptionsBtn;
        private System.Windows.Forms.TextBox NewUsernameTxt;
        private System.Windows.Forms.Label DisplayNameLbl;
        private System.Windows.Forms.Label DisplayNameInfoLbl;
        private System.Windows.Forms.LinkLabel DisplayNameHelpLinkLbl;
        private System.Windows.Forms.ContextMenuStrip NewUsernameContext;
        private System.Windows.Forms.ToolStripMenuItem AccountExistenceCheckToolStripMenuItem;
    }
}