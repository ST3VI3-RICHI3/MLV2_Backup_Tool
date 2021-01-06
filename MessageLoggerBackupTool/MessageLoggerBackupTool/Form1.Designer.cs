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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.TitleBarTitle = new System.Windows.Forms.Label();
            this.TitleBarCloseButton = new System.Windows.Forms.Button();
            this.TitleBarMinButton = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TitleBar.Controls.Add(this.TitleBarMinButton);
            this.TitleBar.Controls.Add(this.TitleBarCloseButton);
            this.TitleBar.Controls.Add(this.TitleBarTitle);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1000, 25);
            this.TitleBar.TabIndex = 0;
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
            // TitleBarCloseButton
            // 
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
            // TitleBarMinButton
            // 
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetterDiscord | Message Logger V2 Backup Tool";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button TitleBarCloseButton;
        private System.Windows.Forms.Label TitleBarTitle;
        private System.Windows.Forms.Button TitleBarMinButton;
    }
}

