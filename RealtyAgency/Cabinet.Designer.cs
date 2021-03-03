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
            this.SortDealsGroup = new System.Windows.Forms.GroupBox();
            this.AreasShowButton = new System.Windows.Forms.Button();
            this.DealsOrderOptions = new System.Windows.Forms.ComboBox();
            this.DealsOrderByLabel = new System.Windows.Forms.Label();
            this.DealsSortOptions = new System.Windows.Forms.ComboBox();
            this.DealsSortByLabel = new System.Windows.Forms.Label();
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DirectSearchGroup = new System.Windows.Forms.GroupBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SearchByOptions = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchByInput = new System.Windows.Forms.TextBox();
            this.SortDealsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DirectSearchGroup.SuspendLayout();
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
            // SortDealsGroup
            // 
            this.SortDealsGroup.Controls.Add(this.AreasShowButton);
            this.SortDealsGroup.Controls.Add(this.DealsOrderOptions);
            this.SortDealsGroup.Controls.Add(this.DealsOrderByLabel);
            this.SortDealsGroup.Controls.Add(this.DealsSortOptions);
            this.SortDealsGroup.Controls.Add(this.DealsSortByLabel);
            this.SortDealsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.SortDealsGroup.Location = new System.Drawing.Point(12, 302);
            this.SortDealsGroup.Name = "SortDealsGroup";
            this.SortDealsGroup.Size = new System.Drawing.Size(265, 153);
            this.SortDealsGroup.TabIndex = 26;
            this.SortDealsGroup.TabStop = false;
            this.SortDealsGroup.Text = "Сортировка";
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
            this.AreasShowButton.Size = new System.Drawing.Size(99, 34);
            this.AreasShowButton.TabIndex = 19;
            this.AreasShowButton.Text = "Показать";
            this.AreasShowButton.UseVisualStyleBackColor = false;
            // 
            // DealsOrderOptions
            // 
            this.DealsOrderOptions.FormattingEnabled = true;
            this.DealsOrderOptions.Location = new System.Drawing.Point(125, 63);
            this.DealsOrderOptions.Name = "DealsOrderOptions";
            this.DealsOrderOptions.Size = new System.Drawing.Size(121, 21);
            this.DealsOrderOptions.TabIndex = 7;
            // 
            // DealsOrderByLabel
            // 
            this.DealsOrderByLabel.AutoSize = true;
            this.DealsOrderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DealsOrderByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.DealsOrderByLabel.Location = new System.Drawing.Point(15, 63);
            this.DealsOrderByLabel.Name = "DealsOrderByLabel";
            this.DealsOrderByLabel.Size = new System.Drawing.Size(74, 15);
            this.DealsOrderByLabel.TabIndex = 6;
            this.DealsOrderByLabel.Text = "Порядок по";
            // 
            // DealsSortOptions
            // 
            this.DealsSortOptions.FormattingEnabled = true;
            this.DealsSortOptions.Location = new System.Drawing.Point(125, 26);
            this.DealsSortOptions.Name = "DealsSortOptions";
            this.DealsSortOptions.Size = new System.Drawing.Size(121, 21);
            this.DealsSortOptions.TabIndex = 5;
            // 
            // DealsSortByLabel
            // 
            this.DealsSortByLabel.AutoSize = true;
            this.DealsSortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DealsSortByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.DealsSortByLabel.Location = new System.Drawing.Point(15, 26);
            this.DealsSortByLabel.Name = "DealsSortByLabel";
            this.DealsSortByLabel.Size = new System.Drawing.Size(102, 15);
            this.DealsSortByLabel.TabIndex = 4;
            this.DealsSortByLabel.Text = "Сортировать по";
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.GreetingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.GreetingsLabel.Location = new System.Drawing.Point(71, 22);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(165, 29);
            this.GreetingsLabel.TabIndex = 3;
            this.GreetingsLabel.Text = "Ваши сделки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 220);
            this.dataGridView1.TabIndex = 27;
            // 
            // DirectSearchGroup
            // 
            this.DirectSearchGroup.Controls.Add(this.SearchByInput);
            this.DirectSearchGroup.Controls.Add(this.ShowButton);
            this.DirectSearchGroup.Controls.Add(this.ValueLabel);
            this.DirectSearchGroup.Controls.Add(this.SearchByOptions);
            this.DirectSearchGroup.Controls.Add(this.SearchByLabel);
            this.DirectSearchGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.DirectSearchGroup.Location = new System.Drawing.Point(332, 302);
            this.DirectSearchGroup.Name = "DirectSearchGroup";
            this.DirectSearchGroup.Size = new System.Drawing.Size(289, 153);
            this.DirectSearchGroup.TabIndex = 27;
            this.DirectSearchGroup.TabStop = false;
            this.DirectSearchGroup.Text = "Прямой поиск";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ShowButton.ForeColor = System.Drawing.Color.White;
            this.ShowButton.Location = new System.Drawing.Point(18, 99);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(99, 34);
            this.ShowButton.TabIndex = 19;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = false;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.ValueLabel.Location = new System.Drawing.Point(15, 63);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(114, 15);
            this.ValueLabel.TabIndex = 6;
            this.ValueLabel.Text = "Введите значение";
            // 
            // SearchByOptions
            // 
            this.SearchByOptions.FormattingEnabled = true;
            this.SearchByOptions.Location = new System.Drawing.Point(150, 25);
            this.SearchByOptions.Name = "SearchByOptions";
            this.SearchByOptions.Size = new System.Drawing.Size(121, 21);
            this.SearchByOptions.TabIndex = 5;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SearchByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SearchByLabel.Location = new System.Drawing.Point(15, 26);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(66, 15);
            this.SearchByLabel.TabIndex = 4;
            this.SearchByLabel.Text = "Искать по";
            // 
            // SearchByInput
            // 
            this.SearchByInput.Location = new System.Drawing.Point(150, 64);
            this.SearchByInput.Name = "SearchByInput";
            this.SearchByInput.Size = new System.Drawing.Size(121, 20);
            this.SearchByInput.TabIndex = 20;
            // 
            // Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DirectSearchGroup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SortDealsGroup);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.GreetingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cabinet";
            this.Text = "Агенство недвижимости - личный кабинет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cabinet_FormClosing);
            this.SortDealsGroup.ResumeLayout(false);
            this.SortDealsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DirectSearchGroup.ResumeLayout(false);
            this.DirectSearchGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel GoBack;
        private System.Windows.Forms.GroupBox SortDealsGroup;
        private System.Windows.Forms.Button AreasShowButton;
        private System.Windows.Forms.ComboBox DealsOrderOptions;
        private System.Windows.Forms.Label DealsOrderByLabel;
        private System.Windows.Forms.ComboBox DealsSortOptions;
        private System.Windows.Forms.Label DealsSortByLabel;
        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox DirectSearchGroup;
        private System.Windows.Forms.TextBox SearchByInput;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.ComboBox SearchByOptions;
        private System.Windows.Forms.Label SearchByLabel;
    }
}