namespace MachineLearningForKids
{
    partial class titanic
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
            this.tabControlTitanic = new System.Windows.Forms.TabControl();
            this.tabPagePrediction = new System.Windows.Forms.TabPage();
            this.labelTitanicResult = new System.Windows.Forms.Label();
            this.groupBoxFeatures = new System.Windows.Forms.GroupBox();
            this.labelForEmbarked = new System.Windows.Forms.Label();
            this.labelForTicketFare = new System.Windows.Forms.Label();
            this.labelforParentChild = new System.Windows.Forms.Label();
            this.labelForSiblings = new System.Windows.Forms.Label();
            this.labelForAge = new System.Windows.Forms.Label();
            this.labelForGender = new System.Windows.Forms.Label();
            this.labelForTicketClass = new System.Windows.Forms.Label();
            this.buttonPrediction = new System.Windows.Forms.Button();
            this.comboBoxEmbarked = new System.Windows.Forms.ComboBox();
            this.comboBoxFare = new System.Windows.Forms.ComboBox();
            this.comboBoxParentChild = new System.Windows.Forms.ComboBox();
            this.comboBoxSiblings = new System.Windows.Forms.ComboBox();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxTicketClass = new System.Windows.Forms.ComboBox();
            this.tabPageTrain = new System.Windows.Forms.TabPage();
            this.labelRecordWarning = new System.Windows.Forms.Label();
            this.labelRecordCount = new System.Windows.Forms.Label();
            this.buttonTitanicTrain = new System.Windows.Forms.Button();
            this.buttonRestoreData = new System.Windows.Forms.Button();
            this.dataGridViewTitanicData = new System.Windows.Forms.DataGridView();
            this.groupBoxAddFeatures = new System.Windows.Forms.GroupBox();
            this.labelForAddSurvived = new System.Windows.Forms.Label();
            this.comboBoxAddSurvived = new System.Windows.Forms.ComboBox();
            this.labelForAddEmbarked = new System.Windows.Forms.Label();
            this.labelForAddTiketFare = new System.Windows.Forms.Label();
            this.labelForAddparentChild = new System.Windows.Forms.Label();
            this.labelForAddSiblings = new System.Windows.Forms.Label();
            this.labelForAddAge = new System.Windows.Forms.Label();
            this.labelAddForGender = new System.Windows.Forms.Label();
            this.labelForAddTicketClass = new System.Windows.Forms.Label();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.comboBoxAddEmbarked = new System.Windows.Forms.ComboBox();
            this.comboBoxAddFare = new System.Windows.Forms.ComboBox();
            this.comboBoxAddParentChild = new System.Windows.Forms.ComboBox();
            this.comboBoxAddSiblings = new System.Windows.Forms.ComboBox();
            this.comboBoxAddAge = new System.Windows.Forms.ComboBox();
            this.comboBoxAddGender = new System.Windows.Forms.ComboBox();
            this.comboBoxAddTicketClass = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitanicBackGround = new System.Windows.Forms.PictureBox();
            this.tabControlTitanic.SuspendLayout();
            this.tabPagePrediction.SuspendLayout();
            this.groupBoxFeatures.SuspendLayout();
            this.tabPageTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitanicData)).BeginInit();
            this.groupBoxAddFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitanicBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTitanic
            // 
            this.tabControlTitanic.Controls.Add(this.tabPagePrediction);
            this.tabControlTitanic.Controls.Add(this.tabPageTrain);
            this.tabControlTitanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlTitanic.Location = new System.Drawing.Point(12, 12);
            this.tabControlTitanic.Name = "tabControlTitanic";
            this.tabControlTitanic.SelectedIndex = 0;
            this.tabControlTitanic.Size = new System.Drawing.Size(842, 507);
            this.tabControlTitanic.TabIndex = 1;
            // 
            // tabPagePrediction
            // 
            this.tabPagePrediction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPagePrediction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagePrediction.Controls.Add(this.labelTitanicResult);
            this.tabPagePrediction.Controls.Add(this.pictureBoxResult);
            this.tabPagePrediction.Controls.Add(this.pictureBoxTitanicBackGround);
            this.tabPagePrediction.Controls.Add(this.groupBoxFeatures);
            this.tabPagePrediction.Location = new System.Drawing.Point(4, 33);
            this.tabPagePrediction.Name = "tabPagePrediction";
            this.tabPagePrediction.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrediction.Size = new System.Drawing.Size(834, 470);
            this.tabPagePrediction.TabIndex = 0;
            this.tabPagePrediction.Text = "Prediction";
            // 
            // labelTitanicResult
            // 
            this.labelTitanicResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelTitanicResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitanicResult.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitanicResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitanicResult.Location = new System.Drawing.Point(537, 68);
            this.labelTitanicResult.Name = "labelTitanicResult";
            this.labelTitanicResult.Size = new System.Drawing.Size(266, 39);
            this.labelTitanicResult.TabIndex = 3;
            this.labelTitanicResult.Text = "?";
            this.labelTitanicResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitanicResult.Visible = false;
            // 
            // groupBoxFeatures
            // 
            this.groupBoxFeatures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxFeatures.Controls.Add(this.labelForEmbarked);
            this.groupBoxFeatures.Controls.Add(this.labelForTicketFare);
            this.groupBoxFeatures.Controls.Add(this.labelforParentChild);
            this.groupBoxFeatures.Controls.Add(this.labelForSiblings);
            this.groupBoxFeatures.Controls.Add(this.labelForAge);
            this.groupBoxFeatures.Controls.Add(this.labelForGender);
            this.groupBoxFeatures.Controls.Add(this.labelForTicketClass);
            this.groupBoxFeatures.Controls.Add(this.buttonPrediction);
            this.groupBoxFeatures.Controls.Add(this.comboBoxEmbarked);
            this.groupBoxFeatures.Controls.Add(this.comboBoxFare);
            this.groupBoxFeatures.Controls.Add(this.comboBoxParentChild);
            this.groupBoxFeatures.Controls.Add(this.comboBoxSiblings);
            this.groupBoxFeatures.Controls.Add(this.comboBoxAge);
            this.groupBoxFeatures.Controls.Add(this.comboBoxGender);
            this.groupBoxFeatures.Controls.Add(this.comboBoxTicketClass);
            this.groupBoxFeatures.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFeatures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFeatures.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFeatures.Name = "groupBoxFeatures";
            this.groupBoxFeatures.Size = new System.Drawing.Size(322, 464);
            this.groupBoxFeatures.TabIndex = 0;
            this.groupBoxFeatures.TabStop = false;
            this.groupBoxFeatures.Text = "Prediction Features";
            // 
            // labelForEmbarked
            // 
            this.labelForEmbarked.AutoSize = true;
            this.labelForEmbarked.BackColor = System.Drawing.Color.Transparent;
            this.labelForEmbarked.Location = new System.Drawing.Point(39, 278);
            this.labelForEmbarked.Name = "labelForEmbarked";
            this.labelForEmbarked.Size = new System.Drawing.Size(90, 20);
            this.labelForEmbarked.TabIndex = 14;
            this.labelForEmbarked.Text = "Embarked :";
            // 
            // labelForTicketFare
            // 
            this.labelForTicketFare.AutoSize = true;
            this.labelForTicketFare.BackColor = System.Drawing.Color.Transparent;
            this.labelForTicketFare.Location = new System.Drawing.Point(32, 237);
            this.labelForTicketFare.Name = "labelForTicketFare";
            this.labelForTicketFare.Size = new System.Drawing.Size(96, 20);
            this.labelForTicketFare.TabIndex = 13;
            this.labelForTicketFare.Text = "Ticket Fare :";
            // 
            // labelforParentChild
            // 
            this.labelforParentChild.AutoSize = true;
            this.labelforParentChild.BackColor = System.Drawing.Color.Transparent;
            this.labelforParentChild.Location = new System.Drawing.Point(13, 200);
            this.labelforParentChild.Name = "labelforParentChild";
            this.labelforParentChild.Size = new System.Drawing.Size(116, 20);
            this.labelforParentChild.TabIndex = 12;
            this.labelforParentChild.Text = "ParentOrChild :";
            // 
            // labelForSiblings
            // 
            this.labelForSiblings.AutoSize = true;
            this.labelForSiblings.BackColor = System.Drawing.Color.Transparent;
            this.labelForSiblings.Location = new System.Drawing.Point(57, 161);
            this.labelForSiblings.Name = "labelForSiblings";
            this.labelForSiblings.Size = new System.Drawing.Size(72, 20);
            this.labelForSiblings.TabIndex = 11;
            this.labelForSiblings.Text = "Siblings :";
            // 
            // labelForAge
            // 
            this.labelForAge.AutoSize = true;
            this.labelForAge.BackColor = System.Drawing.Color.Transparent;
            this.labelForAge.Location = new System.Drawing.Point(83, 122);
            this.labelForAge.Name = "labelForAge";
            this.labelForAge.Size = new System.Drawing.Size(46, 20);
            this.labelForAge.TabIndex = 10;
            this.labelForAge.Text = "Age :";
            // 
            // labelForGender
            // 
            this.labelForGender.AutoSize = true;
            this.labelForGender.BackColor = System.Drawing.Color.Transparent;
            this.labelForGender.Location = new System.Drawing.Point(58, 84);
            this.labelForGender.Name = "labelForGender";
            this.labelForGender.Size = new System.Drawing.Size(71, 20);
            this.labelForGender.TabIndex = 9;
            this.labelForGender.Text = "Gender :";
            // 
            // labelForTicketClass
            // 
            this.labelForTicketClass.AutoSize = true;
            this.labelForTicketClass.BackColor = System.Drawing.Color.Transparent;
            this.labelForTicketClass.Location = new System.Drawing.Point(27, 43);
            this.labelForTicketClass.Name = "labelForTicketClass";
            this.labelForTicketClass.Size = new System.Drawing.Size(102, 20);
            this.labelForTicketClass.TabIndex = 8;
            this.labelForTicketClass.Text = "Ticket Class :";
            // 
            // buttonPrediction
            // 
            this.buttonPrediction.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrediction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPrediction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrediction.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrediction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrediction.Location = new System.Drawing.Point(43, 345);
            this.buttonPrediction.Name = "buttonPrediction";
            this.buttonPrediction.Size = new System.Drawing.Size(253, 65);
            this.buttonPrediction.TabIndex = 7;
            this.buttonPrediction.Text = "Make Prediction";
            this.buttonPrediction.UseVisualStyleBackColor = false;
            this.buttonPrediction.Click += new System.EventHandler(this.buttonPrediction_Click);
            // 
            // comboBoxEmbarked
            // 
            this.comboBoxEmbarked.FormattingEnabled = true;
            this.comboBoxEmbarked.Location = new System.Drawing.Point(142, 274);
            this.comboBoxEmbarked.Name = "comboBoxEmbarked";
            this.comboBoxEmbarked.Size = new System.Drawing.Size(173, 28);
            this.comboBoxEmbarked.TabIndex = 6;
            // 
            // comboBoxFare
            // 
            this.comboBoxFare.FormattingEnabled = true;
            this.comboBoxFare.Location = new System.Drawing.Point(142, 235);
            this.comboBoxFare.Name = "comboBoxFare";
            this.comboBoxFare.Size = new System.Drawing.Size(174, 28);
            this.comboBoxFare.TabIndex = 5;
            // 
            // comboBoxParentChild
            // 
            this.comboBoxParentChild.FormattingEnabled = true;
            this.comboBoxParentChild.Location = new System.Drawing.Point(142, 196);
            this.comboBoxParentChild.Name = "comboBoxParentChild";
            this.comboBoxParentChild.Size = new System.Drawing.Size(175, 28);
            this.comboBoxParentChild.TabIndex = 4;
            // 
            // comboBoxSiblings
            // 
            this.comboBoxSiblings.FormattingEnabled = true;
            this.comboBoxSiblings.Location = new System.Drawing.Point(142, 157);
            this.comboBoxSiblings.Name = "comboBoxSiblings";
            this.comboBoxSiblings.Size = new System.Drawing.Size(175, 28);
            this.comboBoxSiblings.TabIndex = 3;
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Location = new System.Drawing.Point(142, 118);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAge.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(142, 79);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(175, 28);
            this.comboBoxGender.TabIndex = 1;
            // 
            // comboBoxTicketClass
            // 
            this.comboBoxTicketClass.FormattingEnabled = true;
            this.comboBoxTicketClass.Location = new System.Drawing.Point(142, 40);
            this.comboBoxTicketClass.Name = "comboBoxTicketClass";
            this.comboBoxTicketClass.Size = new System.Drawing.Size(175, 28);
            this.comboBoxTicketClass.TabIndex = 0;
            // 
            // tabPageTrain
            // 
            this.tabPageTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPageTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTrain.Controls.Add(this.labelRecordWarning);
            this.tabPageTrain.Controls.Add(this.labelRecordCount);
            this.tabPageTrain.Controls.Add(this.buttonTitanicTrain);
            this.tabPageTrain.Controls.Add(this.buttonRestoreData);
            this.tabPageTrain.Controls.Add(this.dataGridViewTitanicData);
            this.tabPageTrain.Controls.Add(this.groupBoxAddFeatures);
            this.tabPageTrain.Location = new System.Drawing.Point(4, 33);
            this.tabPageTrain.Name = "tabPageTrain";
            this.tabPageTrain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrain.Size = new System.Drawing.Size(834, 470);
            this.tabPageTrain.TabIndex = 1;
            this.tabPageTrain.Text = "Training";
            // 
            // labelRecordWarning
            // 
            this.labelRecordWarning.AutoSize = true;
            this.labelRecordWarning.BackColor = System.Drawing.Color.White;
            this.labelRecordWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRecordWarning.ForeColor = System.Drawing.Color.Red;
            this.labelRecordWarning.Location = new System.Drawing.Point(634, 364);
            this.labelRecordWarning.Name = "labelRecordWarning";
            this.labelRecordWarning.Size = new System.Drawing.Size(194, 15);
            this.labelRecordWarning.TabIndex = 20;
            this.labelRecordWarning.Text = "Double Click On Record To Delete";
            // 
            // labelRecordCount
            // 
            this.labelRecordCount.AutoSize = true;
            this.labelRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.labelRecordCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRecordCount.Location = new System.Drawing.Point(331, 356);
            this.labelRecordCount.Name = "labelRecordCount";
            this.labelRecordCount.Size = new System.Drawing.Size(60, 24);
            this.labelRecordCount.TabIndex = 19;
            this.labelRecordCount.Text = "label1";
            // 
            // buttonTitanicTrain
            // 
            this.buttonTitanicTrain.BackColor = System.Drawing.Color.Transparent;
            this.buttonTitanicTrain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTitanicTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTitanicTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTitanicTrain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTitanicTrain.Location = new System.Drawing.Point(643, 395);
            this.buttonTitanicTrain.Name = "buttonTitanicTrain";
            this.buttonTitanicTrain.Size = new System.Drawing.Size(185, 65);
            this.buttonTitanicTrain.TabIndex = 18;
            this.buttonTitanicTrain.Text = "Train";
            this.buttonTitanicTrain.UseVisualStyleBackColor = false;
            this.buttonTitanicTrain.Click += new System.EventHandler(this.buttonTitanicTrain_Click);
            // 
            // buttonRestoreData
            // 
            this.buttonRestoreData.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestoreData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRestoreData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRestoreData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRestoreData.Location = new System.Drawing.Point(331, 395);
            this.buttonRestoreData.Name = "buttonRestoreData";
            this.buttonRestoreData.Size = new System.Drawing.Size(185, 65);
            this.buttonRestoreData.TabIndex = 17;
            this.buttonRestoreData.Text = "Restore All To Default";
            this.buttonRestoreData.UseVisualStyleBackColor = false;
            this.buttonRestoreData.Click += new System.EventHandler(this.buttonRestoreData_Click);
            // 
            // dataGridViewTitanicData
            // 
            this.dataGridViewTitanicData.AllowUserToAddRows = false;
            this.dataGridViewTitanicData.AllowUserToDeleteRows = false;
            this.dataGridViewTitanicData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTitanicData.Location = new System.Drawing.Point(331, 6);
            this.dataGridViewTitanicData.Name = "dataGridViewTitanicData";
            this.dataGridViewTitanicData.ReadOnly = true;
            this.dataGridViewTitanicData.RowHeadersVisible = false;
            this.dataGridViewTitanicData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTitanicData.Size = new System.Drawing.Size(497, 347);
            this.dataGridViewTitanicData.TabIndex = 2;
            this.dataGridViewTitanicData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTitanicData_CellContentDoubleClick);
            // 
            // groupBoxAddFeatures
            // 
            this.groupBoxAddFeatures.Controls.Add(this.labelForAddSurvived);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddSurvived);
            this.groupBoxAddFeatures.Controls.Add(this.labelForAddEmbarked);
            this.groupBoxAddFeatures.Controls.Add(this.labelForAddTiketFare);
            this.groupBoxAddFeatures.Controls.Add(this.labelForAddparentChild);
            this.groupBoxAddFeatures.Controls.Add(this.labelForAddSiblings);
            this.groupBoxAddFeatures.Controls.Add(this.labelForAddAge);
            this.groupBoxAddFeatures.Controls.Add(this.labelAddForGender);
            this.groupBoxAddFeatures.Controls.Add(this.labelForAddTicketClass);
            this.groupBoxAddFeatures.Controls.Add(this.buttonAddData);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddEmbarked);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddFare);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddParentChild);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddSiblings);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddAge);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddGender);
            this.groupBoxAddFeatures.Controls.Add(this.comboBoxAddTicketClass);
            this.groupBoxAddFeatures.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxAddFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAddFeatures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxAddFeatures.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAddFeatures.Name = "groupBoxAddFeatures";
            this.groupBoxAddFeatures.Size = new System.Drawing.Size(322, 464);
            this.groupBoxAddFeatures.TabIndex = 1;
            this.groupBoxAddFeatures.TabStop = false;
            this.groupBoxAddFeatures.Text = "Prediction Features";
            // 
            // labelForAddSurvived
            // 
            this.labelForAddSurvived.AutoSize = true;
            this.labelForAddSurvived.Location = new System.Drawing.Point(38, 315);
            this.labelForAddSurvived.Name = "labelForAddSurvived";
            this.labelForAddSurvived.Size = new System.Drawing.Size(77, 20);
            this.labelForAddSurvived.TabIndex = 16;
            this.labelForAddSurvived.Text = "Survived :";
            // 
            // comboBoxAddSurvived
            // 
            this.comboBoxAddSurvived.FormattingEnabled = true;
            this.comboBoxAddSurvived.Location = new System.Drawing.Point(141, 312);
            this.comboBoxAddSurvived.Name = "comboBoxAddSurvived";
            this.comboBoxAddSurvived.Size = new System.Drawing.Size(173, 28);
            this.comboBoxAddSurvived.TabIndex = 15;
            // 
            // labelForAddEmbarked
            // 
            this.labelForAddEmbarked.AutoSize = true;
            this.labelForAddEmbarked.Location = new System.Drawing.Point(39, 277);
            this.labelForAddEmbarked.Name = "labelForAddEmbarked";
            this.labelForAddEmbarked.Size = new System.Drawing.Size(90, 20);
            this.labelForAddEmbarked.TabIndex = 14;
            this.labelForAddEmbarked.Text = "Embarked :";
            // 
            // labelForAddTiketFare
            // 
            this.labelForAddTiketFare.AutoSize = true;
            this.labelForAddTiketFare.Location = new System.Drawing.Point(33, 238);
            this.labelForAddTiketFare.Name = "labelForAddTiketFare";
            this.labelForAddTiketFare.Size = new System.Drawing.Size(96, 20);
            this.labelForAddTiketFare.TabIndex = 13;
            this.labelForAddTiketFare.Text = "Ticket Fare :";
            // 
            // labelForAddparentChild
            // 
            this.labelForAddparentChild.AutoSize = true;
            this.labelForAddparentChild.Location = new System.Drawing.Point(13, 198);
            this.labelForAddparentChild.Name = "labelForAddparentChild";
            this.labelForAddparentChild.Size = new System.Drawing.Size(116, 20);
            this.labelForAddparentChild.TabIndex = 12;
            this.labelForAddparentChild.Text = "ParentOrChild :";
            // 
            // labelForAddSiblings
            // 
            this.labelForAddSiblings.AutoSize = true;
            this.labelForAddSiblings.Location = new System.Drawing.Point(57, 159);
            this.labelForAddSiblings.Name = "labelForAddSiblings";
            this.labelForAddSiblings.Size = new System.Drawing.Size(72, 20);
            this.labelForAddSiblings.TabIndex = 11;
            this.labelForAddSiblings.Text = "Siblings :";
            // 
            // labelForAddAge
            // 
            this.labelForAddAge.AutoSize = true;
            this.labelForAddAge.Location = new System.Drawing.Point(83, 120);
            this.labelForAddAge.Name = "labelForAddAge";
            this.labelForAddAge.Size = new System.Drawing.Size(46, 20);
            this.labelForAddAge.TabIndex = 10;
            this.labelForAddAge.Text = "Age :";
            // 
            // labelAddForGender
            // 
            this.labelAddForGender.AutoSize = true;
            this.labelAddForGender.Location = new System.Drawing.Point(58, 83);
            this.labelAddForGender.Name = "labelAddForGender";
            this.labelAddForGender.Size = new System.Drawing.Size(71, 20);
            this.labelAddForGender.TabIndex = 9;
            this.labelAddForGender.Text = "Gender :";
            // 
            // labelForAddTicketClass
            // 
            this.labelForAddTicketClass.AutoSize = true;
            this.labelForAddTicketClass.Location = new System.Drawing.Point(27, 44);
            this.labelForAddTicketClass.Name = "labelForAddTicketClass";
            this.labelForAddTicketClass.Size = new System.Drawing.Size(102, 20);
            this.labelForAddTicketClass.TabIndex = 8;
            this.labelForAddTicketClass.Text = "Ticket Class :";
            // 
            // buttonAddData
            // 
            this.buttonAddData.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.buttonAddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddData.Location = new System.Drawing.Point(87, 373);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(173, 65);
            this.buttonAddData.TabIndex = 7;
            this.buttonAddData.Text = "Add Data";
            this.buttonAddData.UseVisualStyleBackColor = false;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // comboBoxAddEmbarked
            // 
            this.comboBoxAddEmbarked.FormattingEnabled = true;
            this.comboBoxAddEmbarked.Location = new System.Drawing.Point(142, 274);
            this.comboBoxAddEmbarked.Name = "comboBoxAddEmbarked";
            this.comboBoxAddEmbarked.Size = new System.Drawing.Size(173, 28);
            this.comboBoxAddEmbarked.TabIndex = 6;
            // 
            // comboBoxAddFare
            // 
            this.comboBoxAddFare.FormattingEnabled = true;
            this.comboBoxAddFare.Location = new System.Drawing.Point(142, 235);
            this.comboBoxAddFare.Name = "comboBoxAddFare";
            this.comboBoxAddFare.Size = new System.Drawing.Size(174, 28);
            this.comboBoxAddFare.TabIndex = 5;
            // 
            // comboBoxAddParentChild
            // 
            this.comboBoxAddParentChild.FormattingEnabled = true;
            this.comboBoxAddParentChild.Location = new System.Drawing.Point(142, 196);
            this.comboBoxAddParentChild.Name = "comboBoxAddParentChild";
            this.comboBoxAddParentChild.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAddParentChild.TabIndex = 4;
            // 
            // comboBoxAddSiblings
            // 
            this.comboBoxAddSiblings.FormattingEnabled = true;
            this.comboBoxAddSiblings.Location = new System.Drawing.Point(142, 157);
            this.comboBoxAddSiblings.Name = "comboBoxAddSiblings";
            this.comboBoxAddSiblings.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAddSiblings.TabIndex = 3;
            // 
            // comboBoxAddAge
            // 
            this.comboBoxAddAge.FormattingEnabled = true;
            this.comboBoxAddAge.Location = new System.Drawing.Point(142, 118);
            this.comboBoxAddAge.Name = "comboBoxAddAge";
            this.comboBoxAddAge.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAddAge.TabIndex = 2;
            // 
            // comboBoxAddGender
            // 
            this.comboBoxAddGender.FormattingEnabled = true;
            this.comboBoxAddGender.Location = new System.Drawing.Point(142, 79);
            this.comboBoxAddGender.Name = "comboBoxAddGender";
            this.comboBoxAddGender.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAddGender.TabIndex = 1;
            // 
            // comboBoxAddTicketClass
            // 
            this.comboBoxAddTicketClass.FormattingEnabled = true;
            this.comboBoxAddTicketClass.Location = new System.Drawing.Point(142, 40);
            this.comboBoxAddTicketClass.Name = "comboBoxAddTicketClass";
            this.comboBoxAddTicketClass.Size = new System.Drawing.Size(175, 28);
            this.comboBoxAddTicketClass.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(829, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 7;
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
            this.labelHeader.Location = new System.Drawing.Point(336, 7);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(337, 27);
            this.labelHeader.TabIndex = 8;
            this.labelHeader.Text = "TITANIC SURVIVAL PREDICTION";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxResult.BackgroundImage = global::MachineLearningForKids.Properties.Resources.Rose;
            this.pictureBoxResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxResult.Location = new System.Drawing.Point(333, 27);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(170, 122);
            this.pictureBoxResult.TabIndex = 2;
            this.pictureBoxResult.TabStop = false;
            this.pictureBoxResult.Visible = false;
            // 
            // pictureBoxTitanicBackGround
            // 
            this.pictureBoxTitanicBackGround.BackgroundImage = global::MachineLearningForKids.Properties.Resources.TitanicBackground;
            this.pictureBoxTitanicBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTitanicBackGround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTitanicBackGround.Location = new System.Drawing.Point(333, 155);
            this.pictureBoxTitanicBackGround.Name = "pictureBoxTitanicBackGround";
            this.pictureBoxTitanicBackGround.Size = new System.Drawing.Size(495, 297);
            this.pictureBoxTitanicBackGround.TabIndex = 1;
            this.pictureBoxTitanicBackGround.TabStop = false;
            // 
            // titanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 541);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControlTitanic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "titanic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitanicForm";
            this.Load += new System.EventHandler(this.titanic_Load);
            this.tabControlTitanic.ResumeLayout(false);
            this.tabPagePrediction.ResumeLayout(false);
            this.groupBoxFeatures.ResumeLayout(false);
            this.groupBoxFeatures.PerformLayout();
            this.tabPageTrain.ResumeLayout(false);
            this.tabPageTrain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitanicData)).EndInit();
            this.groupBoxAddFeatures.ResumeLayout(false);
            this.groupBoxAddFeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitanicBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFeatures;
        private System.Windows.Forms.TabControl tabControlTitanic;
        private System.Windows.Forms.TabPage tabPagePrediction;
        private System.Windows.Forms.TabPage tabPageTrain;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxTicketClass;
        private System.Windows.Forms.ComboBox comboBoxEmbarked;
        private System.Windows.Forms.ComboBox comboBoxFare;
        private System.Windows.Forms.ComboBox comboBoxParentChild;
        private System.Windows.Forms.ComboBox comboBoxSiblings;
        private System.Windows.Forms.PictureBox pictureBoxTitanicBackGround;
        private System.Windows.Forms.Label labelTitanicResult;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button buttonPrediction;
        private System.Windows.Forms.Label labelForSiblings;
        private System.Windows.Forms.Label labelForAge;
        private System.Windows.Forms.Label labelForGender;
        private System.Windows.Forms.Label labelForTicketClass;
        private System.Windows.Forms.Label labelForTicketFare;
        private System.Windows.Forms.Label labelforParentChild;
        private System.Windows.Forms.Label labelForEmbarked;
        private System.Windows.Forms.DataGridView dataGridViewTitanicData;
        private System.Windows.Forms.GroupBox groupBoxAddFeatures;
        private System.Windows.Forms.Button buttonRestoreData;
        private System.Windows.Forms.Label labelForAddSurvived;
        private System.Windows.Forms.ComboBox comboBoxAddSurvived;
        private System.Windows.Forms.Label labelForAddEmbarked;
        private System.Windows.Forms.Label labelForAddTiketFare;
        private System.Windows.Forms.Label labelForAddparentChild;
        private System.Windows.Forms.Label labelForAddSiblings;
        private System.Windows.Forms.Label labelForAddAge;
        private System.Windows.Forms.Label labelAddForGender;
        private System.Windows.Forms.Label labelForAddTicketClass;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.ComboBox comboBoxAddEmbarked;
        private System.Windows.Forms.ComboBox comboBoxAddFare;
        private System.Windows.Forms.ComboBox comboBoxAddParentChild;
        private System.Windows.Forms.ComboBox comboBoxAddSiblings;
        private System.Windows.Forms.ComboBox comboBoxAddAge;
        private System.Windows.Forms.ComboBox comboBoxAddGender;
        private System.Windows.Forms.ComboBox comboBoxAddTicketClass;
        private System.Windows.Forms.Button buttonTitanicTrain;
        private System.Windows.Forms.Label labelRecordCount;
        private System.Windows.Forms.Label labelRecordWarning;
    }
}