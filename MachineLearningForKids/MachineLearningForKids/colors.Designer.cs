namespace MachineLearningForKids
{
    partial class colors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colors));
            this.color_lbl = new System.Windows.Forms.Label();
            this.panel_Baslik = new System.Windows.Forms.Panel();
            this.button_geri = new System.Windows.Forms.Button();
            this.label_baslik = new System.Windows.Forms.Label();
            this.pictureBoxWebCam = new System.Windows.Forms.PictureBox();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.panel_Baslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // color_lbl
            // 
            this.color_lbl.AutoSize = true;
            this.color_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.color_lbl.ForeColor = System.Drawing.Color.LightCoral;
            this.color_lbl.Location = new System.Drawing.Point(350, 517);
            this.color_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color_lbl.Name = "color_lbl";
            this.color_lbl.Size = new System.Drawing.Size(79, 22);
            this.color_lbl.TabIndex = 1;
            this.color_lbl.Text = "COLOR";
            // 
            // panel_Baslik
            // 
            this.panel_Baslik.BackColor = System.Drawing.Color.Salmon;
            this.panel_Baslik.Controls.Add(this.button_geri);
            this.panel_Baslik.Controls.Add(this.label_baslik);
            this.panel_Baslik.Location = new System.Drawing.Point(1, 1);
            this.panel_Baslik.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Baslik.Name = "panel_Baslik";
            this.panel_Baslik.Size = new System.Drawing.Size(830, 62);
            this.panel_Baslik.TabIndex = 2;
            // 
            // button_geri
            // 
            this.button_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_geri.Image = ((System.Drawing.Image)(resources.GetObject("button_geri.Image")));
            this.button_geri.Location = new System.Drawing.Point(721, 2);
            this.button_geri.Margin = new System.Windows.Forms.Padding(2);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(61, 58);
            this.button_geri.TabIndex = 4;
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // label_baslik
            // 
            this.label_baslik.AutoSize = true;
            this.label_baslik.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baslik.Location = new System.Drawing.Point(328, 17);
            this.label_baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(140, 44);
            this.label_baslik.TabIndex = 3;
            this.label_baslik.Text = "COLORS";
            // 
            // pictureBoxWebCam
            // 
            this.pictureBoxWebCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWebCam.Location = new System.Drawing.Point(125, 94);
            this.pictureBoxWebCam.Name = "pictureBoxWebCam";
            this.pictureBoxWebCam.Size = new System.Drawing.Size(561, 406);
            this.pictureBoxWebCam.TabIndex = 3;
            this.pictureBoxWebCam.TabStop = false;
            // 
            // timerColor
            // 
            this.timerColor.Enabled = true;
            this.timerColor.Interval = 250;
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 574);
            this.Controls.Add(this.pictureBoxWebCam);
            this.Controls.Add(this.panel_Baslik);
            this.Controls.Add(this.color_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "colors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "colors";
            this.Load += new System.EventHandler(this.colors_Load);
            this.panel_Baslik.ResumeLayout(false);
            this.panel_Baslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label color_lbl;
        private System.Windows.Forms.Panel panel_Baslik;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.PictureBox pictureBoxWebCam;
        private System.Windows.Forms.Timer timerColor;
    }
}