namespace MachineLearningForKids
{
    partial class imageToTextGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imageToTextGame));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pictureBoxMetin = new System.Windows.Forms.PictureBox();
            this.btnDonustur = new System.Windows.Forms.Button();
            this.richTextBoxMetin = new System.Windows.Forms.RichTextBox();
            this.ofdGorsel = new System.Windows.Forms.OpenFileDialog();
            this.panel_Ust = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMetin)).BeginInit();
            this.panel_Ust.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblBaslik.Location = new System.Drawing.Point(390, 188);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(344, 25);
            this.lblBaslik.TabIndex = 12;
            this.lblBaslik.Text = "Sen resmini yükle biz yazıya dökelim!";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(767, 0);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(72, 77);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBoxMetin
            // 
            this.pictureBoxMetin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMetin.Image")));
            this.pictureBoxMetin.Location = new System.Drawing.Point(35, 213);
            this.pictureBoxMetin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxMetin.Name = "pictureBoxMetin";
            this.pictureBoxMetin.Size = new System.Drawing.Size(273, 315);
            this.pictureBoxMetin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMetin.TabIndex = 10;
            this.pictureBoxMetin.TabStop = false;
            // 
            // btnDonustur
            // 
            this.btnDonustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDonustur.FlatAppearance.BorderSize = 0;
            this.btnDonustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonustur.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonustur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDonustur.Location = new System.Drawing.Point(405, 536);
            this.btnDonustur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonustur.Name = "btnDonustur";
            this.btnDonustur.Size = new System.Drawing.Size(282, 100);
            this.btnDonustur.TabIndex = 8;
            this.btnDonustur.Text = "Lütfen Yazıya Çevirmemizi İstediğiniz Resmi Seçiniz";
            this.btnDonustur.UseVisualStyleBackColor = false;
            this.btnDonustur.Click += new System.EventHandler(this.btnDonustur_Click);
            // 
            // richTextBoxMetin
            // 
            this.richTextBoxMetin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxMetin.Enabled = false;
            this.richTextBoxMetin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxMetin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBoxMetin.Location = new System.Drawing.Point(325, 228);
            this.richTextBoxMetin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxMetin.Name = "richTextBoxMetin";
            this.richTextBoxMetin.Size = new System.Drawing.Size(462, 289);
            this.richTextBoxMetin.TabIndex = 7;
            this.richTextBoxMetin.Text = "";
            // 
            // ofdGorsel
            // 
            this.ofdGorsel.FileName = "ofdGorsel";
            // 
            // panel_Ust
            // 
            this.panel_Ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_Ust.Controls.Add(this.labelBaslik);
            this.panel_Ust.Controls.Add(this.btnCikis);
            this.panel_Ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ust.Location = new System.Drawing.Point(0, 0);
            this.panel_Ust.Name = "panel_Ust";
            this.panel_Ust.Size = new System.Drawing.Size(839, 77);
            this.panel_Ust.TabIndex = 13;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaslik.Location = new System.Drawing.Point(252, 25);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(344, 52);
            this.labelBaslik.TabIndex = 12;
            this.labelBaslik.Text = "IMAGE TO TEXT";
            // 
            // imageToTextGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 708);
            this.Controls.Add(this.panel_Ust);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.pictureBoxMetin);
            this.Controls.Add(this.btnDonustur);
            this.Controls.Add(this.richTextBoxMetin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "imageToTextGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "imageToTextGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMetin)).EndInit();
            this.panel_Ust.ResumeLayout(false);
            this.panel_Ust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBoxMetin;
        private System.Windows.Forms.Button btnDonustur;
        private System.Windows.Forms.RichTextBox richTextBoxMetin;
        private System.Windows.Forms.OpenFileDialog ofdGorsel;
        private System.Windows.Forms.Panel panel_Ust;
        private System.Windows.Forms.Label labelBaslik;
    }
}