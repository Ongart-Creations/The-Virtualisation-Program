namespace TVP.Utility.Windows
{
    partial class AboutTVPWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutTVPWindow));
            this.ButtonContainerPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AboutTabControl = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.LibBuildLbl = new System.Windows.Forms.Label();
            this.LibBuildInfoLbl = new System.Windows.Forms.Label();
            this.LibVersionLbl = new System.Windows.Forms.Label();
            this.LibVersionInfoLbl = new System.Windows.Forms.Label();
            this.LibCopyrightLbl = new System.Windows.Forms.Label();
            this.LibCopyrightInfoLbl = new System.Windows.Forms.Label();
            this.LibDeveloperLbl = new System.Windows.Forms.Label();
            this.LibDeveloperInfoLbl = new System.Windows.Forms.Label();
            this.LibTitleLbl = new System.Windows.Forms.Label();
            this.GeneralDescriptionLbl = new System.Windows.Forms.Label();
            this.LibTitleInfoLbl = new System.Windows.Forms.Label();
            this.TVPIconPbox = new System.Windows.Forms.PictureBox();
            this.ChangelogTab = new System.Windows.Forms.TabPage();
            this.ChangelogTxt = new System.Windows.Forms.TextBox();
            this.ButtonContainerPanel.SuspendLayout();
            this.AboutTabControl.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVPIconPbox)).BeginInit();
            this.ChangelogTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonContainerPanel
            // 
            this.ButtonContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonContainerPanel.Controls.Add(this.CloseBtn);
            this.ButtonContainerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonContainerPanel.Location = new System.Drawing.Point(0, 247);
            this.ButtonContainerPanel.Name = "ButtonContainerPanel";
            this.ButtonContainerPanel.Size = new System.Drawing.Size(481, 37);
            this.ButtonContainerPanel.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(373, 6);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(96, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Schließen";
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // AboutTabControl
            // 
            this.AboutTabControl.Controls.Add(this.GeneralTab);
            this.AboutTabControl.Controls.Add(this.ChangelogTab);
            this.AboutTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTabControl.Location = new System.Drawing.Point(0, 0);
            this.AboutTabControl.Name = "AboutTabControl";
            this.AboutTabControl.SelectedIndex = 0;
            this.AboutTabControl.Size = new System.Drawing.Size(481, 247);
            this.AboutTabControl.TabIndex = 1;
            // 
            // GeneralTab
            // 
            this.GeneralTab.BackColor = System.Drawing.SystemColors.Control;
            this.GeneralTab.Controls.Add(this.LibBuildLbl);
            this.GeneralTab.Controls.Add(this.LibBuildInfoLbl);
            this.GeneralTab.Controls.Add(this.LibVersionLbl);
            this.GeneralTab.Controls.Add(this.LibVersionInfoLbl);
            this.GeneralTab.Controls.Add(this.LibCopyrightLbl);
            this.GeneralTab.Controls.Add(this.LibCopyrightInfoLbl);
            this.GeneralTab.Controls.Add(this.LibDeveloperLbl);
            this.GeneralTab.Controls.Add(this.LibDeveloperInfoLbl);
            this.GeneralTab.Controls.Add(this.LibTitleLbl);
            this.GeneralTab.Controls.Add(this.GeneralDescriptionLbl);
            this.GeneralTab.Controls.Add(this.LibTitleInfoLbl);
            this.GeneralTab.Controls.Add(this.TVPIconPbox);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Size = new System.Drawing.Size(473, 221);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "Allgemein";
            // 
            // LibBuildLbl
            // 
            this.LibBuildLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibBuildLbl.Location = new System.Drawing.Point(200, 92);
            this.LibBuildLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibBuildLbl.Name = "LibBuildLbl";
            this.LibBuildLbl.Size = new System.Drawing.Size(265, 13);
            this.LibBuildLbl.TabIndex = 11;
            this.LibBuildLbl.Text = "{Assembly.BuildRunningOn}";
            // 
            // LibBuildInfoLbl
            // 
            this.LibBuildInfoLbl.AutoSize = true;
            this.LibBuildInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibBuildInfoLbl.Location = new System.Drawing.Point(114, 92);
            this.LibBuildInfoLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibBuildInfoLbl.Name = "LibBuildInfoLbl";
            this.LibBuildInfoLbl.Size = new System.Drawing.Size(80, 13);
            this.LibBuildInfoLbl.TabIndex = 10;
            this.LibBuildInfoLbl.Text = "Build (.NET):";
            // 
            // LibVersionLbl
            // 
            this.LibVersionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibVersionLbl.Location = new System.Drawing.Point(200, 71);
            this.LibVersionLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibVersionLbl.Name = "LibVersionLbl";
            this.LibVersionLbl.Size = new System.Drawing.Size(265, 13);
            this.LibVersionLbl.TabIndex = 9;
            this.LibVersionLbl.Text = "{Assembly.Version}";
            // 
            // LibVersionInfoLbl
            // 
            this.LibVersionInfoLbl.AutoSize = true;
            this.LibVersionInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibVersionInfoLbl.Location = new System.Drawing.Point(141, 71);
            this.LibVersionInfoLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibVersionInfoLbl.Name = "LibVersionInfoLbl";
            this.LibVersionInfoLbl.Size = new System.Drawing.Size(53, 13);
            this.LibVersionInfoLbl.TabIndex = 8;
            this.LibVersionInfoLbl.Text = "Version:";
            // 
            // LibCopyrightLbl
            // 
            this.LibCopyrightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibCopyrightLbl.Location = new System.Drawing.Point(200, 50);
            this.LibCopyrightLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibCopyrightLbl.Name = "LibCopyrightLbl";
            this.LibCopyrightLbl.Size = new System.Drawing.Size(265, 13);
            this.LibCopyrightLbl.TabIndex = 7;
            this.LibCopyrightLbl.Text = "{Assembly.Copyright}";
            // 
            // LibCopyrightInfoLbl
            // 
            this.LibCopyrightInfoLbl.AutoSize = true;
            this.LibCopyrightInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibCopyrightInfoLbl.Location = new System.Drawing.Point(130, 50);
            this.LibCopyrightInfoLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibCopyrightInfoLbl.Name = "LibCopyrightInfoLbl";
            this.LibCopyrightInfoLbl.Size = new System.Drawing.Size(64, 13);
            this.LibCopyrightInfoLbl.TabIndex = 6;
            this.LibCopyrightInfoLbl.Text = "Copyright:";
            // 
            // LibDeveloperLbl
            // 
            this.LibDeveloperLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibDeveloperLbl.Location = new System.Drawing.Point(200, 29);
            this.LibDeveloperLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibDeveloperLbl.Name = "LibDeveloperLbl";
            this.LibDeveloperLbl.Size = new System.Drawing.Size(265, 13);
            this.LibDeveloperLbl.TabIndex = 5;
            this.LibDeveloperLbl.Text = "{Assembly.Developer}";
            // 
            // LibDeveloperInfoLbl
            // 
            this.LibDeveloperInfoLbl.AutoSize = true;
            this.LibDeveloperInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibDeveloperInfoLbl.Location = new System.Drawing.Point(124, 29);
            this.LibDeveloperInfoLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibDeveloperInfoLbl.Name = "LibDeveloperInfoLbl";
            this.LibDeveloperInfoLbl.Size = new System.Drawing.Size(70, 13);
            this.LibDeveloperInfoLbl.TabIndex = 4;
            this.LibDeveloperInfoLbl.Text = "Entwickler:";
            // 
            // LibTitleLbl
            // 
            this.LibTitleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibTitleLbl.Location = new System.Drawing.Point(200, 8);
            this.LibTitleLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibTitleLbl.Name = "LibTitleLbl";
            this.LibTitleLbl.Size = new System.Drawing.Size(265, 13);
            this.LibTitleLbl.TabIndex = 3;
            this.LibTitleLbl.Text = "{Assembly.Title}";
            // 
            // GeneralDescriptionLbl
            // 
            this.GeneralDescriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralDescriptionLbl.Location = new System.Drawing.Point(8, 111);
            this.GeneralDescriptionLbl.Name = "GeneralDescriptionLbl";
            this.GeneralDescriptionLbl.Size = new System.Drawing.Size(457, 102);
            this.GeneralDescriptionLbl.TabIndex = 2;
            this.GeneralDescriptionLbl.Text = resources.GetString("GeneralDescriptionLbl.Text");
            // 
            // LibTitleInfoLbl
            // 
            this.LibTitleInfoLbl.AutoSize = true;
            this.LibTitleInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibTitleInfoLbl.Location = new System.Drawing.Point(151, 8);
            this.LibTitleInfoLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.LibTitleInfoLbl.Name = "LibTitleInfoLbl";
            this.LibTitleInfoLbl.Size = new System.Drawing.Size(43, 13);
            this.LibTitleInfoLbl.TabIndex = 1;
            this.LibTitleInfoLbl.Text = "Name:";
            // 
            // TVPIconPbox
            // 
            this.TVPIconPbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TVPIconPbox.Image = global::TVP.Properties.Resources.TVP_Logo_128x128;
            this.TVPIconPbox.Location = new System.Drawing.Point(8, 8);
            this.TVPIconPbox.Name = "TVPIconPbox";
            this.TVPIconPbox.Size = new System.Drawing.Size(100, 100);
            this.TVPIconPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TVPIconPbox.TabIndex = 0;
            this.TVPIconPbox.TabStop = false;
            // 
            // ChangelogTab
            // 
            this.ChangelogTab.BackColor = System.Drawing.SystemColors.Control;
            this.ChangelogTab.Controls.Add(this.ChangelogTxt);
            this.ChangelogTab.Location = new System.Drawing.Point(4, 22);
            this.ChangelogTab.Name = "ChangelogTab";
            this.ChangelogTab.Size = new System.Drawing.Size(473, 221);
            this.ChangelogTab.TabIndex = 2;
            this.ChangelogTab.Text = "Changelog";
            // 
            // ChangelogTxt
            // 
            this.ChangelogTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangelogTxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangelogTxt.Location = new System.Drawing.Point(0, 0);
            this.ChangelogTxt.Multiline = true;
            this.ChangelogTxt.Name = "ChangelogTxt";
            this.ChangelogTxt.ReadOnly = true;
            this.ChangelogTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ChangelogTxt.Size = new System.Drawing.Size(473, 221);
            this.ChangelogTxt.TabIndex = 0;
            this.ChangelogTxt.WordWrap = false;
            // 
            // AboutTVPWindow
            // 
            this.AcceptButton = this.CloseBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(481, 284);
            this.Controls.Add(this.AboutTabControl);
            this.Controls.Add(this.ButtonContainerPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 323);
            this.Name = "AboutTVPWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About - The Virtualisation Program";
            this.ButtonContainerPanel.ResumeLayout(false);
            this.AboutTabControl.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVPIconPbox)).EndInit();
            this.ChangelogTab.ResumeLayout(false);
            this.ChangelogTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonContainerPanel;
        private System.Windows.Forms.TabControl AboutTabControl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage ChangelogTab;
        private System.Windows.Forms.PictureBox TVPIconPbox;
        private System.Windows.Forms.Label LibTitleLbl;
        private System.Windows.Forms.Label GeneralDescriptionLbl;
        private System.Windows.Forms.Label LibTitleInfoLbl;
        private System.Windows.Forms.Label LibDeveloperLbl;
        private System.Windows.Forms.Label LibDeveloperInfoLbl;
        private System.Windows.Forms.Label LibCopyrightLbl;
        private System.Windows.Forms.Label LibCopyrightInfoLbl;
        private System.Windows.Forms.Label LibVersionLbl;
        private System.Windows.Forms.Label LibVersionInfoLbl;
        private System.Windows.Forms.Label LibBuildLbl;
        private System.Windows.Forms.Label LibBuildInfoLbl;
        private System.Windows.Forms.TextBox ChangelogTxt;
    }
}