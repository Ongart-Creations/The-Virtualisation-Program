namespace TVP.Managing
{
    partial class BankAccountCreator
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
            this.BankSelectorInfoLbl = new System.Windows.Forms.Label();
            this.BankSelectorCbx = new System.Windows.Forms.ComboBox();
            this.BankSelectorOptionsBtn = new System.Windows.Forms.Button();
            this.UsernameInfoLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.UsernameOptionsBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PasswordInfoLbl = new System.Windows.Forms.Label();
            this.PasswordOptionsBtn = new System.Windows.Forms.Button();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            this.CancelCreationBtn = new System.Windows.Forms.Button();
            this.BankSelectorContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsernameContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aufVerfügbarkeitPrüfenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasswordContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kennwortAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepeatPasswordTxt = new System.Windows.Forms.TextBox();
            this.RepeatPasswordInfoLbl = new System.Windows.Forms.Label();
            this.AdviceInfoLbl = new System.Windows.Forms.LinkLabel();
            this.FetchBanksBgw = new System.ComponentModel.BackgroundWorker();
            this.BankSelectorContext.SuspendLayout();
            this.UsernameContext.SuspendLayout();
            this.PasswordContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankSelectorInfoLbl
            // 
            this.BankSelectorInfoLbl.AutoSize = true;
            this.BankSelectorInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankSelectorInfoLbl.Location = new System.Drawing.Point(12, 20);
            this.BankSelectorInfoLbl.Name = "BankSelectorInfoLbl";
            this.BankSelectorInfoLbl.Size = new System.Drawing.Size(62, 24);
            this.BankSelectorInfoLbl.TabIndex = 0;
            this.BankSelectorInfoLbl.Text = "Bank:";
            // 
            // BankSelectorCbx
            // 
            this.BankSelectorCbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankSelectorCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BankSelectorCbx.FormattingEnabled = true;
            this.BankSelectorCbx.Items.AddRange(new object[] {
            "-- Wählen Sie eine Bank aus --"});
            this.BankSelectorCbx.Location = new System.Drawing.Point(80, 17);
            this.BankSelectorCbx.Name = "BankSelectorCbx";
            this.BankSelectorCbx.Size = new System.Drawing.Size(352, 32);
            this.BankSelectorCbx.TabIndex = 1;
            this.BankSelectorCbx.SelectedIndexChanged += new System.EventHandler(this.BankSelectorCbx_SelectedIndexChanged);
            // 
            // BankSelectorOptionsBtn
            // 
            this.BankSelectorOptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BankSelectorOptionsBtn.Location = new System.Drawing.Point(438, 17);
            this.BankSelectorOptionsBtn.Name = "BankSelectorOptionsBtn";
            this.BankSelectorOptionsBtn.Size = new System.Drawing.Size(35, 32);
            this.BankSelectorOptionsBtn.TabIndex = 2;
            this.BankSelectorOptionsBtn.Text = "...";
            this.BankSelectorOptionsBtn.UseVisualStyleBackColor = true;
            this.BankSelectorOptionsBtn.Click += new System.EventHandler(this.BankSelectorOptionsBtn_Click);
            // 
            // UsernameInfoLbl
            // 
            this.UsernameInfoLbl.AutoSize = true;
            this.UsernameInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInfoLbl.Location = new System.Drawing.Point(38, 73);
            this.UsernameInfoLbl.Name = "UsernameInfoLbl";
            this.UsernameInfoLbl.Size = new System.Drawing.Size(129, 24);
            this.UsernameInfoLbl.TabIndex = 3;
            this.UsernameInfoLbl.Text = "Nutzername:";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxt.Location = new System.Drawing.Point(173, 70);
            this.UsernameTxt.MaxLength = 20;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(259, 29);
            this.UsernameTxt.TabIndex = 4;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.TextFields_TextChanged);
            // 
            // UsernameOptionsBtn
            // 
            this.UsernameOptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameOptionsBtn.Location = new System.Drawing.Point(438, 68);
            this.UsernameOptionsBtn.Name = "UsernameOptionsBtn";
            this.UsernameOptionsBtn.Size = new System.Drawing.Size(35, 32);
            this.UsernameOptionsBtn.TabIndex = 5;
            this.UsernameOptionsBtn.Text = "...";
            this.UsernameOptionsBtn.UseVisualStyleBackColor = true;
            this.UsernameOptionsBtn.Click += new System.EventHandler(this.UsernameOptionsBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.Location = new System.Drawing.Point(173, 105);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(259, 29);
            this.PasswordTxt.TabIndex = 7;
            this.PasswordTxt.UseSystemPasswordChar = true;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.TextFields_TextChanged);
            // 
            // PasswordInfoLbl
            // 
            this.PasswordInfoLbl.AutoSize = true;
            this.PasswordInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInfoLbl.Location = new System.Drawing.Point(63, 108);
            this.PasswordInfoLbl.Name = "PasswordInfoLbl";
            this.PasswordInfoLbl.Size = new System.Drawing.Size(104, 24);
            this.PasswordInfoLbl.TabIndex = 6;
            this.PasswordInfoLbl.Text = "Kennwort:";
            // 
            // PasswordOptionsBtn
            // 
            this.PasswordOptionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordOptionsBtn.Location = new System.Drawing.Point(438, 103);
            this.PasswordOptionsBtn.Name = "PasswordOptionsBtn";
            this.PasswordOptionsBtn.Size = new System.Drawing.Size(35, 32);
            this.PasswordOptionsBtn.TabIndex = 8;
            this.PasswordOptionsBtn.Text = "...";
            this.PasswordOptionsBtn.UseVisualStyleBackColor = true;
            this.PasswordOptionsBtn.Click += new System.EventHandler(this.PasswordOptionsBtn_Click);
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateAccountBtn.Enabled = false;
            this.CreateAccountBtn.Location = new System.Drawing.Point(292, 180);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(181, 32);
            this.CreateAccountBtn.TabIndex = 11;
            this.CreateAccountBtn.Text = "Konto eröffnen";
            this.CreateAccountBtn.UseVisualStyleBackColor = true;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // CancelCreationBtn
            // 
            this.CancelCreationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelCreationBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCreationBtn.Location = new System.Drawing.Point(153, 180);
            this.CancelCreationBtn.Name = "CancelCreationBtn";
            this.CancelCreationBtn.Size = new System.Drawing.Size(133, 32);
            this.CancelCreationBtn.TabIndex = 12;
            this.CancelCreationBtn.Text = "Abbrechen";
            this.CancelCreationBtn.UseVisualStyleBackColor = true;
            this.CancelCreationBtn.Click += new System.EventHandler(this.CancelCreationBtn_Click);
            // 
            // BankSelectorContext
            // 
            this.BankSelectorContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualisierenToolStripMenuItem});
            this.BankSelectorContext.Name = "BankSelectorContext";
            this.BankSelectorContext.Size = new System.Drawing.Size(152, 26);
            // 
            // aktualisierenToolStripMenuItem
            // 
            this.aktualisierenToolStripMenuItem.Name = "aktualisierenToolStripMenuItem";
            this.aktualisierenToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aktualisierenToolStripMenuItem.Text = "Aktualisieren...";
            this.aktualisierenToolStripMenuItem.Click += new System.EventHandler(this.aktualisierenToolStripMenuItem_Click);
            // 
            // UsernameContext
            // 
            this.UsernameContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aufVerfügbarkeitPrüfenToolStripMenuItem});
            this.UsernameContext.Name = "UsernameContext";
            this.UsernameContext.Size = new System.Drawing.Size(214, 26);
            // 
            // aufVerfügbarkeitPrüfenToolStripMenuItem
            // 
            this.aufVerfügbarkeitPrüfenToolStripMenuItem.Name = "aufVerfügbarkeitPrüfenToolStripMenuItem";
            this.aufVerfügbarkeitPrüfenToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.aufVerfügbarkeitPrüfenToolStripMenuItem.Text = "Auf Verfügbarkeit prüfen...";
            this.aufVerfügbarkeitPrüfenToolStripMenuItem.Click += new System.EventHandler(this.aufVerfügbarkeitPrüfenToolStripMenuItem_Click);
            // 
            // PasswordContext
            // 
            this.PasswordContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kennwortAnzeigenToolStripMenuItem});
            this.PasswordContext.Name = "PasswordContext";
            this.PasswordContext.Size = new System.Drawing.Size(237, 26);
            // 
            // kennwortAnzeigenToolStripMenuItem
            // 
            this.kennwortAnzeigenToolStripMenuItem.Name = "kennwortAnzeigenToolStripMenuItem";
            this.kennwortAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.kennwortAnzeigenToolStripMenuItem.Text = "Kennwort anzeigen/verstecken";
            this.kennwortAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.kennwortAnzeigenToolStripMenuItem_Click);
            // 
            // RepeatPasswordTxt
            // 
            this.RepeatPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatPasswordTxt.Location = new System.Drawing.Point(173, 140);
            this.RepeatPasswordTxt.Name = "RepeatPasswordTxt";
            this.RepeatPasswordTxt.Size = new System.Drawing.Size(259, 29);
            this.RepeatPasswordTxt.TabIndex = 10;
            this.RepeatPasswordTxt.UseSystemPasswordChar = true;
            this.RepeatPasswordTxt.TextChanged += new System.EventHandler(this.TextFields_TextChanged);
            // 
            // RepeatPasswordInfoLbl
            // 
            this.RepeatPasswordInfoLbl.AutoSize = true;
            this.RepeatPasswordInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordInfoLbl.Location = new System.Drawing.Point(12, 143);
            this.RepeatPasswordInfoLbl.Name = "RepeatPasswordInfoLbl";
            this.RepeatPasswordInfoLbl.Size = new System.Drawing.Size(155, 24);
            this.RepeatPasswordInfoLbl.TabIndex = 9;
            this.RepeatPasswordInfoLbl.Text = "Kennwort wdh.:";
            // 
            // AdviceInfoLbl
            // 
            this.AdviceInfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdviceInfoLbl.AutoSize = true;
            this.AdviceInfoLbl.Location = new System.Drawing.Point(12, 184);
            this.AdviceInfoLbl.Name = "AdviceInfoLbl";
            this.AdviceInfoLbl.Size = new System.Drawing.Size(77, 24);
            this.AdviceInfoLbl.TabIndex = 13;
            this.AdviceInfoLbl.TabStop = true;
            this.AdviceInfoLbl.Text = "Hinweis";
            this.AdviceInfoLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdviceInfoLbl_LinkClicked);
            // 
            // FetchBanksBgw
            // 
            this.FetchBanksBgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FetchBanksBgw_DoWork);
            // 
            // BankAccountCreator
            // 
            this.AcceptButton = this.CreateAccountBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelCreationBtn;
            this.ClientSize = new System.Drawing.Size(485, 224);
            this.Controls.Add(this.AdviceInfoLbl);
            this.Controls.Add(this.RepeatPasswordTxt);
            this.Controls.Add(this.RepeatPasswordInfoLbl);
            this.Controls.Add(this.CancelCreationBtn);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.PasswordOptionsBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PasswordInfoLbl);
            this.Controls.Add(this.UsernameOptionsBtn);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.UsernameInfoLbl);
            this.Controls.Add(this.BankSelectorOptionsBtn);
            this.Controls.Add(this.BankSelectorCbx);
            this.Controls.Add(this.BankSelectorInfoLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankAccountCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konto eröffnen - The Virtualisation Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankAccountCreator_FormClosing);
            this.Load += new System.EventHandler(this.BankAccountCreator_Load);
            this.BankSelectorContext.ResumeLayout(false);
            this.UsernameContext.ResumeLayout(false);
            this.PasswordContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankSelectorInfoLbl;
        private System.Windows.Forms.ComboBox BankSelectorCbx;
        private System.Windows.Forms.Button BankSelectorOptionsBtn;
        private System.Windows.Forms.Label UsernameInfoLbl;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Button UsernameOptionsBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label PasswordInfoLbl;
        private System.Windows.Forms.Button PasswordOptionsBtn;
        private System.Windows.Forms.Button CreateAccountBtn;
        private System.Windows.Forms.Button CancelCreationBtn;
        private System.Windows.Forms.ContextMenuStrip BankSelectorContext;
        private System.Windows.Forms.ContextMenuStrip UsernameContext;
        private System.Windows.Forms.ContextMenuStrip PasswordContext;
        private System.Windows.Forms.ToolStripMenuItem aktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aufVerfügbarkeitPrüfenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kennwortAnzeigenToolStripMenuItem;
        private System.Windows.Forms.TextBox RepeatPasswordTxt;
        private System.Windows.Forms.Label RepeatPasswordInfoLbl;
        private System.Windows.Forms.LinkLabel AdviceInfoLbl;
        private System.ComponentModel.BackgroundWorker FetchBanksBgw;
    }
}