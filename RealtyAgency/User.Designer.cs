namespace RealtyAgency
{
    partial class User
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
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.SelectActionLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.CabinetButton = new System.Windows.Forms.Button();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.ShowRieltorsButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GreetingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GreetingsLabel.Location = new System.Drawing.Point(185, 40);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(423, 120);
            this.GreetingsLabel.TabIndex = 2;
            this.GreetingsLabel.Text = "Здравствуйте! ";
            this.GreetingsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectActionLabel
            // 
            this.SelectActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SelectActionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SelectActionLabel.Location = new System.Drawing.Point(292, 160);
            this.SelectActionLabel.Name = "SelectActionLabel";
            this.SelectActionLabel.Size = new System.Drawing.Size(209, 23);
            this.SelectActionLabel.TabIndex = 4;
            this.SelectActionLabel.Text = "Что вы хотите сделать?";
            this.SelectActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.BuyButton.FlatAppearance.BorderSize = 0;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BuyButton.ForeColor = System.Drawing.Color.White;
            this.BuyButton.Location = new System.Drawing.Point(62, 217);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(140, 51);
            this.BuyButton.TabIndex = 8;
            this.BuyButton.Text = "Купить недвижимость";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.SellButton.FlatAppearance.BorderSize = 0;
            this.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SellButton.ForeColor = System.Drawing.Color.White;
            this.SellButton.Location = new System.Drawing.Point(236, 217);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(140, 51);
            this.SellButton.TabIndex = 9;
            this.SellButton.Text = "Продать недвижимость";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // CabinetButton
            // 
            this.CabinetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.CabinetButton.FlatAppearance.BorderSize = 0;
            this.CabinetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CabinetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.CabinetButton.ForeColor = System.Drawing.Color.White;
            this.CabinetButton.Location = new System.Drawing.Point(584, 217);
            this.CabinetButton.Name = "CabinetButton";
            this.CabinetButton.Size = new System.Drawing.Size(140, 51);
            this.CabinetButton.TabIndex = 10;
            this.CabinetButton.Text = "Перейти в личный кабинет";
            this.CabinetButton.UseVisualStyleBackColor = false;
            this.CabinetButton.Click += new System.EventHandler(this.CabinetButton_Click);
            // 
            // LogoutLink
            // 
            this.LogoutLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LogoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogoutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.Location = new System.Drawing.Point(369, 315);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(55, 17);
            this.LogoutLink.TabIndex = 11;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // ShowRieltorsButton
            // 
            this.ShowRieltorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.ShowRieltorsButton.FlatAppearance.BorderSize = 0;
            this.ShowRieltorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRieltorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ShowRieltorsButton.ForeColor = System.Drawing.Color.White;
            this.ShowRieltorsButton.Location = new System.Drawing.Point(410, 217);
            this.ShowRieltorsButton.Name = "ShowRieltorsButton";
            this.ShowRieltorsButton.Size = new System.Drawing.Size(140, 51);
            this.ShowRieltorsButton.TabIndex = 13;
            this.ShowRieltorsButton.Text = "Посмотреть риелторов";
            this.ShowRieltorsButton.UseVisualStyleBackColor = false;
            this.ShowRieltorsButton.Click += new System.EventHandler(this.ShowRieltorsButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(353, 371);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(87, 44);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowRieltorsButton);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.CabinetButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.SelectActionLabel);
            this.Controls.Add(this.GreetingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство недвижимости - Пользователь";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.Label SelectActionLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button CabinetButton;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button ShowRieltorsButton;
    }
}