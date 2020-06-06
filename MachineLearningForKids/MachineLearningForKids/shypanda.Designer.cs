namespace MachineLearningForKids
{
    partial class shypanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shypanda));
            this.pictureBoxWebCam = new System.Windows.Forms.PictureBox();
            this.pictureBoxSnapShot = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonTakeSnapShot = new System.Windows.Forms.Button();
            this.button_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnapShot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWebCam
            // 
            this.pictureBoxWebCam.Location = new System.Drawing.Point(12, 52);
            this.pictureBoxWebCam.Name = "pictureBoxWebCam";
            this.pictureBoxWebCam.Size = new System.Drawing.Size(640, 360);
            this.pictureBoxWebCam.TabIndex = 0;
            this.pictureBoxWebCam.TabStop = false;
            // 
            // pictureBoxSnapShot
            // 
            this.pictureBoxSnapShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSnapShot.Location = new System.Drawing.Point(686, 90);
            this.pictureBoxSnapShot.Name = "pictureBoxSnapShot";
            this.pictureBoxSnapShot.Size = new System.Drawing.Size(234, 219);
            this.pictureBoxSnapShot.TabIndex = 1;
            this.pictureBoxSnapShot.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelResult.Location = new System.Drawing.Point(686, 63);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(234, 23);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "No Face Detected";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTakeSnapShot
            // 
            this.buttonTakeSnapShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeSnapShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTakeSnapShot.Location = new System.Drawing.Point(687, 344);
            this.buttonTakeSnapShot.Name = "buttonTakeSnapShot";
            this.buttonTakeSnapShot.Size = new System.Drawing.Size(233, 66);
            this.buttonTakeSnapShot.TabIndex = 3;
            this.buttonTakeSnapShot.Text = "Predict My Emo";
            this.buttonTakeSnapShot.UseVisualStyleBackColor = true;
            this.buttonTakeSnapShot.Click += new System.EventHandler(this.buttonTakeSnapShot_Click);
            // 
            // button_geri
            // 
            this.button_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_geri.Image = ((System.Drawing.Image)(resources.GetObject("button_geri.Image")));
            this.button_geri.Location = new System.Drawing.Point(887, 4);
            this.button_geri.Margin = new System.Windows.Forms.Padding(2);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(61, 58);
            this.button_geri.TabIndex = 5;
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // shypanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(956, 423);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.buttonTakeSnapShot);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.pictureBoxSnapShot);
            this.Controls.Add(this.pictureBoxWebCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "shypanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.shypanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnapShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxWebCam;
        private System.Windows.Forms.PictureBox pictureBoxSnapShot;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonTakeSnapShot;
        private System.Windows.Forms.Button button_geri;
    }
}