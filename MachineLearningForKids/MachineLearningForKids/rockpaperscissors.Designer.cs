namespace MachineLearningForKids
{
    partial class rockpaperscissors
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
            this.tabControlRPS = new System.Windows.Forms.TabControl();
            this.tabPageRPSPlay = new System.Windows.Forms.TabPage();
            this.labelAISelection = new System.Windows.Forms.Label();
            this.labelPredictionResult = new System.Windows.Forms.Label();
            this.pictureBoxWinner = new System.Windows.Forms.PictureBox();
            this.labelNames = new System.Windows.Forms.Label();
            this.pictureBoxAI = new System.Windows.Forms.PictureBox();
            this.labelCountDown = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxSnapShot = new System.Windows.Forms.PictureBox();
            this.tabPageTrain = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.labelForPanelHeaders = new System.Windows.Forms.Label();
            this.buttonTrainRPS = new System.Windows.Forms.Button();
            this.panelScissors = new System.Windows.Forms.Panel();
            this.panelPaper = new System.Windows.Forms.Panel();
            this.panelRock = new System.Windows.Forms.Panel();
            this.buttonAddImageWithLabel = new System.Windows.Forms.Button();
            this.comboBoxClassLabel = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxWebcam = new System.Windows.Forms.PictureBox();
            this.timerRPS = new System.Windows.Forms.Timer(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tabControlRPS.SuspendLayout();
            this.tabPageRPSPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnapShot)).BeginInit();
            this.tabPageTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRPS
            // 
            this.tabControlRPS.Controls.Add(this.tabPageRPSPlay);
            this.tabControlRPS.Controls.Add(this.tabPageTrain);
            this.tabControlRPS.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlRPS.Location = new System.Drawing.Point(669, 0);
            this.tabControlRPS.Name = "tabControlRPS";
            this.tabControlRPS.SelectedIndex = 0;
            this.tabControlRPS.Size = new System.Drawing.Size(570, 540);
            this.tabControlRPS.TabIndex = 2;
            // 
            // tabPageRPSPlay
            // 
            this.tabPageRPSPlay.BackColor = System.Drawing.Color.Navy;
            this.tabPageRPSPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageRPSPlay.Controls.Add(this.labelAISelection);
            this.tabPageRPSPlay.Controls.Add(this.labelPredictionResult);
            this.tabPageRPSPlay.Controls.Add(this.pictureBoxWinner);
            this.tabPageRPSPlay.Controls.Add(this.labelNames);
            this.tabPageRPSPlay.Controls.Add(this.pictureBoxAI);
            this.tabPageRPSPlay.Controls.Add(this.labelCountDown);
            this.tabPageRPSPlay.Controls.Add(this.buttonPlay);
            this.tabPageRPSPlay.Controls.Add(this.pictureBoxSnapShot);
            this.tabPageRPSPlay.Location = new System.Drawing.Point(4, 36);
            this.tabPageRPSPlay.Name = "tabPageRPSPlay";
            this.tabPageRPSPlay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRPSPlay.Size = new System.Drawing.Size(562, 500);
            this.tabPageRPSPlay.TabIndex = 0;
            this.tabPageRPSPlay.Text = "Play";
            // 
            // labelAISelection
            // 
            this.labelAISelection.BackColor = System.Drawing.Color.White;
            this.labelAISelection.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAISelection.ForeColor = System.Drawing.Color.Red;
            this.labelAISelection.Location = new System.Drawing.Point(320, 352);
            this.labelAISelection.Name = "labelAISelection";
            this.labelAISelection.Size = new System.Drawing.Size(196, 19);
            this.labelAISelection.TabIndex = 13;
            this.labelAISelection.Text = "AI Selection: Rock";
            this.labelAISelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAISelection.Visible = false;
            // 
            // labelPredictionResult
            // 
            this.labelPredictionResult.BackColor = System.Drawing.Color.White;
            this.labelPredictionResult.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPredictionResult.ForeColor = System.Drawing.Color.Red;
            this.labelPredictionResult.Location = new System.Drawing.Point(37, 352);
            this.labelPredictionResult.Name = "labelPredictionResult";
            this.labelPredictionResult.Size = new System.Drawing.Size(196, 19);
            this.labelPredictionResult.TabIndex = 12;
            this.labelPredictionResult.Text = "AI Prediction : Rock";
            this.labelPredictionResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPredictionResult.Visible = false;
            // 
            // pictureBoxWinner
            // 
            this.pictureBoxWinner.BackgroundImage = global::MachineLearningForKids.Properties.Resources.Winner;
            this.pictureBoxWinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWinner.Location = new System.Drawing.Point(349, 395);
            this.pictureBoxWinner.Name = "pictureBoxWinner";
            this.pictureBoxWinner.Size = new System.Drawing.Size(146, 90);
            this.pictureBoxWinner.TabIndex = 11;
            this.pictureBoxWinner.TabStop = false;
            this.pictureBoxWinner.Visible = false;
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.BackColor = System.Drawing.Color.Transparent;
            this.labelNames.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNames.Location = new System.Drawing.Point(129, 11);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(295, 27);
            this.labelNames.TabIndex = 10;
            this.labelNames.Text = "YOU          VS            A.I.";
            // 
            // pictureBoxAI
            // 
            this.pictureBoxAI.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAI.Location = new System.Drawing.Point(316, 41);
            this.pictureBoxAI.Name = "pictureBoxAI";
            this.pictureBoxAI.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxAI.TabIndex = 4;
            this.pictureBoxAI.TabStop = false;
            // 
            // labelCountDown
            // 
            this.labelCountDown.AutoSize = true;
            this.labelCountDown.BackColor = System.Drawing.Color.Transparent;
            this.labelCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCountDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCountDown.Location = new System.Drawing.Point(253, 299);
            this.labelCountDown.Name = "labelCountDown";
            this.labelCountDown.Size = new System.Drawing.Size(50, 54);
            this.labelCountDown.TabIndex = 3;
            this.labelCountDown.Text = "3";
            this.labelCountDown.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlay.Location = new System.Drawing.Point(220, 395);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(108, 90);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBoxSnapShot
            // 
            this.pictureBoxSnapShot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSnapShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSnapShot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSnapShot.Location = new System.Drawing.Point(33, 41);
            this.pictureBoxSnapShot.Name = "pictureBoxSnapShot";
            this.pictureBoxSnapShot.Size = new System.Drawing.Size(200, 300);
            this.pictureBoxSnapShot.TabIndex = 1;
            this.pictureBoxSnapShot.TabStop = false;
            // 
            // tabPageTrain
            // 
            this.tabPageTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTrain.Controls.Add(this.button1);
            this.tabPageTrain.Controls.Add(this.labelForPanelHeaders);
            this.tabPageTrain.Controls.Add(this.buttonTrainRPS);
            this.tabPageTrain.Controls.Add(this.panelScissors);
            this.tabPageTrain.Controls.Add(this.panelPaper);
            this.tabPageTrain.Controls.Add(this.panelRock);
            this.tabPageTrain.Controls.Add(this.buttonAddImageWithLabel);
            this.tabPageTrain.Controls.Add(this.comboBoxClassLabel);
            this.tabPageTrain.Location = new System.Drawing.Point(4, 36);
            this.tabPageTrain.Name = "tabPageTrain";
            this.tabPageTrain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrain.Size = new System.Drawing.Size(562, 500);
            this.tabPageTrain.TabIndex = 1;
            this.tabPageTrain.Text = "Train";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(20, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelForPanelHeaders
            // 
            this.labelForPanelHeaders.BackColor = System.Drawing.Color.Transparent;
            this.labelForPanelHeaders.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForPanelHeaders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForPanelHeaders.Location = new System.Drawing.Point(6, 64);
            this.labelForPanelHeaders.Name = "labelForPanelHeaders";
            this.labelForPanelHeaders.Size = new System.Drawing.Size(527, 27);
            this.labelForPanelHeaders.TabIndex = 10;
            this.labelForPanelHeaders.Text = "    ROCK                 PAPER                SCISSORS";
            this.labelForPanelHeaders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTrainRPS
            // 
            this.buttonTrainRPS.BackColor = System.Drawing.Color.Transparent;
            this.buttonTrainRPS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTrainRPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrainRPS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTrainRPS.Location = new System.Drawing.Point(206, 446);
            this.buttonTrainRPS.Name = "buttonTrainRPS";
            this.buttonTrainRPS.Size = new System.Drawing.Size(339, 38);
            this.buttonTrainRPS.TabIndex = 7;
            this.buttonTrainRPS.Text = "Train DataSet";
            this.buttonTrainRPS.UseVisualStyleBackColor = false;
            this.buttonTrainRPS.Click += new System.EventHandler(this.buttonTrainRPS_Click);
            // 
            // panelScissors
            // 
            this.panelScissors.AutoScroll = true;
            this.panelScissors.BackColor = System.Drawing.Color.Transparent;
            this.panelScissors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelScissors.Location = new System.Drawing.Point(408, 105);
            this.panelScissors.Name = "panelScissors";
            this.panelScissors.Size = new System.Drawing.Size(125, 322);
            this.panelScissors.TabIndex = 5;
            // 
            // panelPaper
            // 
            this.panelPaper.AutoScroll = true;
            this.panelPaper.BackColor = System.Drawing.Color.Transparent;
            this.panelPaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPaper.Location = new System.Drawing.Point(210, 105);
            this.panelPaper.Name = "panelPaper";
            this.panelPaper.Size = new System.Drawing.Size(125, 322);
            this.panelPaper.TabIndex = 4;
            // 
            // panelRock
            // 
            this.panelRock.AutoScroll = true;
            this.panelRock.BackColor = System.Drawing.Color.Transparent;
            this.panelRock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRock.Location = new System.Drawing.Point(20, 105);
            this.panelRock.Name = "panelRock";
            this.panelRock.Size = new System.Drawing.Size(125, 322);
            this.panelRock.TabIndex = 3;
            // 
            // buttonAddImageWithLabel
            // 
            this.buttonAddImageWithLabel.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddImageWithLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAddImageWithLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddImageWithLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddImageWithLabel.Location = new System.Drawing.Point(234, 11);
            this.buttonAddImageWithLabel.Name = "buttonAddImageWithLabel";
            this.buttonAddImageWithLabel.Size = new System.Drawing.Size(322, 35);
            this.buttonAddImageWithLabel.TabIndex = 2;
            this.buttonAddImageWithLabel.Text = "Add Image With Label";
            this.buttonAddImageWithLabel.UseVisualStyleBackColor = false;
            this.buttonAddImageWithLabel.Click += new System.EventHandler(this.buttonAddImageWithLabel_Click);
            // 
            // comboBoxClassLabel
            // 
            this.comboBoxClassLabel.FormattingEnabled = true;
            this.comboBoxClassLabel.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissors"});
            this.comboBoxClassLabel.Location = new System.Drawing.Point(6, 11);
            this.comboBoxClassLabel.Name = "comboBoxClassLabel";
            this.comboBoxClassLabel.Size = new System.Drawing.Size(210, 35);
            this.comboBoxClassLabel.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::MachineLearningForKids.Properties.Resources.RPS_Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 413);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(640, 127);
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxWebcam
            // 
            this.pictureBoxWebcam.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWebcam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxWebcam.Location = new System.Drawing.Point(12, 47);
            this.pictureBoxWebcam.Name = "pictureBoxWebcam";
            this.pictureBoxWebcam.Size = new System.Drawing.Size(640, 360);
            this.pictureBoxWebcam.TabIndex = 0;
            this.pictureBoxWebcam.TabStop = false;
            this.pictureBoxWebcam.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxWebcam_Paint);
            // 
            // timerRPS
            // 
            this.timerRPS.Interval = 1000;
            this.timerRPS.Tick += new System.EventHandler(this.timerRPS_Tick);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(1210, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeader.Location = new System.Drawing.Point(190, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(238, 27);
            this.labelHeader.TabIndex = 9;
            this.labelHeader.Text = "ROCK PAPER SCISSORS";
            // 
            // rockpaperscissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 561);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.tabControlRPS);
            this.Controls.Add(this.pictureBoxWebcam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rockpaperscissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RockPaperScissorsForm";
            this.Load += new System.EventHandler(this.rockpaperscissors_Load);
            this.tabControlRPS.ResumeLayout(false);
            this.tabPageRPSPlay.ResumeLayout(false);
            this.tabPageRPSPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnapShot)).EndInit();
            this.tabPageTrain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxWebcam;
        private System.Windows.Forms.PictureBox pictureBoxSnapShot;
        private System.Windows.Forms.TabControl tabControlRPS;
        private System.Windows.Forms.TabPage tabPageRPSPlay;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TabPage tabPageTrain;
        private System.Windows.Forms.Timer timerRPS;
        private System.Windows.Forms.Label labelCountDown;
        private System.Windows.Forms.Button buttonTrainRPS;
        private System.Windows.Forms.Panel panelScissors;
        private System.Windows.Forms.Panel panelPaper;
        private System.Windows.Forms.Panel panelRock;
        private System.Windows.Forms.Button buttonAddImageWithLabel;
        private System.Windows.Forms.ComboBox comboBoxClassLabel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxAI;
        private System.Windows.Forms.Label labelForPanelHeaders;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.PictureBox pictureBoxWinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPredictionResult;
        private System.Windows.Forms.Label labelAISelection;
    }
}