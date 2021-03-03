namespace RealtyAgency
{
    partial class DataRecover
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
            this.DataRecoverLabel = new System.Windows.Forms.Label();
            this.SelectActionLabel = new System.Windows.Forms.Label();
            this.ShowTipLink = new System.Windows.Forms.LinkLabel();
            this.SecretKeyInput = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ShowDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // DataRecoverLabel
            // 
            this.DataRecoverLabel.AutoSize = true;
            this.DataRecoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DataRecoverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.DataRecoverLabel.Location = new System.Drawing.Point(51, 83);
            this.DataRecoverLabel.Name = "DataRecoverLabel";
            this.DataRecoverLabel.Size = new System.Drawing.Size(428, 40);
            this.DataRecoverLabel.TabIndex = 14;
            this.DataRecoverLabel.Text = "Восстановление данных";
            // 
            // SelectActionLabel
            // 
            this.SelectActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SelectActionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SelectActionLabel.Location = new System.Drawing.Point(143, 135);
            this.SelectActionLabel.Name = "SelectActionLabel";
            this.SelectActionLabel.Size = new System.Drawing.Size(245, 23);
            this.SelectActionLabel.TabIndex = 15;
            this.SelectActionLabel.Text = "Введите ваш секретный ключ";
            this.SelectActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowTipLink
            // 
            this.ShowTipLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ShowTipLink.AutoSize = true;
            this.ShowTipLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ShowTipLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ShowTipLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ShowTipLink.Location = new System.Drawing.Point(153, 277);
            this.ShowTipLink.Name = "ShowTipLink";
            this.ShowTipLink.Size = new System.Drawing.Size(220, 17);
            this.ShowTipLink.TabIndex = 16;
            this.ShowTipLink.TabStop = true;
            this.ShowTipLink.Text = "Что такое секретный ключ?";
            this.ShowTipLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ShowTipLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowTipLink_LinkClicked);
            // 
            // SecretKeyInput
            // 
            this.SecretKeyInput.Location = new System.Drawing.Point(146, 180);
            this.SecretKeyInput.Name = "SecretKeyInput";
            this.SecretKeyInput.Size = new System.Drawing.Size(238, 20);
            this.SecretKeyInput.TabIndex = 17;
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(222, 24);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(87, 44);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            // 
            // ShowDataButton
            // 
            this.ShowDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.ShowDataButton.FlatAppearance.BorderSize = 0;
            this.ShowDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ShowDataButton.ForeColor = System.Drawing.Color.White;
            this.ShowDataButton.Location = new System.Drawing.Point(193, 217);
            this.ShowDataButton.Name = "ShowDataButton";
            this.ShowDataButton.Size = new System.Drawing.Size(140, 36);
            this.ShowDataButton.TabIndex = 18;
            this.ShowDataButton.Text = "Показать";
            this.ShowDataButton.UseVisualStyleBackColor = false;
            // 
            // DataRecover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(531, 329);
            this.Controls.Add(this.ShowDataButton);
            this.Controls.Add(this.SecretKeyInput);
            this.Controls.Add(this.ShowTipLink);
            this.Controls.Add(this.SelectActionLabel);
            this.Controls.Add(this.DataRecoverLabel);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DataRecover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агенство недвижимости - Восстановление данных";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label DataRecoverLabel;
        private System.Windows.Forms.Label SelectActionLabel;
        private System.Windows.Forms.LinkLabel ShowTipLink;
        private System.Windows.Forms.TextBox SecretKeyInput;
        private System.Windows.Forms.Button ShowDataButton;
    }
}