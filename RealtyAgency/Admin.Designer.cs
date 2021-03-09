namespace RealtyAgency
{
    partial class Admin
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
            this.AdminFunctions = new System.Windows.Forms.TabControl();
            this.Queries = new System.Windows.Forms.TabPage();
            this.ClientsWishesData = new System.Windows.Forms.DataGridView();
            this.RieltorsFunc = new System.Windows.Forms.TabPage();
            this.RieltorsData = new System.Windows.Forms.DataGridView();
            this.PassConfirmInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.InsertingRieltor = new System.Windows.Forms.GroupBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.DealshareInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.DealshareLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassConfirmLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.DropRieltor = new System.Windows.Forms.TabPage();
            this.AdminFunctions.SuspendLayout();
            this.Queries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsWishesData)).BeginInit();
            this.RieltorsFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RieltorsData)).BeginInit();
            this.InsertingRieltor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminFunctions
            // 
            this.AdminFunctions.Controls.Add(this.Queries);
            this.AdminFunctions.Controls.Add(this.RieltorsFunc);
            this.AdminFunctions.Controls.Add(this.DropRieltor);
            this.AdminFunctions.Location = new System.Drawing.Point(12, 74);
            this.AdminFunctions.Name = "AdminFunctions";
            this.AdminFunctions.SelectedIndex = 0;
            this.AdminFunctions.Size = new System.Drawing.Size(757, 475);
            this.AdminFunctions.TabIndex = 0;
            // 
            // Queries
            // 
            this.Queries.Controls.Add(this.ClientsWishesData);
            this.Queries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Queries.Location = new System.Drawing.Point(4, 22);
            this.Queries.Name = "Queries";
            this.Queries.Padding = new System.Windows.Forms.Padding(3);
            this.Queries.Size = new System.Drawing.Size(749, 449);
            this.Queries.TabIndex = 0;
            this.Queries.Text = "Просмотр заявок";
            this.Queries.UseVisualStyleBackColor = true;
            // 
            // ClientsWishesData
            // 
            this.ClientsWishesData.AllowUserToAddRows = false;
            this.ClientsWishesData.AllowUserToDeleteRows = false;
            this.ClientsWishesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsWishesData.Location = new System.Drawing.Point(6, 6);
            this.ClientsWishesData.Name = "ClientsWishesData";
            this.ClientsWishesData.ReadOnly = true;
            this.ClientsWishesData.Size = new System.Drawing.Size(737, 437);
            this.ClientsWishesData.TabIndex = 0;
            // 
            // RieltorsFunc
            // 
            this.RieltorsFunc.Controls.Add(this.RieltorsData);
            this.RieltorsFunc.Controls.Add(this.InsertingRieltor);
            this.RieltorsFunc.Location = new System.Drawing.Point(4, 22);
            this.RieltorsFunc.Name = "RieltorsFunc";
            this.RieltorsFunc.Padding = new System.Windows.Forms.Padding(3);
            this.RieltorsFunc.Size = new System.Drawing.Size(749, 449);
            this.RieltorsFunc.TabIndex = 1;
            this.RieltorsFunc.Text = "Данные риелторов";
            this.RieltorsFunc.UseVisualStyleBackColor = true;
            // 
            // RieltorsData
            // 
            this.RieltorsData.AllowUserToAddRows = false;
            this.RieltorsData.AllowUserToDeleteRows = false;
            this.RieltorsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RieltorsData.Location = new System.Drawing.Point(6, 11);
            this.RieltorsData.Name = "RieltorsData";
            this.RieltorsData.ReadOnly = true;
            this.RieltorsData.Size = new System.Drawing.Size(737, 266);
            this.RieltorsData.TabIndex = 1;
            // 
            // PassConfirmInput
            // 
            this.PassConfirmInput.Location = new System.Drawing.Point(477, 65);
            this.PassConfirmInput.Name = "PassConfirmInput";
            this.PassConfirmInput.Size = new System.Drawing.Size(129, 20);
            this.PassConfirmInput.TabIndex = 38;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(169, 63);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(129, 20);
            this.LastNameInput.TabIndex = 34;
            // 
            // InsertingRieltor
            // 
            this.InsertingRieltor.Controls.Add(this.RegisterButton);
            this.InsertingRieltor.Controls.Add(this.PassConfirmInput);
            this.InsertingRieltor.Controls.Add(this.DealshareInput);
            this.InsertingRieltor.Controls.Add(this.LastNameInput);
            this.InsertingRieltor.Controls.Add(this.PassConfirmLabel);
            this.InsertingRieltor.Controls.Add(this.NameInput);
            this.InsertingRieltor.Controls.Add(this.PasswordLabel);
            this.InsertingRieltor.Controls.Add(this.SurnameInput);
            this.InsertingRieltor.Controls.Add(this.PasswordInput);
            this.InsertingRieltor.Controls.Add(this.LoginInput);
            this.InsertingRieltor.Controls.Add(this.DealshareLabel);
            this.InsertingRieltor.Controls.Add(this.NameLabel);
            this.InsertingRieltor.Controls.Add(this.LastNameLabel);
            this.InsertingRieltor.Controls.Add(this.LoginLabel);
            this.InsertingRieltor.Controls.Add(this.label1);
            this.InsertingRieltor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.InsertingRieltor.Location = new System.Drawing.Point(12, 283);
            this.InsertingRieltor.Name = "InsertingRieltor";
            this.InsertingRieltor.Size = new System.Drawing.Size(652, 152);
            this.InsertingRieltor.TabIndex = 0;
            this.InsertingRieltor.TabStop = false;
            this.InsertingRieltor.Text = "Добавление риелтора";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(477, 103);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(85, 36);
            this.RegisterButton.TabIndex = 39;
            this.RegisterButton.Text = "Добавить";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // DealshareInput
            // 
            this.DealshareInput.Location = new System.Drawing.Point(166, 119);
            this.DealshareInput.Name = "DealshareInput";
            this.DealshareInput.Size = new System.Drawing.Size(129, 20);
            this.DealshareInput.TabIndex = 35;
            this.DealshareInput.TextChanged += new System.EventHandler(this.DealshareInput_TextChanged);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(15, 119);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(129, 20);
            this.NameInput.TabIndex = 33;
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(15, 63);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(129, 20);
            this.SurnameInput.TabIndex = 32;
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(327, 63);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(129, 20);
            this.LoginInput.TabIndex = 36;
            // 
            // DealshareLabel
            // 
            this.DealshareLabel.AutoSize = true;
            this.DealshareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DealshareLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.DealshareLabel.Location = new System.Drawing.Point(166, 95);
            this.DealshareLabel.Name = "DealshareLabel";
            this.DealshareLabel.Size = new System.Drawing.Size(129, 17);
            this.DealshareLabel.TabIndex = 30;
            this.DealshareLabel.Text = "Процент с продаж";
            this.DealshareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.NameLabel.Location = new System.Drawing.Point(15, 95);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 17);
            this.NameLabel.TabIndex = 26;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.LoginLabel.Location = new System.Drawing.Point(327, 37);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(47, 17);
            this.LoginLabel.TabIndex = 28;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassConfirmLabel
            // 
            this.PassConfirmLabel.AutoSize = true;
            this.PassConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.PassConfirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.PassConfirmLabel.Location = new System.Drawing.Point(477, 38);
            this.PassConfirmLabel.Name = "PassConfirmLabel";
            this.PassConfirmLabel.Size = new System.Drawing.Size(165, 17);
            this.PassConfirmLabel.TabIndex = 29;
            this.PassConfirmLabel.Text = "Подтверждение пароля";
            this.PassConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.PasswordLabel.Location = new System.Drawing.Point(327, 95);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 17);
            this.PasswordLabel.TabIndex = 27;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(327, 119);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(129, 20);
            this.PasswordInput.TabIndex = 37;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.LastNameLabel.Location = new System.Drawing.Point(169, 38);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(71, 17);
            this.LastNameLabel.TabIndex = 25;
            this.LastNameLabel.Text = "Отчество";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutLink
            // 
            this.LogoutLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LogoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogoutLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.Location = new System.Drawing.Point(719, 30);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(50, 15);
            this.LogoutLink.TabIndex = 31;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Выйти";
            this.LogoutLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(235, 22);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(57, 34);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 30;
            this.Logo.TabStop = false;
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GreetingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GreetingsLabel.Location = new System.Drawing.Point(12, 20);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(205, 29);
            this.GreetingsLabel.TabIndex = 29;
            this.GreetingsLabel.Text = "Личный кабинет";
            // 
            // DropRieltor
            // 
            this.DropRieltor.Location = new System.Drawing.Point(4, 22);
            this.DropRieltor.Name = "DropRieltor";
            this.DropRieltor.Size = new System.Drawing.Size(749, 449);
            this.DropRieltor.TabIndex = 2;
            this.DropRieltor.Text = "Удаление риелторов";
            this.DropRieltor.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.GreetingsLabel);
            this.Controls.Add(this.AdminFunctions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство недвижимости - администратор";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.AdminFunctions.ResumeLayout(false);
            this.Queries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsWishesData)).EndInit();
            this.RieltorsFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RieltorsData)).EndInit();
            this.InsertingRieltor.ResumeLayout(false);
            this.InsertingRieltor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AdminFunctions;
        private System.Windows.Forms.TabPage Queries;
        private System.Windows.Forms.TabPage RieltorsFunc;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.GroupBox InsertingRieltor;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox PassConfirmInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox DealshareInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Label DealshareLabel;
        private System.Windows.Forms.Label PassConfirmLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RieltorsData;
        private System.Windows.Forms.DataGridView ClientsWishesData;
        private System.Windows.Forms.TabPage DropRieltor;
    }
}