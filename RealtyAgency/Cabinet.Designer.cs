namespace RealtyAgency
{
    partial class Cabinet
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
            this.GoBack = new System.Windows.Forms.LinkLabel();
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.CabinetTabs = new System.Windows.Forms.TabControl();
            this.UserSuggestions = new System.Windows.Forms.TabPage();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SuggestionDeletingGroup = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuggNumInput = new System.Windows.Forms.TextBox();
            this.SuggNumberLabel = new System.Windows.Forms.Label();
            this.SuggestionsData = new System.Windows.Forms.DataGridView();
            this.UserQueries = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QueryDeletingGroup = new System.Windows.Forms.GroupBox();
            this.DeleteQueryButton = new System.Windows.Forms.Button();
            this.QueryNumInput = new System.Windows.Forms.TextBox();
            this.QueryNumLabel = new System.Windows.Forms.Label();
            this.UserQueriesData = new System.Windows.Forms.DataGridView();
            this.UserDeals = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteAccLink = new System.Windows.Forms.LinkLabel();
            this.DropAccTip = new System.Windows.Forms.Label();
            this.CabinetTabs.SuspendLayout();
            this.UserSuggestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuggestionDeletingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuggestionsData)).BeginInit();
            this.UserQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.QueryDeletingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserQueriesData)).BeginInit();
            this.UserDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBack
            // 
            this.GoBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.AutoSize = true;
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GoBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GoBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.Location = new System.Drawing.Point(15, 27);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(48, 15);
            this.GoBack.TabIndex = 24;
            this.GoBack.TabStop = true;
            this.GoBack.Text = "Назад";
            this.GoBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack_LinkClicked);
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GreetingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GreetingsLabel.Location = new System.Drawing.Point(71, 22);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(205, 29);
            this.GreetingsLabel.TabIndex = 3;
            this.GreetingsLabel.Text = "Личный кабинет";
            // 
            // CabinetTabs
            // 
            this.CabinetTabs.Controls.Add(this.UserSuggestions);
            this.CabinetTabs.Controls.Add(this.UserQueries);
            this.CabinetTabs.Controls.Add(this.UserDeals);
            this.CabinetTabs.Location = new System.Drawing.Point(18, 76);
            this.CabinetTabs.Name = "CabinetTabs";
            this.CabinetTabs.SelectedIndex = 0;
            this.CabinetTabs.Size = new System.Drawing.Size(754, 373);
            this.CabinetTabs.TabIndex = 25;
            // 
            // UserSuggestions
            // 
            this.UserSuggestions.Controls.Add(this.Logo);
            this.UserSuggestions.Controls.Add(this.SuggestionDeletingGroup);
            this.UserSuggestions.Controls.Add(this.SuggestionsData);
            this.UserSuggestions.Location = new System.Drawing.Point(4, 22);
            this.UserSuggestions.Name = "UserSuggestions";
            this.UserSuggestions.Padding = new System.Windows.Forms.Padding(3);
            this.UserSuggestions.Size = new System.Drawing.Size(746, 347);
            this.UserSuggestions.TabIndex = 0;
            this.UserSuggestions.Text = "Мои предложения";
            this.UserSuggestions.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(641, 288);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(87, 44);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 28;
            this.Logo.TabStop = false;
            // 
            // SuggestionDeletingGroup
            // 
            this.SuggestionDeletingGroup.Controls.Add(this.DeleteButton);
            this.SuggestionDeletingGroup.Controls.Add(this.SuggNumInput);
            this.SuggestionDeletingGroup.Controls.Add(this.SuggNumberLabel);
            this.SuggestionDeletingGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SuggestionDeletingGroup.Location = new System.Drawing.Point(14, 239);
            this.SuggestionDeletingGroup.Name = "SuggestionDeletingGroup";
            this.SuggestionDeletingGroup.Size = new System.Drawing.Size(391, 88);
            this.SuggestionDeletingGroup.TabIndex = 1;
            this.SuggestionDeletingGroup.TabStop = false;
            this.SuggestionDeletingGroup.Text = "Удалить предложение";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(247, 36);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 27);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SuggNumInput
            // 
            this.SuggNumInput.Location = new System.Drawing.Point(118, 41);
            this.SuggNumInput.Name = "SuggNumInput";
            this.SuggNumInput.Size = new System.Drawing.Size(100, 20);
            this.SuggNumInput.TabIndex = 1;
            // 
            // SuggNumberLabel
            // 
            this.SuggNumberLabel.AutoSize = true;
            this.SuggNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SuggNumberLabel.Location = new System.Drawing.Point(17, 41);
            this.SuggNumberLabel.Name = "SuggNumberLabel";
            this.SuggNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.SuggNumberLabel.TabIndex = 0;
            this.SuggNumberLabel.Text = "Введите номер";
            // 
            // SuggestionsData
            // 
            this.SuggestionsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuggestionsData.Location = new System.Drawing.Point(14, 25);
            this.SuggestionsData.Name = "SuggestionsData";
            this.SuggestionsData.Size = new System.Drawing.Size(714, 186);
            this.SuggestionsData.TabIndex = 0;
            // 
            // UserQueries
            // 
            this.UserQueries.Controls.Add(this.pictureBox1);
            this.UserQueries.Controls.Add(this.QueryDeletingGroup);
            this.UserQueries.Controls.Add(this.UserQueriesData);
            this.UserQueries.Location = new System.Drawing.Point(4, 22);
            this.UserQueries.Name = "UserQueries";
            this.UserQueries.Padding = new System.Windows.Forms.Padding(3);
            this.UserQueries.Size = new System.Drawing.Size(746, 347);
            this.UserQueries.TabIndex = 1;
            this.UserQueries.Text = "Мои заявки";
            this.UserQueries.UseVisualStyleBackColor = true;
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
            // QueryDeletingGroup
            // 
            this.QueryDeletingGroup.Controls.Add(this.DeleteQueryButton);
            this.QueryDeletingGroup.Controls.Add(this.QueryNumInput);
            this.QueryDeletingGroup.Controls.Add(this.QueryNumLabel);
            this.QueryDeletingGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.QueryDeletingGroup.Location = new System.Drawing.Point(16, 236);
            this.QueryDeletingGroup.Name = "QueryDeletingGroup";
            this.QueryDeletingGroup.Size = new System.Drawing.Size(391, 88);
            this.QueryDeletingGroup.TabIndex = 3;
            this.QueryDeletingGroup.TabStop = false;
            this.QueryDeletingGroup.Text = "Удалить заявку";
            // 
            // DeleteQueryButton
            // 
            this.DeleteQueryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.DeleteQueryButton.FlatAppearance.BorderSize = 0;
            this.DeleteQueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DeleteQueryButton.ForeColor = System.Drawing.Color.White;
            this.DeleteQueryButton.Location = new System.Drawing.Point(247, 36);
            this.DeleteQueryButton.Name = "DeleteQueryButton";
            this.DeleteQueryButton.Size = new System.Drawing.Size(99, 27);
            this.DeleteQueryButton.TabIndex = 10;
            this.DeleteQueryButton.Text = "Удалить";
            this.DeleteQueryButton.UseVisualStyleBackColor = false;
            this.DeleteQueryButton.Click += new System.EventHandler(this.DeleteQueryButton_Click);
            // 
            // QueryNumInput
            // 
            this.QueryNumInput.Location = new System.Drawing.Point(118, 41);
            this.QueryNumInput.Name = "QueryNumInput";
            this.QueryNumInput.Size = new System.Drawing.Size(100, 20);
            this.QueryNumInput.TabIndex = 1;
            // 
            // QueryNumLabel
            // 
            this.QueryNumLabel.AutoSize = true;
            this.QueryNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.QueryNumLabel.Location = new System.Drawing.Point(17, 41);
            this.QueryNumLabel.Name = "QueryNumLabel";
            this.QueryNumLabel.Size = new System.Drawing.Size(84, 13);
            this.QueryNumLabel.TabIndex = 0;
            this.QueryNumLabel.Text = "Введите номер";
            // 
            // UserQueriesData
            // 
            this.UserQueriesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserQueriesData.Location = new System.Drawing.Point(16, 22);
            this.UserQueriesData.Name = "UserQueriesData";
            this.UserQueriesData.Size = new System.Drawing.Size(714, 186);
            this.UserQueriesData.TabIndex = 2;
            // 
            // UserDeals
            // 
            this.UserDeals.Controls.Add(this.pictureBox2);
            this.UserDeals.Controls.Add(this.dataGridView1);
            this.UserDeals.Location = new System.Drawing.Point(4, 22);
            this.UserDeals.Name = "UserDeals";
            this.UserDeals.Size = new System.Drawing.Size(746, 347);
            this.UserDeals.TabIndex = 2;
            this.UserDeals.Text = "Мои сделки";
            this.UserDeals.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RealtyAgency.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(681, 306);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 270);
            this.dataGridView1.TabIndex = 14;
            // 
            // DeleteAccLink
            // 
            this.DeleteAccLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.DeleteAccLink.AutoSize = true;
            this.DeleteAccLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DeleteAccLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.DeleteAccLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.DeleteAccLink.Location = new System.Drawing.Point(600, 36);
            this.DeleteAccLink.Name = "DeleteAccLink";
            this.DeleteAccLink.Size = new System.Drawing.Size(168, 15);
            this.DeleteAccLink.TabIndex = 26;
            this.DeleteAccLink.TabStop = true;
            this.DeleteAccLink.Text = "удалить учетную запись";
            this.DeleteAccLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.DeleteAccLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteAccLink_LinkClicked);
            // 
            // DropAccTip
            // 
            this.DropAccTip.AutoSize = true;
            this.DropAccTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.DropAccTip.Location = new System.Drawing.Point(530, 39);
            this.DropAccTip.Name = "DropAccTip";
            this.DropAccTip.Size = new System.Drawing.Size(64, 13);
            this.DropAccTip.TabIndex = 27;
            this.DropAccTip.Text = "Вы можете";
            // 
            // Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DropAccTip);
            this.Controls.Add(this.DeleteAccLink);
            this.Controls.Add(this.CabinetTabs);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.GreetingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство недвижимости - личный кабинет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cabinet_FormClosing);
            this.Load += new System.EventHandler(this.Cabinet_Load);
            this.CabinetTabs.ResumeLayout(false);
            this.UserSuggestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SuggestionDeletingGroup.ResumeLayout(false);
            this.SuggestionDeletingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuggestionsData)).EndInit();
            this.UserQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.QueryDeletingGroup.ResumeLayout(false);
            this.QueryDeletingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserQueriesData)).EndInit();
            this.UserDeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel GoBack;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.TabControl CabinetTabs;
        private System.Windows.Forms.TabPage UserSuggestions;
        private System.Windows.Forms.GroupBox SuggestionDeletingGroup;
        private System.Windows.Forms.TextBox SuggNumInput;
        private System.Windows.Forms.Label SuggNumberLabel;
        private System.Windows.Forms.DataGridView SuggestionsData;
        private System.Windows.Forms.TabPage UserQueries;
        private System.Windows.Forms.LinkLabel DeleteAccLink;
        private System.Windows.Forms.Label DropAccTip;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TabPage UserDeals;
        private System.Windows.Forms.GroupBox QueryDeletingGroup;
        private System.Windows.Forms.Button DeleteQueryButton;
        private System.Windows.Forms.TextBox QueryNumInput;
        private System.Windows.Forms.Label QueryNumLabel;
        private System.Windows.Forms.DataGridView UserQueriesData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}