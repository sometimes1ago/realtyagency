namespace RealtyAgency
{
    partial class BuyRealty
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
            this.SectionHeader = new System.Windows.Forms.Label();
            this.HousesData = new System.Windows.Forms.DataGridView();
            this.SortingGroup = new System.Windows.Forms.GroupBox();
            this.ShowSortedButton = new System.Windows.Forms.Button();
            this.OrderOptions = new System.Windows.Forms.ComboBox();
            this.SorderByLabel = new System.Windows.Forms.Label();
            this.SortOptions = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.BuyRealtyGroup = new System.Windows.Forms.GroupBox();
            this.RieltorsOptions = new System.Windows.Forms.ComboBox();
            this.SelectRieltorLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RealtyOptions = new System.Windows.Forms.ComboBox();
            this.SelectRealtyLabel = new System.Windows.Forms.Label();
            this.GoBack = new System.Windows.Forms.LinkLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.RealtyOptionsTabs = new System.Windows.Forms.TabControl();
            this.Houses = new System.Windows.Forms.TabPage();
            this.Apartaments = new System.Windows.Forms.TabPage();
            this.AprtSortGroup = new System.Windows.Forms.GroupBox();
            this.ArptShowButton = new System.Windows.Forms.Button();
            this.ArptOrderByOptions = new System.Windows.Forms.ComboBox();
            this.AprtOrderByLabel = new System.Windows.Forms.Label();
            this.ArptSortByOptions = new System.Windows.Forms.ComboBox();
            this.AprtSortByLabel = new System.Windows.Forms.Label();
            this.ApartamentsData = new System.Windows.Forms.DataGridView();
            this.ArptBuyingGroup = new System.Windows.Forms.GroupBox();
            this.AprtRieltorOptions = new System.Windows.Forms.ComboBox();
            this.SelectAprtRietlorLabel = new System.Windows.Forms.Label();
            this.BuyAprtButton = new System.Windows.Forms.Button();
            this.AprtOptions = new System.Windows.Forms.ComboBox();
            this.SelectArptLabel = new System.Windows.Forms.Label();
            this.Areas = new System.Windows.Forms.TabPage();
            this.AreasSorting = new System.Windows.Forms.GroupBox();
            this.AreasShowButton = new System.Windows.Forms.Button();
            this.AreasOrderOptions = new System.Windows.Forms.ComboBox();
            this.AreasOrderByLabel = new System.Windows.Forms.Label();
            this.AreasSortOptions = new System.Windows.Forms.ComboBox();
            this.AreasSortByLabel = new System.Windows.Forms.Label();
            this.AreasData = new System.Windows.Forms.DataGridView();
            this.AreasBuyingGroup = new System.Windows.Forms.GroupBox();
            this.AreasRieltorOptions = new System.Windows.Forms.ComboBox();
            this.AreasRieltorLabel = new System.Windows.Forms.Label();
            this.AreasBuyButton = new System.Windows.Forms.Button();
            this.AreasOptions = new System.Windows.Forms.ComboBox();
            this.AreasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HousesData)).BeginInit();
            this.SortingGroup.SuspendLayout();
            this.BuyRealtyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.RealtyOptionsTabs.SuspendLayout();
            this.Houses.SuspendLayout();
            this.Apartaments.SuspendLayout();
            this.AprtSortGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApartamentsData)).BeginInit();
            this.ArptBuyingGroup.SuspendLayout();
            this.Areas.SuspendLayout();
            this.AreasSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreasData)).BeginInit();
            this.AreasBuyingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SectionHeader
            // 
            this.SectionHeader.AutoSize = true;
            this.SectionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.SectionHeader.Location = new System.Drawing.Point(88, 19);
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.Size = new System.Drawing.Size(455, 29);
            this.SectionHeader.TabIndex = 15;
            this.SectionHeader.Text = "Список доступных объектов к покупке";
            // 
            // HousesData
            // 
            this.HousesData.AllowUserToAddRows = false;
            this.HousesData.AllowUserToDeleteRows = false;
            this.HousesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HousesData.Location = new System.Drawing.Point(14, 16);
            this.HousesData.Name = "HousesData";
            this.HousesData.ReadOnly = true;
            this.HousesData.Size = new System.Drawing.Size(768, 283);
            this.HousesData.TabIndex = 17;
            // 
            // SortingGroup
            // 
            this.SortingGroup.Controls.Add(this.ShowSortedButton);
            this.SortingGroup.Controls.Add(this.OrderOptions);
            this.SortingGroup.Controls.Add(this.SorderByLabel);
            this.SortingGroup.Controls.Add(this.SortOptions);
            this.SortingGroup.Controls.Add(this.SortByLabel);
            this.SortingGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.SortingGroup.Location = new System.Drawing.Point(14, 323);
            this.SortingGroup.Name = "SortingGroup";
            this.SortingGroup.Size = new System.Drawing.Size(265, 153);
            this.SortingGroup.TabIndex = 18;
            this.SortingGroup.TabStop = false;
            this.SortingGroup.Text = "Сортировка";
            // 
            // ShowSortedButton
            // 
            this.ShowSortedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.ShowSortedButton.FlatAppearance.BorderSize = 0;
            this.ShowSortedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowSortedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ShowSortedButton.ForeColor = System.Drawing.Color.White;
            this.ShowSortedButton.Location = new System.Drawing.Point(18, 99);
            this.ShowSortedButton.Name = "ShowSortedButton";
            this.ShowSortedButton.Size = new System.Drawing.Size(140, 36);
            this.ShowSortedButton.TabIndex = 19;
            this.ShowSortedButton.Text = "Показать";
            this.ShowSortedButton.UseVisualStyleBackColor = false;
            // 
            // OrderOptions
            // 
            this.OrderOptions.FormattingEnabled = true;
            this.OrderOptions.Location = new System.Drawing.Point(125, 63);
            this.OrderOptions.Name = "OrderOptions";
            this.OrderOptions.Size = new System.Drawing.Size(121, 21);
            this.OrderOptions.TabIndex = 7;
            // 
            // SorderByLabel
            // 
            this.SorderByLabel.AutoSize = true;
            this.SorderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SorderByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SorderByLabel.Location = new System.Drawing.Point(15, 63);
            this.SorderByLabel.Name = "SorderByLabel";
            this.SorderByLabel.Size = new System.Drawing.Size(74, 15);
            this.SorderByLabel.TabIndex = 6;
            this.SorderByLabel.Text = "Порядок по";
            // 
            // SortOptions
            // 
            this.SortOptions.FormattingEnabled = true;
            this.SortOptions.Location = new System.Drawing.Point(125, 26);
            this.SortOptions.Name = "SortOptions";
            this.SortOptions.Size = new System.Drawing.Size(121, 21);
            this.SortOptions.TabIndex = 5;
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SortByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SortByLabel.Location = new System.Drawing.Point(15, 26);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(102, 15);
            this.SortByLabel.TabIndex = 4;
            this.SortByLabel.Text = "Сортировать по";
            // 
            // BuyRealtyGroup
            // 
            this.BuyRealtyGroup.Controls.Add(this.RieltorsOptions);
            this.BuyRealtyGroup.Controls.Add(this.SelectRieltorLabel);
            this.BuyRealtyGroup.Controls.Add(this.SearchButton);
            this.BuyRealtyGroup.Controls.Add(this.RealtyOptions);
            this.BuyRealtyGroup.Controls.Add(this.SelectRealtyLabel);
            this.BuyRealtyGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BuyRealtyGroup.Location = new System.Drawing.Point(336, 323);
            this.BuyRealtyGroup.Name = "BuyRealtyGroup";
            this.BuyRealtyGroup.Size = new System.Drawing.Size(446, 153);
            this.BuyRealtyGroup.TabIndex = 20;
            this.BuyRealtyGroup.TabStop = false;
            this.BuyRealtyGroup.Text = "Покупка недвижимости";
            // 
            // RieltorsOptions
            // 
            this.RieltorsOptions.FormattingEnabled = true;
            this.RieltorsOptions.Location = new System.Drawing.Point(196, 63);
            this.RieltorsOptions.Name = "RieltorsOptions";
            this.RieltorsOptions.Size = new System.Drawing.Size(230, 21);
            this.RieltorsOptions.TabIndex = 21;
            // 
            // SelectRieltorLabel
            // 
            this.SelectRieltorLabel.AutoSize = true;
            this.SelectRieltorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SelectRieltorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SelectRieltorLabel.Location = new System.Drawing.Point(15, 64);
            this.SelectRieltorLabel.Name = "SelectRieltorLabel";
            this.SelectRieltorLabel.Size = new System.Drawing.Size(125, 15);
            this.SelectRieltorLabel.TabIndex = 20;
            this.SelectRieltorLabel.Text = "Выберите риелтора";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(18, 99);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(140, 36);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Купить";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // RealtyOptions
            // 
            this.RealtyOptions.FormattingEnabled = true;
            this.RealtyOptions.Location = new System.Drawing.Point(196, 25);
            this.RealtyOptions.Name = "RealtyOptions";
            this.RealtyOptions.Size = new System.Drawing.Size(230, 21);
            this.RealtyOptions.TabIndex = 5;
            // 
            // SelectRealtyLabel
            // 
            this.SelectRealtyLabel.AutoSize = true;
            this.SelectRealtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SelectRealtyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SelectRealtyLabel.Location = new System.Drawing.Point(15, 26);
            this.SelectRealtyLabel.Name = "SelectRealtyLabel";
            this.SelectRealtyLabel.Size = new System.Drawing.Size(156, 15);
            this.SelectRealtyLabel.TabIndex = 4;
            this.SelectRealtyLabel.Text = "Выберите недвижимость";
            // 
            // GoBack
            // 
            this.GoBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.AutoSize = true;
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GoBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GoBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.Location = new System.Drawing.Point(13, 24);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(48, 15);
            this.GoBack.TabIndex = 21;
            this.GoBack.TabStop = true;
            this.GoBack.Text = "Назад";
            this.GoBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack_LinkClicked);
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(713, 19);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(97, 29);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 16;
            this.Logo.TabStop = false;
            // 
            // RealtyOptionsTabs
            // 
            this.RealtyOptionsTabs.Controls.Add(this.Houses);
            this.RealtyOptionsTabs.Controls.Add(this.Apartaments);
            this.RealtyOptionsTabs.Controls.Add(this.Areas);
            this.RealtyOptionsTabs.Location = new System.Drawing.Point(12, 51);
            this.RealtyOptionsTabs.Name = "RealtyOptionsTabs";
            this.RealtyOptionsTabs.SelectedIndex = 0;
            this.RealtyOptionsTabs.Size = new System.Drawing.Size(810, 522);
            this.RealtyOptionsTabs.TabIndex = 22;
            // 
            // Houses
            // 
            this.Houses.Controls.Add(this.SortingGroup);
            this.Houses.Controls.Add(this.HousesData);
            this.Houses.Controls.Add(this.BuyRealtyGroup);
            this.Houses.Location = new System.Drawing.Point(4, 22);
            this.Houses.Name = "Houses";
            this.Houses.Padding = new System.Windows.Forms.Padding(3);
            this.Houses.Size = new System.Drawing.Size(802, 496);
            this.Houses.TabIndex = 0;
            this.Houses.Text = "Дома";
            this.Houses.UseVisualStyleBackColor = true;
            // 
            // Apartaments
            // 
            this.Apartaments.Controls.Add(this.AprtSortGroup);
            this.Apartaments.Controls.Add(this.ApartamentsData);
            this.Apartaments.Controls.Add(this.ArptBuyingGroup);
            this.Apartaments.Location = new System.Drawing.Point(4, 22);
            this.Apartaments.Name = "Apartaments";
            this.Apartaments.Padding = new System.Windows.Forms.Padding(3);
            this.Apartaments.Size = new System.Drawing.Size(802, 496);
            this.Apartaments.TabIndex = 1;
            this.Apartaments.Text = "Квартиры";
            this.Apartaments.UseVisualStyleBackColor = true;
            // 
            // AprtSortGroup
            // 
            this.AprtSortGroup.Controls.Add(this.ArptShowButton);
            this.AprtSortGroup.Controls.Add(this.ArptOrderByOptions);
            this.AprtSortGroup.Controls.Add(this.AprtOrderByLabel);
            this.AprtSortGroup.Controls.Add(this.ArptSortByOptions);
            this.AprtSortGroup.Controls.Add(this.AprtSortByLabel);
            this.AprtSortGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.AprtSortGroup.Location = new System.Drawing.Point(17, 325);
            this.AprtSortGroup.Name = "AprtSortGroup";
            this.AprtSortGroup.Size = new System.Drawing.Size(265, 153);
            this.AprtSortGroup.TabIndex = 22;
            this.AprtSortGroup.TabStop = false;
            this.AprtSortGroup.Text = "Сортировка";
            // 
            // ArptShowButton
            // 
            this.ArptShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.ArptShowButton.FlatAppearance.BorderSize = 0;
            this.ArptShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArptShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ArptShowButton.ForeColor = System.Drawing.Color.White;
            this.ArptShowButton.Location = new System.Drawing.Point(18, 99);
            this.ArptShowButton.Name = "ArptShowButton";
            this.ArptShowButton.Size = new System.Drawing.Size(140, 36);
            this.ArptShowButton.TabIndex = 19;
            this.ArptShowButton.Text = "Показать";
            this.ArptShowButton.UseVisualStyleBackColor = false;
            // 
            // ArptOrderByOptions
            // 
            this.ArptOrderByOptions.FormattingEnabled = true;
            this.ArptOrderByOptions.Location = new System.Drawing.Point(125, 63);
            this.ArptOrderByOptions.Name = "ArptOrderByOptions";
            this.ArptOrderByOptions.Size = new System.Drawing.Size(121, 21);
            this.ArptOrderByOptions.TabIndex = 7;
            // 
            // AprtOrderByLabel
            // 
            this.AprtOrderByLabel.AutoSize = true;
            this.AprtOrderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AprtOrderByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.AprtOrderByLabel.Location = new System.Drawing.Point(15, 63);
            this.AprtOrderByLabel.Name = "AprtOrderByLabel";
            this.AprtOrderByLabel.Size = new System.Drawing.Size(74, 15);
            this.AprtOrderByLabel.TabIndex = 6;
            this.AprtOrderByLabel.Text = "Порядок по";
            // 
            // ArptSortByOptions
            // 
            this.ArptSortByOptions.FormattingEnabled = true;
            this.ArptSortByOptions.Location = new System.Drawing.Point(125, 26);
            this.ArptSortByOptions.Name = "ArptSortByOptions";
            this.ArptSortByOptions.Size = new System.Drawing.Size(121, 21);
            this.ArptSortByOptions.TabIndex = 5;
            // 
            // AprtSortByLabel
            // 
            this.AprtSortByLabel.AutoSize = true;
            this.AprtSortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AprtSortByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.AprtSortByLabel.Location = new System.Drawing.Point(15, 26);
            this.AprtSortByLabel.Name = "AprtSortByLabel";
            this.AprtSortByLabel.Size = new System.Drawing.Size(102, 15);
            this.AprtSortByLabel.TabIndex = 4;
            this.AprtSortByLabel.Text = "Сортировать по";
            // 
            // ApartamentsData
            // 
            this.ApartamentsData.AllowUserToAddRows = false;
            this.ApartamentsData.AllowUserToDeleteRows = false;
            this.ApartamentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApartamentsData.Location = new System.Drawing.Point(17, 18);
            this.ApartamentsData.Name = "ApartamentsData";
            this.ApartamentsData.ReadOnly = true;
            this.ApartamentsData.Size = new System.Drawing.Size(768, 283);
            this.ApartamentsData.TabIndex = 21;
            // 
            // ArptBuyingGroup
            // 
            this.ArptBuyingGroup.Controls.Add(this.AprtRieltorOptions);
            this.ArptBuyingGroup.Controls.Add(this.SelectAprtRietlorLabel);
            this.ArptBuyingGroup.Controls.Add(this.BuyAprtButton);
            this.ArptBuyingGroup.Controls.Add(this.AprtOptions);
            this.ArptBuyingGroup.Controls.Add(this.SelectArptLabel);
            this.ArptBuyingGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ArptBuyingGroup.Location = new System.Drawing.Point(339, 325);
            this.ArptBuyingGroup.Name = "ArptBuyingGroup";
            this.ArptBuyingGroup.Size = new System.Drawing.Size(446, 153);
            this.ArptBuyingGroup.TabIndex = 23;
            this.ArptBuyingGroup.TabStop = false;
            this.ArptBuyingGroup.Text = "Покупка недвижимости";
            // 
            // AprtRieltorOptions
            // 
            this.AprtRieltorOptions.FormattingEnabled = true;
            this.AprtRieltorOptions.Location = new System.Drawing.Point(196, 63);
            this.AprtRieltorOptions.Name = "AprtRieltorOptions";
            this.AprtRieltorOptions.Size = new System.Drawing.Size(230, 21);
            this.AprtRieltorOptions.TabIndex = 21;
            // 
            // SelectAprtRietlorLabel
            // 
            this.SelectAprtRietlorLabel.AutoSize = true;
            this.SelectAprtRietlorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SelectAprtRietlorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SelectAprtRietlorLabel.Location = new System.Drawing.Point(14, 64);
            this.SelectAprtRietlorLabel.Name = "SelectAprtRietlorLabel";
            this.SelectAprtRietlorLabel.Size = new System.Drawing.Size(125, 15);
            this.SelectAprtRietlorLabel.TabIndex = 20;
            this.SelectAprtRietlorLabel.Text = "Выберите риелтора";
            // 
            // BuyAprtButton
            // 
            this.BuyAprtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.BuyAprtButton.FlatAppearance.BorderSize = 0;
            this.BuyAprtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyAprtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BuyAprtButton.ForeColor = System.Drawing.Color.White;
            this.BuyAprtButton.Location = new System.Drawing.Point(18, 99);
            this.BuyAprtButton.Name = "BuyAprtButton";
            this.BuyAprtButton.Size = new System.Drawing.Size(140, 36);
            this.BuyAprtButton.TabIndex = 19;
            this.BuyAprtButton.Text = "Купить";
            this.BuyAprtButton.UseVisualStyleBackColor = false;
            // 
            // AprtOptions
            // 
            this.AprtOptions.FormattingEnabled = true;
            this.AprtOptions.Location = new System.Drawing.Point(196, 25);
            this.AprtOptions.Name = "AprtOptions";
            this.AprtOptions.Size = new System.Drawing.Size(230, 21);
            this.AprtOptions.TabIndex = 5;
            // 
            // SelectArptLabel
            // 
            this.SelectArptLabel.AutoSize = true;
            this.SelectArptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SelectArptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SelectArptLabel.Location = new System.Drawing.Point(15, 26);
            this.SelectArptLabel.Name = "SelectArptLabel";
            this.SelectArptLabel.Size = new System.Drawing.Size(156, 15);
            this.SelectArptLabel.TabIndex = 4;
            this.SelectArptLabel.Text = "Выберите недвижимость";
            // 
            // Areas
            // 
            this.Areas.Controls.Add(this.AreasSorting);
            this.Areas.Controls.Add(this.AreasData);
            this.Areas.Controls.Add(this.AreasBuyingGroup);
            this.Areas.Location = new System.Drawing.Point(4, 22);
            this.Areas.Name = "Areas";
            this.Areas.Size = new System.Drawing.Size(802, 496);
            this.Areas.TabIndex = 2;
            this.Areas.Text = "Земля";
            this.Areas.UseVisualStyleBackColor = true;
            // 
            // AreasSorting
            // 
            this.AreasSorting.Controls.Add(this.AreasShowButton);
            this.AreasSorting.Controls.Add(this.AreasOrderOptions);
            this.AreasSorting.Controls.Add(this.AreasOrderByLabel);
            this.AreasSorting.Controls.Add(this.AreasSortOptions);
            this.AreasSorting.Controls.Add(this.AreasSortByLabel);
            this.AreasSorting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.AreasSorting.Location = new System.Drawing.Point(17, 325);
            this.AreasSorting.Name = "AreasSorting";
            this.AreasSorting.Size = new System.Drawing.Size(265, 153);
            this.AreasSorting.TabIndex = 25;
            this.AreasSorting.TabStop = false;
            this.AreasSorting.Text = "Сортировка";
            // 
            // AreasShowButton
            // 
            this.AreasShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.AreasShowButton.FlatAppearance.BorderSize = 0;
            this.AreasShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreasShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AreasShowButton.ForeColor = System.Drawing.Color.White;
            this.AreasShowButton.Location = new System.Drawing.Point(18, 99);
            this.AreasShowButton.Name = "AreasShowButton";
            this.AreasShowButton.Size = new System.Drawing.Size(140, 36);
            this.AreasShowButton.TabIndex = 19;
            this.AreasShowButton.Text = "Показать";
            this.AreasShowButton.UseVisualStyleBackColor = false;
            // 
            // AreasOrderOptions
            // 
            this.AreasOrderOptions.FormattingEnabled = true;
            this.AreasOrderOptions.Location = new System.Drawing.Point(125, 63);
            this.AreasOrderOptions.Name = "AreasOrderOptions";
            this.AreasOrderOptions.Size = new System.Drawing.Size(121, 21);
            this.AreasOrderOptions.TabIndex = 7;
            // 
            // AreasOrderByLabel
            // 
            this.AreasOrderByLabel.AutoSize = true;
            this.AreasOrderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AreasOrderByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.AreasOrderByLabel.Location = new System.Drawing.Point(15, 63);
            this.AreasOrderByLabel.Name = "AreasOrderByLabel";
            this.AreasOrderByLabel.Size = new System.Drawing.Size(74, 15);
            this.AreasOrderByLabel.TabIndex = 6;
            this.AreasOrderByLabel.Text = "Порядок по";
            // 
            // AreasSortOptions
            // 
            this.AreasSortOptions.FormattingEnabled = true;
            this.AreasSortOptions.Location = new System.Drawing.Point(125, 26);
            this.AreasSortOptions.Name = "AreasSortOptions";
            this.AreasSortOptions.Size = new System.Drawing.Size(121, 21);
            this.AreasSortOptions.TabIndex = 5;
            // 
            // AreasSortByLabel
            // 
            this.AreasSortByLabel.AutoSize = true;
            this.AreasSortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AreasSortByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.AreasSortByLabel.Location = new System.Drawing.Point(15, 26);
            this.AreasSortByLabel.Name = "AreasSortByLabel";
            this.AreasSortByLabel.Size = new System.Drawing.Size(102, 15);
            this.AreasSortByLabel.TabIndex = 4;
            this.AreasSortByLabel.Text = "Сортировать по";
            // 
            // AreasData
            // 
            this.AreasData.AllowUserToAddRows = false;
            this.AreasData.AllowUserToDeleteRows = false;
            this.AreasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AreasData.Location = new System.Drawing.Point(17, 18);
            this.AreasData.Name = "AreasData";
            this.AreasData.ReadOnly = true;
            this.AreasData.Size = new System.Drawing.Size(768, 283);
            this.AreasData.TabIndex = 24;
            // 
            // AreasBuyingGroup
            // 
            this.AreasBuyingGroup.Controls.Add(this.AreasRieltorOptions);
            this.AreasBuyingGroup.Controls.Add(this.AreasRieltorLabel);
            this.AreasBuyingGroup.Controls.Add(this.AreasBuyButton);
            this.AreasBuyingGroup.Controls.Add(this.AreasOptions);
            this.AreasBuyingGroup.Controls.Add(this.AreasLabel);
            this.AreasBuyingGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.AreasBuyingGroup.Location = new System.Drawing.Point(339, 325);
            this.AreasBuyingGroup.Name = "AreasBuyingGroup";
            this.AreasBuyingGroup.Size = new System.Drawing.Size(446, 153);
            this.AreasBuyingGroup.TabIndex = 26;
            this.AreasBuyingGroup.TabStop = false;
            this.AreasBuyingGroup.Text = "Покупка недвижимости";
            // 
            // AreasRieltorOptions
            // 
            this.AreasRieltorOptions.FormattingEnabled = true;
            this.AreasRieltorOptions.Location = new System.Drawing.Point(196, 63);
            this.AreasRieltorOptions.Name = "AreasRieltorOptions";
            this.AreasRieltorOptions.Size = new System.Drawing.Size(230, 21);
            this.AreasRieltorOptions.TabIndex = 21;
            // 
            // AreasRieltorLabel
            // 
            this.AreasRieltorLabel.AutoSize = true;
            this.AreasRieltorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AreasRieltorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.AreasRieltorLabel.Location = new System.Drawing.Point(14, 64);
            this.AreasRieltorLabel.Name = "AreasRieltorLabel";
            this.AreasRieltorLabel.Size = new System.Drawing.Size(125, 15);
            this.AreasRieltorLabel.TabIndex = 20;
            this.AreasRieltorLabel.Text = "Выберите риелтора";
            // 
            // AreasBuyButton
            // 
            this.AreasBuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.AreasBuyButton.FlatAppearance.BorderSize = 0;
            this.AreasBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AreasBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AreasBuyButton.ForeColor = System.Drawing.Color.White;
            this.AreasBuyButton.Location = new System.Drawing.Point(18, 99);
            this.AreasBuyButton.Name = "AreasBuyButton";
            this.AreasBuyButton.Size = new System.Drawing.Size(140, 36);
            this.AreasBuyButton.TabIndex = 19;
            this.AreasBuyButton.Text = "Купить";
            this.AreasBuyButton.UseVisualStyleBackColor = false;
            // 
            // AreasOptions
            // 
            this.AreasOptions.FormattingEnabled = true;
            this.AreasOptions.Location = new System.Drawing.Point(196, 25);
            this.AreasOptions.Name = "AreasOptions";
            this.AreasOptions.Size = new System.Drawing.Size(230, 21);
            this.AreasOptions.TabIndex = 5;
            // 
            // AreasLabel
            // 
            this.AreasLabel.AutoSize = true;
            this.AreasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AreasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.AreasLabel.Location = new System.Drawing.Point(15, 26);
            this.AreasLabel.Name = "AreasLabel";
            this.AreasLabel.Size = new System.Drawing.Size(156, 15);
            this.AreasLabel.TabIndex = 4;
            this.AreasLabel.Text = "Выберите недвижимость";
            // 
            // BuyRealty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(834, 586);
            this.Controls.Add(this.RealtyOptionsTabs);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.SectionHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BuyRealty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство недвижимости - Покупка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyRealty_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HousesData)).EndInit();
            this.SortingGroup.ResumeLayout(false);
            this.SortingGroup.PerformLayout();
            this.BuyRealtyGroup.ResumeLayout(false);
            this.BuyRealtyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.RealtyOptionsTabs.ResumeLayout(false);
            this.Houses.ResumeLayout(false);
            this.Apartaments.ResumeLayout(false);
            this.AprtSortGroup.ResumeLayout(false);
            this.AprtSortGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApartamentsData)).EndInit();
            this.ArptBuyingGroup.ResumeLayout(false);
            this.ArptBuyingGroup.PerformLayout();
            this.Areas.ResumeLayout(false);
            this.AreasSorting.ResumeLayout(false);
            this.AreasSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreasData)).EndInit();
            this.AreasBuyingGroup.ResumeLayout(false);
            this.AreasBuyingGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SectionHeader;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.DataGridView HousesData;
        private System.Windows.Forms.GroupBox SortingGroup;
        private System.Windows.Forms.ComboBox SortOptions;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.ComboBox OrderOptions;
        private System.Windows.Forms.Label SorderByLabel;
        private System.Windows.Forms.Button ShowSortedButton;
        private System.Windows.Forms.GroupBox BuyRealtyGroup;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox RealtyOptions;
        private System.Windows.Forms.Label SelectRealtyLabel;
        private System.Windows.Forms.ComboBox RieltorsOptions;
        private System.Windows.Forms.Label SelectRieltorLabel;
        private System.Windows.Forms.LinkLabel GoBack;
        private System.Windows.Forms.TabControl RealtyOptionsTabs;
        private System.Windows.Forms.TabPage Houses;
        private System.Windows.Forms.TabPage Apartaments;
        private System.Windows.Forms.TabPage Areas;
        private System.Windows.Forms.GroupBox AprtSortGroup;
        private System.Windows.Forms.Button ArptShowButton;
        private System.Windows.Forms.ComboBox ArptOrderByOptions;
        private System.Windows.Forms.Label AprtOrderByLabel;
        private System.Windows.Forms.ComboBox ArptSortByOptions;
        private System.Windows.Forms.Label AprtSortByLabel;
        private System.Windows.Forms.DataGridView ApartamentsData;
        private System.Windows.Forms.GroupBox ArptBuyingGroup;
        private System.Windows.Forms.ComboBox AprtRieltorOptions;
        private System.Windows.Forms.Label SelectAprtRietlorLabel;
        private System.Windows.Forms.Button BuyAprtButton;
        private System.Windows.Forms.ComboBox AprtOptions;
        private System.Windows.Forms.Label SelectArptLabel;
        private System.Windows.Forms.GroupBox AreasSorting;
        private System.Windows.Forms.Button AreasShowButton;
        private System.Windows.Forms.ComboBox AreasOrderOptions;
        private System.Windows.Forms.Label AreasOrderByLabel;
        private System.Windows.Forms.ComboBox AreasSortOptions;
        private System.Windows.Forms.Label AreasSortByLabel;
        private System.Windows.Forms.DataGridView AreasData;
        private System.Windows.Forms.GroupBox AreasBuyingGroup;
        private System.Windows.Forms.ComboBox AreasRieltorOptions;
        private System.Windows.Forms.Label AreasRieltorLabel;
        private System.Windows.Forms.Button AreasBuyButton;
        private System.Windows.Forms.ComboBox AreasOptions;
        private System.Windows.Forms.Label AreasLabel;
    }
}