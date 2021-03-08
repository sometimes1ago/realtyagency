namespace RealtyAgency
{
    partial class Rieltor
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
            this.CabinetTabs = new System.Windows.Forms.TabControl();
            this.UserQueries = new System.Windows.Forms.TabPage();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SuggAcceptGroup = new System.Windows.Forms.GroupBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuggNumberLabel = new System.Windows.Forms.Label();
            this.UsersQueriesData = new System.Windows.Forms.DataGridView();
            this.CompletedDeals = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CompletedDealsData = new System.Windows.Forms.DataGridView();
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.UsersQueriesOpt = new System.Windows.Forms.ComboBox();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.CabinetTabs.SuspendLayout();
            this.UserQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuggAcceptGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersQueriesData)).BeginInit();
            this.CompletedDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedDealsData)).BeginInit();
            this.SuspendLayout();
            // 
            // CabinetTabs
            // 
            this.CabinetTabs.Controls.Add(this.UserQueries);
            this.CabinetTabs.Controls.Add(this.CompletedDeals);
            this.CabinetTabs.Location = new System.Drawing.Point(23, 66);
            this.CabinetTabs.Name = "CabinetTabs";
            this.CabinetTabs.SelectedIndex = 0;
            this.CabinetTabs.Size = new System.Drawing.Size(754, 373);
            this.CabinetTabs.TabIndex = 27;
            // 
            // UserQueries
            // 
            this.UserQueries.Controls.Add(this.IncomeLabel);
            this.UserQueries.Controls.Add(this.Logo);
            this.UserQueries.Controls.Add(this.SuggAcceptGroup);
            this.UserQueries.Controls.Add(this.UsersQueriesData);
            this.UserQueries.Location = new System.Drawing.Point(4, 22);
            this.UserQueries.Name = "UserQueries";
            this.UserQueries.Padding = new System.Windows.Forms.Padding(3);
            this.UserQueries.Size = new System.Drawing.Size(746, 347);
            this.UserQueries.TabIndex = 0;
            this.UserQueries.Text = "Заявки пользователей";
            this.UserQueries.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(671, 298);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(57, 34);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 28;
            this.Logo.TabStop = false;
            // 
            // SuggAcceptGroup
            // 
            this.SuggAcceptGroup.Controls.Add(this.UsersQueriesOpt);
            this.SuggAcceptGroup.Controls.Add(this.AcceptButton);
            this.SuggAcceptGroup.Controls.Add(this.SuggNumberLabel);
            this.SuggAcceptGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SuggAcceptGroup.Location = new System.Drawing.Point(14, 239);
            this.SuggAcceptGroup.Name = "SuggAcceptGroup";
            this.SuggAcceptGroup.Size = new System.Drawing.Size(456, 88);
            this.SuggAcceptGroup.TabIndex = 1;
            this.SuggAcceptGroup.TabStop = false;
            this.SuggAcceptGroup.Text = "Принять заявку";
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.AcceptButton.FlatAppearance.BorderSize = 0;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(338, 33);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(99, 27);
            this.AcceptButton.TabIndex = 10;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // SuggNumberLabel
            // 
            this.SuggNumberLabel.AutoSize = true;
            this.SuggNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SuggNumberLabel.Location = new System.Drawing.Point(17, 41);
            this.SuggNumberLabel.Name = "SuggNumberLabel";
            this.SuggNumberLabel.Size = new System.Drawing.Size(95, 13);
            this.SuggNumberLabel.TabIndex = 0;
            this.SuggNumberLabel.Text = "Выберите заявку";
            // 
            // UsersQueriesData
            // 
            this.UsersQueriesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersQueriesData.Location = new System.Drawing.Point(14, 25);
            this.UsersQueriesData.Name = "UsersQueriesData";
            this.UsersQueriesData.Size = new System.Drawing.Size(714, 186);
            this.UsersQueriesData.TabIndex = 0;
            // 
            // CompletedDeals
            // 
            this.CompletedDeals.Controls.Add(this.pictureBox1);
            this.CompletedDeals.Controls.Add(this.CompletedDealsData);
            this.CompletedDeals.Location = new System.Drawing.Point(4, 22);
            this.CompletedDeals.Name = "CompletedDeals";
            this.CompletedDeals.Padding = new System.Windows.Forms.Padding(3);
            this.CompletedDeals.Size = new System.Drawing.Size(746, 347);
            this.CompletedDeals.TabIndex = 1;
            this.CompletedDeals.Text = "Завершенные сделки";
            this.CompletedDeals.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealtyAgency.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(641, 288);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // CompletedDealsData
            // 
            this.CompletedDealsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedDealsData.Location = new System.Drawing.Point(16, 22);
            this.CompletedDealsData.Name = "CompletedDealsData";
            this.CompletedDealsData.Size = new System.Drawing.Size(714, 224);
            this.CompletedDealsData.TabIndex = 2;
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GreetingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GreetingsLabel.Location = new System.Drawing.Point(22, 22);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(205, 29);
            this.GreetingsLabel.TabIndex = 26;
            this.GreetingsLabel.Text = "Личный кабинет";
            // 
            // LogoutLink
            // 
            this.LogoutLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LogoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogoutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.Location = new System.Drawing.Point(729, 32);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(50, 15);
            this.LogoutLink.TabIndex = 28;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // UsersQueriesOpt
            // 
            this.UsersQueriesOpt.FormattingEnabled = true;
            this.UsersQueriesOpt.Location = new System.Drawing.Point(128, 38);
            this.UsersQueriesOpt.Name = "UsersQueriesOpt";
            this.UsersQueriesOpt.Size = new System.Drawing.Size(191, 21);
            this.UsersQueriesOpt.TabIndex = 11;
            this.UsersQueriesOpt.SelectedIndexChanged += new System.EventHandler(this.UsersQueriesOpt_SelectedIndexChanged);
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.IncomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.IncomeLabel.Location = new System.Drawing.Point(486, 246);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(167, 52);
            this.IncomeLabel.TabIndex = 30;
            this.IncomeLabel.Text = "Ваша потенциальная прибыль: ";
            // 
            // Rieltor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.CabinetTabs);
            this.Controls.Add(this.GreetingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Rieltor";
            this.Text = "Агенство недвижимости - риелтор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rieltor_FormClosing);
            this.Load += new System.EventHandler(this.Rieltor_Load);
            this.CabinetTabs.ResumeLayout(false);
            this.UserQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SuggAcceptGroup.ResumeLayout(false);
            this.SuggAcceptGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersQueriesData)).EndInit();
            this.CompletedDeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedDealsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl CabinetTabs;
        private System.Windows.Forms.TabPage UserQueries;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.GroupBox SuggAcceptGroup;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label SuggNumberLabel;
        private System.Windows.Forms.DataGridView UsersQueriesData;
        private System.Windows.Forms.TabPage CompletedDeals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView CompletedDealsData;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.ComboBox UsersQueriesOpt;
        private System.Windows.Forms.Label IncomeLabel;
    }
}