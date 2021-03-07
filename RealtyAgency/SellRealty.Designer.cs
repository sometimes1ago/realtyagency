namespace RealtyAgency
{
    partial class SellRealty
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
            this.SectionHeader = new System.Windows.Forms.Label();
            this.RealtyType = new System.Windows.Forms.ComboBox();
            this.SelectTypeLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.SteetInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HNumInput = new System.Windows.Forms.TextBox();
            this.HouseNumber = new System.Windows.Forms.Label();
            this.AptNumLabel = new System.Windows.Forms.TextBox();
            this.AptNum = new System.Windows.Forms.Label();
            this.LatitudeInput = new System.Windows.Forms.TextBox();
            this.Latitude = new System.Windows.Forms.Label();
            this.LongitudeInput = new System.Windows.Forms.TextBox();
            this.Longitude = new System.Windows.Forms.Label();
            this.FloorInput = new System.Windows.Forms.TextBox();
            this.Floor = new System.Windows.Forms.Label();
            this.RoomsInput = new System.Windows.Forms.TextBox();
            this.Rooms = new System.Windows.Forms.Label();
            this.TotalAreaInput = new System.Windows.Forms.TextBox();
            this.TotalArea = new System.Windows.Forms.Label();
            this.SellButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBack
            // 
            this.GoBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.AutoSize = true;
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GoBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GoBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.Location = new System.Drawing.Point(27, 29);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(48, 15);
            this.GoBack.TabIndex = 23;
            this.GoBack.TabStop = true;
            this.GoBack.Text = "Назад";
            this.GoBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoBack_LinkClicked);
            // 
            // SectionHeader
            // 
            this.SectionHeader.AutoSize = true;
            this.SectionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SectionHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.SectionHeader.Location = new System.Drawing.Point(90, 22);
            this.SectionHeader.Name = "SectionHeader";
            this.SectionHeader.Size = new System.Drawing.Size(297, 29);
            this.SectionHeader.TabIndex = 22;
            this.SectionHeader.Text = "Продажа недвижимости";
            // 
            // RealtyType
            // 
            this.RealtyType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RealtyType.FormattingEnabled = true;
            this.RealtyType.Items.AddRange(new object[] {
            "Дома",
            "Квартиры",
            "Земля"});
            this.RealtyType.Location = new System.Drawing.Point(30, 130);
            this.RealtyType.Name = "RealtyType";
            this.RealtyType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RealtyType.Size = new System.Drawing.Size(121, 21);
            this.RealtyType.TabIndex = 24;
            // 
            // SelectTypeLabel
            // 
            this.SelectTypeLabel.AutoSize = true;
            this.SelectTypeLabel.Location = new System.Drawing.Point(27, 103);
            this.SelectTypeLabel.Name = "SelectTypeLabel";
            this.SelectTypeLabel.Size = new System.Drawing.Size(77, 13);
            this.SelectTypeLabel.TabIndex = 25;
            this.SelectTypeLabel.Text = "Выберите тип";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(25, 181);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(81, 13);
            this.CityLabel.TabIndex = 26;
            this.CityLabel.Text = "Введите город";
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(30, 207);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(100, 20);
            this.CityInput.TabIndex = 27;
            // 
            // SteetInput
            // 
            this.SteetInput.Location = new System.Drawing.Point(30, 279);
            this.SteetInput.Name = "SteetInput";
            this.SteetInput.Size = new System.Drawing.Size(100, 20);
            this.SteetInput.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введите улицу";
            // 
            // HNumInput
            // 
            this.HNumInput.Location = new System.Drawing.Point(199, 130);
            this.HNumInput.Name = "HNumInput";
            this.HNumInput.Size = new System.Drawing.Size(100, 20);
            this.HNumInput.TabIndex = 31;
            // 
            // HouseNumber
            // 
            this.HouseNumber.AutoSize = true;
            this.HouseNumber.Location = new System.Drawing.Point(196, 104);
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.Size = new System.Drawing.Size(113, 13);
            this.HouseNumber.TabIndex = 30;
            this.HouseNumber.Text = "Введите номер дома";
            // 
            // AptNumLabel
            // 
            this.AptNumLabel.Location = new System.Drawing.Point(199, 208);
            this.AptNumLabel.Name = "AptNumLabel";
            this.AptNumLabel.Size = new System.Drawing.Size(100, 20);
            this.AptNumLabel.TabIndex = 33;
            // 
            // AptNum
            // 
            this.AptNum.AutoSize = true;
            this.AptNum.Location = new System.Drawing.Point(196, 182);
            this.AptNum.Name = "AptNum";
            this.AptNum.Size = new System.Drawing.Size(136, 13);
            this.AptNum.TabIndex = 32;
            this.AptNum.Text = "Введите номер квартиры";
            // 
            // LatitudeInput
            // 
            this.LatitudeInput.Location = new System.Drawing.Point(199, 280);
            this.LatitudeInput.Name = "LatitudeInput";
            this.LatitudeInput.Size = new System.Drawing.Size(100, 20);
            this.LatitudeInput.TabIndex = 35;
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(196, 254);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(88, 13);
            this.Latitude.TabIndex = 34;
            this.Latitude.Text = "Введите широту";
            // 
            // LongitudeInput
            // 
            this.LongitudeInput.Location = new System.Drawing.Point(373, 130);
            this.LongitudeInput.Name = "LongitudeInput";
            this.LongitudeInput.Size = new System.Drawing.Size(100, 20);
            this.LongitudeInput.TabIndex = 37;
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Location = new System.Drawing.Point(370, 104);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(91, 13);
            this.Longitude.TabIndex = 36;
            this.Longitude.Text = "Введите долготу";
            // 
            // FloorInput
            // 
            this.FloorInput.Location = new System.Drawing.Point(373, 208);
            this.FloorInput.Name = "FloorInput";
            this.FloorInput.Size = new System.Drawing.Size(100, 20);
            this.FloorInput.TabIndex = 39;
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Location = new System.Drawing.Point(370, 182);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(77, 13);
            this.Floor.TabIndex = 38;
            this.Floor.Text = "Введите этаж";
            // 
            // RoomsInput
            // 
            this.RoomsInput.Location = new System.Drawing.Point(373, 280);
            this.RoomsInput.Name = "RoomsInput";
            this.RoomsInput.Size = new System.Drawing.Size(100, 20);
            this.RoomsInput.TabIndex = 41;
            // 
            // Rooms
            // 
            this.Rooms.AutoSize = true;
            this.Rooms.Location = new System.Drawing.Point(370, 254);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(125, 13);
            this.Rooms.TabIndex = 40;
            this.Rooms.Text = "Введите кол-во комнат";
            // 
            // TotalAreaInput
            // 
            this.TotalAreaInput.Location = new System.Drawing.Point(536, 130);
            this.TotalAreaInput.Name = "TotalAreaInput";
            this.TotalAreaInput.Size = new System.Drawing.Size(100, 20);
            this.TotalAreaInput.TabIndex = 43;
            // 
            // TotalArea
            // 
            this.TotalArea.AutoSize = true;
            this.TotalArea.Location = new System.Drawing.Point(533, 104);
            this.TotalArea.Name = "TotalArea";
            this.TotalArea.Size = new System.Drawing.Size(178, 13);
            this.TotalArea.TabIndex = 42;
            this.TotalArea.Text = "Общая площадь(целые значения)";
            // 
            // SellButton
            // 
            this.SellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.SellButton.FlatAppearance.BorderSize = 0;
            this.SellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SellButton.ForeColor = System.Drawing.Color.White;
            this.SellButton.Location = new System.Drawing.Point(536, 264);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(140, 36);
            this.SellButton.TabIndex = 44;
            this.SellButton.Text = "Продать";
            this.SellButton.UseVisualStyleBackColor = false;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(717, 22);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(43, 22);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 45;
            this.Logo.TabStop = false;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(536, 208);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(100, 20);
            this.PriceInput.TabIndex = 47;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(533, 182);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(178, 13);
            this.PriceLabel.TabIndex = 46;
            this.PriceLabel.Text = "Общая площадь(целые значения)";
            // 
            // SellRealty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 375);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.TotalAreaInput);
            this.Controls.Add(this.TotalArea);
            this.Controls.Add(this.RoomsInput);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.FloorInput);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.LongitudeInput);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.LatitudeInput);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.AptNumLabel);
            this.Controls.Add(this.AptNum);
            this.Controls.Add(this.HNumInput);
            this.Controls.Add(this.HouseNumber);
            this.Controls.Add(this.SteetInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.SelectTypeLabel);
            this.Controls.Add(this.RealtyType);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.SectionHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SellRealty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство недвижимости - Продажа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellRealty_FormClosing);
            this.Load += new System.EventHandler(this.SellRealty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel GoBack;
        private System.Windows.Forms.Label SectionHeader;
        private System.Windows.Forms.ComboBox RealtyType;
        private System.Windows.Forms.Label SelectTypeLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.TextBox SteetInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HNumInput;
        private System.Windows.Forms.Label HouseNumber;
        private System.Windows.Forms.TextBox AptNumLabel;
        private System.Windows.Forms.Label AptNum;
        private System.Windows.Forms.TextBox LatitudeInput;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.TextBox LongitudeInput;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.TextBox FloorInput;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.TextBox RoomsInput;
        private System.Windows.Forms.Label Rooms;
        private System.Windows.Forms.TextBox TotalAreaInput;
        private System.Windows.Forms.Label TotalArea;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Label PriceLabel;
    }
}