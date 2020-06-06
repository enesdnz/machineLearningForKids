namespace MachineLearningForKids
{
    partial class faceLock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faceLock));
            this.btn_tani = new System.Windows.Forms.Button();
            this.btn_egit = new System.Windows.Forms.Button();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.groupBox_egitim = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_dur = new System.Windows.Forms.Button();
            this.panel_ust = new System.Windows.Forms.Panel();
            this.label_baslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.groupBox_egitim.SuspendLayout();
            this.panel_ust.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tani
            // 
            this.btn_tani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tani.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tani.Location = new System.Drawing.Point(231, 383);
            this.btn_tani.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tani.Name = "btn_tani";
            this.btn_tani.Size = new System.Drawing.Size(156, 46);
            this.btn_tani.TabIndex = 0;
            this.btn_tani.Text = "Yüz Tanımayı Başlat";
            this.btn_tani.UseVisualStyleBackColor = true;
            this.btn_tani.Click += new System.EventHandler(this.btn_tani_Click);
            // 
            // btn_egit
            // 
            this.btn_egit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_egit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_egit.Location = new System.Drawing.Point(390, 108);
            this.btn_egit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_egit.Name = "btn_egit";
            this.btn_egit.Size = new System.Drawing.Size(70, 83);
            this.btn_egit.TabIndex = 1;
            this.btn_egit.Text = "Modeli Eğit";
            this.btn_egit.UseVisualStyleBackColor = true;
            this.btn_egit.Click += new System.EventHandler(this.btn_egit_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxAd.Location = new System.Drawing.Point(161, 51);
            this.textBoxAd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAd.MaxLength = 20;
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(136, 26);
            this.textBoxAd.TabIndex = 3;
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(73, 108);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(307, 242);
            this.cameraBox.TabIndex = 4;
            this.cameraBox.TabStop = false;
            // 
            // lbl_ad
            // 
            this.lbl_ad.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(10, 41);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(147, 52);
            this.lbl_ad.TabIndex = 5;
            this.lbl_ad.Text = "Seni Tanımamız İçin Bize Adını Söyle : ";
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.Location = new System.Drawing.Point(73, 108);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(307, 242);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_icon.TabIndex = 6;
            this.pictureBox_icon.TabStop = false;
            // 
            // groupBox_egitim
            // 
            this.groupBox_egitim.Controls.Add(this.lbl_ad);
            this.groupBox_egitim.Controls.Add(this.textBoxAd);
            this.groupBox_egitim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_egitim.Location = new System.Drawing.Point(70, 439);
            this.groupBox_egitim.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_egitim.Name = "groupBox_egitim";
            this.groupBox_egitim.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_egitim.Size = new System.Drawing.Size(307, 91);
            this.groupBox_egitim.TabIndex = 7;
            this.groupBox_egitim.TabStop = false;
            this.groupBox_egitim.Text = "Eğitim";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cikis.FlatAppearance.BorderSize = 0;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(416, 7);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 44);
            this.btn_cikis.TabIndex = 8;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_dur
            // 
            this.btn_dur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dur.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dur.Location = new System.Drawing.Point(66, 382);
            this.btn_dur.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dur.Name = "btn_dur";
            this.btn_dur.Size = new System.Drawing.Size(156, 46);
            this.btn_dur.TabIndex = 9;
            this.btn_dur.Text = "Yüz Tanımayı Durdur";
            this.btn_dur.UseVisualStyleBackColor = true;
            this.btn_dur.Click += new System.EventHandler(this.btn_dur_Click);
            // 
            // panel_ust
            // 
            this.panel_ust.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel_ust.Controls.Add(this.label_baslik);
            this.panel_ust.Location = new System.Drawing.Point(0, 0);
            this.panel_ust.Margin = new System.Windows.Forms.Padding(2);
            this.panel_ust.Name = "panel_ust";
            this.panel_ust.Size = new System.Drawing.Size(474, 58);
            this.panel_ust.TabIndex = 10;
            // 
            // label_baslik
            // 
            this.label_baslik.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baslik.Location = new System.Drawing.Point(167, 16);
            this.label_baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(125, 36);
            this.label_baslik.TabIndex = 11;
            this.label_baslik.Text = "Face Lock";
            // 
            // faceLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(471, 593);
            this.ControlBox = false;
            this.Controls.Add(this.btn_dur);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_egit);
            this.Controls.Add(this.pictureBox_icon);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.btn_tani);
            this.Controls.Add(this.groupBox_egitim);
            this.Controls.Add(this.panel_ust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "faceLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Lock";
            this.Load += new System.EventHandler(this.faceLock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.groupBox_egitim.ResumeLayout(false);
            this.groupBox_egitim.PerformLayout();
            this.panel_ust.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tani;
        private System.Windows.Forms.Button btn_egit;
        private System.Windows.Forms.TextBox textBoxAd;
        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.GroupBox groupBox_egitim;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_dur;
        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Label label_baslik;
    }
}