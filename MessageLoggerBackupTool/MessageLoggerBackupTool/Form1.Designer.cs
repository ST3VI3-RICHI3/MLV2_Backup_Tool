namespace MessageLoggerBackupTool
{
    partial class MainWindow
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.TitlebarDBG_Cmd = new System.Windows.Forms.Button();
            this.TitleBarMinButton = new System.Windows.Forms.Button();
            this.TitleBarCloseButton = new System.Windows.Forms.Button();
            this.TitleBarTitle = new System.Windows.Forms.Label();
            this.NavPanelSettingsButton = new System.Windows.Forms.Button();
            this.InitTimer = new System.Windows.Forms.Timer(this.components);
            this.InitLoadLabel = new System.Windows.Forms.Label();
            this.SettingTitleLabel = new System.Windows.Forms.Label();
            this.SettingsBDLocLabel = new System.Windows.Forms.Label();
            this.SettingsBDLocTextBox = new System.Windows.Forms.TextBox();
            this.SettingsBDLocOpenFExButt = new System.Windows.Forms.Button();
            this.SettingsFEx = new System.Windows.Forms.FolderBrowserDialog();
            this.SettingsBackBasePathLabel = new System.Windows.Forms.Label();
            this.SettingsBackBasePathTextBox = new System.Windows.Forms.TextBox();
            this.SettingsBackBasePathFExButt = new System.Windows.Forms.Button();
            this.SettingsBackFolderLabel = new System.Windows.Forms.Label();
            this.SettingsBackFolderTexBox = new System.Windows.Forms.TextBox();
            this.SettingsBackupMethodComboBox = new System.Windows.Forms.ComboBox();
            this.SettingsBackupMethodlabel = new System.Windows.Forms.Label();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.NavPanelMoveButton = new System.Windows.Forms.Button();
            this.SettingsAppVer = new System.Windows.Forms.Label();
            this.BackUpSectionLabel = new System.Windows.Forms.Label();
            this.BackUpSectionCreateBackupButton = new System.Windows.Forms.Button();
            this.SettingsShowBackFolder = new System.Windows.Forms.Button();
            this.InitLoadFailResetButton = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TitleBar.Controls.Add(this.TitlebarDBG_Cmd);
            this.TitleBar.Controls.Add(this.TitleBarMinButton);
            this.TitleBar.Controls.Add(this.TitleBarCloseButton);
            this.TitleBar.Controls.Add(this.TitleBarTitle);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1000, 25);
            this.TitleBar.TabIndex = 0;
            // 
            // TitlebarDBG_Cmd
            // 
            this.TitlebarDBG_Cmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlebarDBG_Cmd.Enabled = false;
            this.TitlebarDBG_Cmd.FlatAppearance.BorderSize = 0;
            this.TitlebarDBG_Cmd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitlebarDBG_Cmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TitlebarDBG_Cmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitlebarDBG_Cmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlebarDBG_Cmd.ForeColor = System.Drawing.Color.White;
            this.TitlebarDBG_Cmd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitlebarDBG_Cmd.Location = new System.Drawing.Point(920, 0);
            this.TitlebarDBG_Cmd.Name = "TitlebarDBG_Cmd";
            this.TitlebarDBG_Cmd.Size = new System.Drawing.Size(30, 25);
            this.TitlebarDBG_Cmd.TabIndex = 2;
            this.TitlebarDBG_Cmd.TabStop = false;
            this.TitlebarDBG_Cmd.Text = ">_";
            this.TitlebarDBG_Cmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TitlebarDBG_Cmd.UseVisualStyleBackColor = true;
            this.TitlebarDBG_Cmd.Visible = false;
            this.TitlebarDBG_Cmd.Click += new System.EventHandler(this.TitlebarDBG_Cmd_Click);
            // 
            // TitleBarMinButton
            // 
            this.TitleBarMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBarMinButton.FlatAppearance.BorderSize = 0;
            this.TitleBarMinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBarMinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TitleBarMinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarMinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBarMinButton.ForeColor = System.Drawing.Color.White;
            this.TitleBarMinButton.Location = new System.Drawing.Point(950, 0);
            this.TitleBarMinButton.Name = "TitleBarMinButton";
            this.TitleBarMinButton.Size = new System.Drawing.Size(25, 25);
            this.TitleBarMinButton.TabIndex = 2;
            this.TitleBarMinButton.TabStop = false;
            this.TitleBarMinButton.Text = "-";
            this.TitleBarMinButton.UseVisualStyleBackColor = true;
            this.TitleBarMinButton.Click += new System.EventHandler(this.TitleBarMinButton_Click);
            // 
            // TitleBarCloseButton
            // 
            this.TitleBarCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBarCloseButton.FlatAppearance.BorderSize = 0;
            this.TitleBarCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TitleBarCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.TitleBarCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBarCloseButton.ForeColor = System.Drawing.Color.White;
            this.TitleBarCloseButton.Location = new System.Drawing.Point(975, 0);
            this.TitleBarCloseButton.Name = "TitleBarCloseButton";
            this.TitleBarCloseButton.Size = new System.Drawing.Size(25, 25);
            this.TitleBarCloseButton.TabIndex = 1;
            this.TitleBarCloseButton.TabStop = false;
            this.TitleBarCloseButton.Text = "X";
            this.TitleBarCloseButton.UseVisualStyleBackColor = true;
            this.TitleBarCloseButton.Click += new System.EventHandler(this.TitleBarCloseButton_Click);
            // 
            // TitleBarTitle
            // 
            this.TitleBarTitle.AutoSize = true;
            this.TitleBarTitle.ForeColor = System.Drawing.Color.White;
            this.TitleBarTitle.Location = new System.Drawing.Point(10, 5);
            this.TitleBarTitle.Name = "TitleBarTitle";
            this.TitleBarTitle.Size = new System.Drawing.Size(239, 13);
            this.TitleBarTitle.TabIndex = 0;
            this.TitleBarTitle.Text = "Better Discord: Message Logger V2 Backup Tool";
            // 
            // NavPanelSettingsButton
            // 
            this.NavPanelSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NavPanelSettingsButton.Enabled = false;
            this.NavPanelSettingsButton.FlatAppearance.BorderSize = 0;
            this.NavPanelSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavPanelSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NavPanelSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavPanelSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavPanelSettingsButton.ForeColor = System.Drawing.Color.White;
            this.NavPanelSettingsButton.Location = new System.Drawing.Point(0, 575);
            this.NavPanelSettingsButton.Name = "NavPanelSettingsButton";
            this.NavPanelSettingsButton.Size = new System.Drawing.Size(105, 50);
            this.NavPanelSettingsButton.TabIndex = 2;
            this.NavPanelSettingsButton.TabStop = false;
            this.NavPanelSettingsButton.Text = "Settings  ⚙";
            this.NavPanelSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NavPanelSettingsButton.UseVisualStyleBackColor = true;
            this.NavPanelSettingsButton.Click += new System.EventHandler(this.NavPanelSettingsButton_Click);
            // 
            // InitTimer
            // 
            this.InitTimer.Enabled = true;
            this.InitTimer.Interval = 1;
            this.InitTimer.Tick += new System.EventHandler(this.InitTimer_Tick);
            // 
            // InitLoadLabel
            // 
            this.InitLoadLabel.AutoSize = true;
            this.InitLoadLabel.Location = new System.Drawing.Point(424, 312);
            this.InitLoadLabel.Name = "InitLoadLabel";
            this.InitLoadLabel.Size = new System.Drawing.Size(152, 13);
            this.InitLoadLabel.TabIndex = 1;
            this.InitLoadLabel.Text = "Loading settings, please wait...";
            this.InitLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InitLoadLabel.Visible = false;
            // 
            // SettingTitleLabel
            // 
            this.SettingTitleLabel.AutoSize = true;
            this.SettingTitleLabel.Enabled = false;
            this.SettingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingTitleLabel.Location = new System.Drawing.Point(40, 40);
            this.SettingTitleLabel.Name = "SettingTitleLabel";
            this.SettingTitleLabel.Size = new System.Drawing.Size(68, 20);
            this.SettingTitleLabel.TabIndex = 2;
            this.SettingTitleLabel.Text = "Settings";
            this.SettingTitleLabel.Visible = false;
            // 
            // SettingsBDLocLabel
            // 
            this.SettingsBDLocLabel.AutoSize = true;
            this.SettingsBDLocLabel.Enabled = false;
            this.SettingsBDLocLabel.Location = new System.Drawing.Point(40, 70);
            this.SettingsBDLocLabel.Name = "SettingsBDLocLabel";
            this.SettingsBDLocLabel.Size = new System.Drawing.Size(111, 13);
            this.SettingsBDLocLabel.TabIndex = 3;
            this.SettingsBDLocLabel.Text = "BetterDiscord location";
            this.SettingsBDLocLabel.Visible = false;
            // 
            // SettingsBDLocTextBox
            // 
            this.SettingsBDLocTextBox.Enabled = false;
            this.SettingsBDLocTextBox.Location = new System.Drawing.Point(40, 90);
            this.SettingsBDLocTextBox.Name = "SettingsBDLocTextBox";
            this.SettingsBDLocTextBox.Size = new System.Drawing.Size(250, 20);
            this.SettingsBDLocTextBox.TabIndex = 4;
            this.SettingsBDLocTextBox.TabStop = false;
            this.SettingsBDLocTextBox.Visible = false;
            // 
            // SettingsBDLocOpenFExButt
            // 
            this.SettingsBDLocOpenFExButt.Enabled = false;
            this.SettingsBDLocOpenFExButt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SettingsBDLocOpenFExButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBDLocOpenFExButt.ForeColor = System.Drawing.Color.Black;
            this.SettingsBDLocOpenFExButt.Location = new System.Drawing.Point(290, 90);
            this.SettingsBDLocOpenFExButt.Name = "SettingsBDLocOpenFExButt";
            this.SettingsBDLocOpenFExButt.Size = new System.Drawing.Size(25, 20);
            this.SettingsBDLocOpenFExButt.TabIndex = 5;
            this.SettingsBDLocOpenFExButt.TabStop = false;
            this.SettingsBDLocOpenFExButt.Text = "...";
            this.SettingsBDLocOpenFExButt.UseVisualStyleBackColor = true;
            this.SettingsBDLocOpenFExButt.Visible = false;
            this.SettingsBDLocOpenFExButt.Click += new System.EventHandler(this.SettingsBDLocOpenFExButt_Click);
            // 
            // SettingsFEx
            // 
            this.SettingsFEx.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SettingsBackBasePathLabel
            // 
            this.SettingsBackBasePathLabel.AutoSize = true;
            this.SettingsBackBasePathLabel.Enabled = false;
            this.SettingsBackBasePathLabel.Location = new System.Drawing.Point(40, 120);
            this.SettingsBackBasePathLabel.Name = "SettingsBackBasePathLabel";
            this.SettingsBackBasePathLabel.Size = new System.Drawing.Size(108, 13);
            this.SettingsBackBasePathLabel.TabIndex = 6;
            this.SettingsBackBasePathLabel.Text = "Backup root directory";
            this.SettingsBackBasePathLabel.Visible = false;
            // 
            // SettingsBackBasePathTextBox
            // 
            this.SettingsBackBasePathTextBox.Enabled = false;
            this.SettingsBackBasePathTextBox.Location = new System.Drawing.Point(40, 140);
            this.SettingsBackBasePathTextBox.Name = "SettingsBackBasePathTextBox";
            this.SettingsBackBasePathTextBox.Size = new System.Drawing.Size(250, 20);
            this.SettingsBackBasePathTextBox.TabIndex = 7;
            this.SettingsBackBasePathTextBox.TabStop = false;
            this.SettingsBackBasePathTextBox.Visible = false;
            // 
            // SettingsBackBasePathFExButt
            // 
            this.SettingsBackBasePathFExButt.Enabled = false;
            this.SettingsBackBasePathFExButt.Location = new System.Drawing.Point(290, 140);
            this.SettingsBackBasePathFExButt.Name = "SettingsBackBasePathFExButt";
            this.SettingsBackBasePathFExButt.Size = new System.Drawing.Size(25, 20);
            this.SettingsBackBasePathFExButt.TabIndex = 8;
            this.SettingsBackBasePathFExButt.Text = "...";
            this.SettingsBackBasePathFExButt.UseVisualStyleBackColor = true;
            this.SettingsBackBasePathFExButt.Visible = false;
            this.SettingsBackBasePathFExButt.Click += new System.EventHandler(this.SettingsBackBasePathFExButt_Click);
            // 
            // SettingsBackFolderLabel
            // 
            this.SettingsBackFolderLabel.AutoSize = true;
            this.SettingsBackFolderLabel.Enabled = false;
            this.SettingsBackFolderLabel.Location = new System.Drawing.Point(350, 120);
            this.SettingsBackFolderLabel.Name = "SettingsBackFolderLabel";
            this.SettingsBackFolderLabel.Size = new System.Drawing.Size(102, 13);
            this.SettingsBackFolderLabel.TabIndex = 9;
            this.SettingsBackFolderLabel.Text = "Backup folder name";
            this.SettingsBackFolderLabel.Visible = false;
            // 
            // SettingsBackFolderTexBox
            // 
            this.SettingsBackFolderTexBox.Enabled = false;
            this.SettingsBackFolderTexBox.Location = new System.Drawing.Point(350, 140);
            this.SettingsBackFolderTexBox.Name = "SettingsBackFolderTexBox";
            this.SettingsBackFolderTexBox.Size = new System.Drawing.Size(150, 20);
            this.SettingsBackFolderTexBox.TabIndex = 10;
            this.SettingsBackFolderTexBox.TabStop = false;
            this.SettingsBackFolderTexBox.Visible = false;
            // 
            // SettingsBackupMethodComboBox
            // 
            this.SettingsBackupMethodComboBox.Enabled = false;
            this.SettingsBackupMethodComboBox.FormattingEnabled = true;
            this.SettingsBackupMethodComboBox.Items.AddRange(new object[] {
            "Single File",
            "Multi File"});
            this.SettingsBackupMethodComboBox.Location = new System.Drawing.Point(40, 190);
            this.SettingsBackupMethodComboBox.Name = "SettingsBackupMethodComboBox";
            this.SettingsBackupMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.SettingsBackupMethodComboBox.TabIndex = 11;
            this.SettingsBackupMethodComboBox.TabStop = false;
            this.SettingsBackupMethodComboBox.Visible = false;
            this.SettingsBackupMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingsBackupMethodComboBox_SelectedIndexChanged);
            // 
            // SettingsBackupMethodlabel
            // 
            this.SettingsBackupMethodlabel.AutoSize = true;
            this.SettingsBackupMethodlabel.Enabled = false;
            this.SettingsBackupMethodlabel.Location = new System.Drawing.Point(40, 170);
            this.SettingsBackupMethodlabel.Name = "SettingsBackupMethodlabel";
            this.SettingsBackupMethodlabel.Size = new System.Drawing.Size(83, 13);
            this.SettingsBackupMethodlabel.TabIndex = 12;
            this.SettingsBackupMethodlabel.Text = "Backup Method";
            this.SettingsBackupMethodlabel.Visible = false;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NavPanel.Controls.Add(this.NavPanelMoveButton);
            this.NavPanel.Controls.Add(this.NavPanelSettingsButton);
            this.NavPanel.Location = new System.Drawing.Point(-75, 25);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(100, 625);
            this.NavPanel.TabIndex = 13;
            // 
            // NavPanelMoveButton
            // 
            this.NavPanelMoveButton.FlatAppearance.BorderSize = 0;
            this.NavPanelMoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NavPanelMoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NavPanelMoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavPanelMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavPanelMoveButton.ForeColor = System.Drawing.Color.White;
            this.NavPanelMoveButton.Location = new System.Drawing.Point(0, 0);
            this.NavPanelMoveButton.Name = "NavPanelMoveButton";
            this.NavPanelMoveButton.Size = new System.Drawing.Size(105, 25);
            this.NavPanelMoveButton.TabIndex = 3;
            this.NavPanelMoveButton.TabStop = false;
            this.NavPanelMoveButton.Text = "Navigation     >";
            this.NavPanelMoveButton.UseVisualStyleBackColor = true;
            this.NavPanelMoveButton.Click += new System.EventHandler(this.NavPanelMoveButton_Click);
            // 
            // SettingsAppVer
            // 
            this.SettingsAppVer.AutoSize = true;
            this.SettingsAppVer.Enabled = false;
            this.SettingsAppVer.Location = new System.Drawing.Point(40, 625);
            this.SettingsAppVer.Name = "SettingsAppVer";
            this.SettingsAppVer.Size = new System.Drawing.Size(221, 13);
            this.SettingsAppVer.TabIndex = 14;
            this.SettingsAppVer.Text = "Message Logger V2 Backup Tool version 1.0";
            this.SettingsAppVer.Visible = false;
            // 
            // BackUpSectionLabel
            // 
            this.BackUpSectionLabel.AutoSize = true;
            this.BackUpSectionLabel.Enabled = false;
            this.BackUpSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUpSectionLabel.Location = new System.Drawing.Point(40, 40);
            this.BackUpSectionLabel.Name = "BackUpSectionLabel";
            this.BackUpSectionLabel.Size = new System.Drawing.Size(63, 20);
            this.BackUpSectionLabel.TabIndex = 15;
            this.BackUpSectionLabel.Text = "Backup";
            this.BackUpSectionLabel.Visible = false;
            // 
            // BackUpSectionCreateBackupButton
            // 
            this.BackUpSectionCreateBackupButton.Enabled = false;
            this.BackUpSectionCreateBackupButton.Location = new System.Drawing.Point(40, 70);
            this.BackUpSectionCreateBackupButton.Name = "BackUpSectionCreateBackupButton";
            this.BackUpSectionCreateBackupButton.Size = new System.Drawing.Size(200, 25);
            this.BackUpSectionCreateBackupButton.TabIndex = 16;
            this.BackUpSectionCreateBackupButton.TabStop = false;
            this.BackUpSectionCreateBackupButton.Text = "$MODE backup";
            this.BackUpSectionCreateBackupButton.UseVisualStyleBackColor = true;
            this.BackUpSectionCreateBackupButton.Visible = false;
            // 
            // SettingsShowBackFolder
            // 
            this.SettingsShowBackFolder.Enabled = false;
            this.SettingsShowBackFolder.Location = new System.Drawing.Point(350, 90);
            this.SettingsShowBackFolder.Name = "SettingsShowBackFolder";
            this.SettingsShowBackFolder.Size = new System.Drawing.Size(150, 23);
            this.SettingsShowBackFolder.TabIndex = 17;
            this.SettingsShowBackFolder.TabStop = false;
            this.SettingsShowBackFolder.Text = "Show Backup Folder";
            this.SettingsShowBackFolder.UseVisualStyleBackColor = true;
            this.SettingsShowBackFolder.Visible = false;
            this.SettingsShowBackFolder.Click += new System.EventHandler(this.SettingsShowBackFolder_Click);
            // 
            // InitLoadFailResetButton
            // 
            this.InitLoadFailResetButton.Enabled = false;
            this.InitLoadFailResetButton.Location = new System.Drawing.Point(424, 329);
            this.InitLoadFailResetButton.Name = "InitLoadFailResetButton";
            this.InitLoadFailResetButton.Size = new System.Drawing.Size(152, 23);
            this.InitLoadFailResetButton.TabIndex = 18;
            this.InitLoadFailResetButton.TabStop = false;
            this.InitLoadFailResetButton.Text = "Reset Settings";
            this.InitLoadFailResetButton.UseVisualStyleBackColor = true;
            this.InitLoadFailResetButton.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.InitLoadFailResetButton);
            this.Controls.Add(this.SettingsShowBackFolder);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.BackUpSectionCreateBackupButton);
            this.Controls.Add(this.BackUpSectionLabel);
            this.Controls.Add(this.SettingsAppVer);
            this.Controls.Add(this.SettingsBackupMethodlabel);
            this.Controls.Add(this.SettingsBackupMethodComboBox);
            this.Controls.Add(this.SettingsBackFolderTexBox);
            this.Controls.Add(this.SettingsBackFolderLabel);
            this.Controls.Add(this.SettingsBackBasePathFExButt);
            this.Controls.Add(this.SettingsBackBasePathTextBox);
            this.Controls.Add(this.SettingsBackBasePathLabel);
            this.Controls.Add(this.SettingsBDLocOpenFExButt);
            this.Controls.Add(this.SettingsBDLocTextBox);
            this.Controls.Add(this.SettingsBDLocLabel);
            this.Controls.Add(this.SettingTitleLabel);
            this.Controls.Add(this.InitLoadLabel);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetterDiscord | Message Logger V2 Backup Tool";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.NavPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button TitleBarCloseButton;
        private System.Windows.Forms.Label TitleBarTitle;
        private System.Windows.Forms.Button TitleBarMinButton;
        private System.Windows.Forms.Timer InitTimer;
        private System.Windows.Forms.Label InitLoadLabel;
        private System.Windows.Forms.Button NavPanelSettingsButton;
        private System.Windows.Forms.Label SettingTitleLabel;
        private System.Windows.Forms.Label SettingsBDLocLabel;
        private System.Windows.Forms.TextBox SettingsBDLocTextBox;
        private System.Windows.Forms.Button SettingsBDLocOpenFExButt;
        private System.Windows.Forms.FolderBrowserDialog SettingsFEx;
        private System.Windows.Forms.Label SettingsBackBasePathLabel;
        private System.Windows.Forms.TextBox SettingsBackBasePathTextBox;
        private System.Windows.Forms.Button SettingsBackBasePathFExButt;
        private System.Windows.Forms.Label SettingsBackFolderLabel;
        private System.Windows.Forms.TextBox SettingsBackFolderTexBox;
        private System.Windows.Forms.ComboBox SettingsBackupMethodComboBox;
        private System.Windows.Forms.Label SettingsBackupMethodlabel;
        private System.Windows.Forms.Button TitlebarDBG_Cmd;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Label SettingsAppVer;
        private System.Windows.Forms.Button NavPanelMoveButton;
        private System.Windows.Forms.Label BackUpSectionLabel;
        private System.Windows.Forms.Button BackUpSectionCreateBackupButton;
        private System.Windows.Forms.Button SettingsShowBackFolder;
        private System.Windows.Forms.Button InitLoadFailResetButton;
    }
}

