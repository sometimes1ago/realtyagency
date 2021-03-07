namespace RealtyAgency
{
    partial class DeleteAccount
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
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.SelectActionLabel = new System.Windows.Forms.Label();
            this.SecretKeyInput = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShowTipLink = new System.Windows.Forms.LinkLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmationLabel
            // 
            this.ConfirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ConfirmationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ConfirmationLabel.Location = new System.Drawing.Point(38, 72);
            this.ConfirmationLabel.Name = "ConfirmationLabel";
            this.ConfirmationLabel.Size = new System.Drawing.Size(485, 62);
            this.ConfirmationLabel.TabIndex = 4;
            this.ConfirmationLabel.Text = "Вы действительно хотите удалить вашу учетную запись?";
            this.ConfirmationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectActionLabel
            // 
            this.SelectActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.SelectActionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.SelectActionLabel.Location = new System.Drawing.Point(175, 151);
            this.SelectActionLabel.Name = "SelectActionLabel";
            this.SelectActionLabel.Size = new System.Drawing.Size(209, 23);
            this.SelectActionLabel.TabIndex = 5;
            this.SelectActionLabel.Text = "Введите секретный ключ";
            this.SelectActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecretKeyInput
            // 
            this.SecretKeyInput.Location = new System.Drawing.Point(179, 192);
            this.SecretKeyInput.Name = "SecretKeyInput";
            this.SecretKeyInput.Size = new System.Drawing.Size(205, 20);
            this.SecretKeyInput.TabIndex = 6;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(234)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(229, 235);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 34);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShowTipLink
            // 
            this.ShowTipLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ShowTipLink.AutoSize = true;
            this.ShowTipLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ShowTipLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ShowTipLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ShowTipLink.Location = new System.Drawing.Point(172, 289);
            this.ShowTipLink.Name = "ShowTipLink";
            this.ShowTipLink.Size = new System.Drawing.Size(220, 17);
            this.ShowTipLink.TabIndex = 17;
            this.ShowTipLink.TabStop = true;
            this.ShowTipLink.Text = "Что такое секретный ключ?";
            this.ShowTipLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ShowTipLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowTipLink_LinkClicked);
            // 
            // Logo
            // 
            this.Logo.Image = global::RealtyAgency.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(241, 13);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(87, 44);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 18;
            this.Logo.TabStop = false;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(557, 341);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ShowTipLink);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SecretKeyInput);
            this.Controls.Add(this.SelectActionLabel);
            this.Controls.Add(this.ConfirmationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление аккаунта";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConfirmationLabel;
        private System.Windows.Forms.Label SelectActionLabel;
        private System.Windows.Forms.TextBox SecretKeyInput;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.LinkLabel ShowTipLink;
        private System.Windows.Forms.PictureBox Logo;
    }
}