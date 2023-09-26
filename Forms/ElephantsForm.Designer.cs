namespace ZooMangementSystem
{
    partial class ElephantsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElephantsForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocumentLions = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogLions = new System.Windows.Forms.PrintPreviewDialog();
            this.AgeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaveLions = new System.Windows.Forms.Button();
            this.PrintElephant = new System.Windows.Forms.Button();
            this.AddElephant = new System.Windows.Forms.Button();
            this.RemoveElephant = new System.Windows.Forms.Button();
            this.LoadDataLions = new System.Windows.Forms.Button();
            this.dataGridViewElephants = new System.Windows.Forms.DataGridView();
            this.LionIDChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElephantNameChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElephantAgeChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElephantGenderChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElephantColorChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElephantInfancyChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElephantTrunkLengtheChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElephantInfancyComboBox = new System.Windows.Forms.ComboBox();
            this.ElephantGenderComboBox = new System.Windows.Forms.ComboBox();
            this.ElephantColorTextBox = new System.Windows.Forms.TextBox();
            this.ElephantAgeTextBox = new System.Windows.Forms.TextBox();
            this.ElephantNameTextBox = new System.Windows.Forms.TextBox();
            this.trunkLength = new System.Windows.Forms.Label();
            this.ElephantInfancyStatus = new System.Windows.Forms.Label();
            this.ElephantColor = new System.Windows.Forms.Label();
            this.ElephantGender = new System.Windows.Forms.Label();
            this.ElephantAge = new System.Windows.Forms.Label();
            this.ElephantName = new System.Windows.Forms.Label();
            this.MammalsButtonElephant = new System.Windows.Forms.Button();
            this.HomeButtonElephant = new System.Windows.Forms.Button();
            this.ElephantTrunkLengthTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalElephants = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElephants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocumentLions
            // 
            this.printDocumentLions.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentLions_PrintPage);
            // 
            // printPreviewDialogLions
            // 
            this.printPreviewDialogLions.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogLions.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogLions.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogLions.Document = this.printDocumentLions;
            this.printPreviewDialogLions.Enabled = true;
            this.printPreviewDialogLions.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogLions.Icon")));
            this.printPreviewDialogLions.Name = "printPreviewDialogLions";
            this.printPreviewDialogLions.Visible = false;
            // 
            // AgeError
            // 
            this.AgeError.ContainerControl = this;
            // 
            // SaveLions
            // 
            this.SaveLions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLions.Location = new System.Drawing.Point(990, 378);
            this.SaveLions.Name = "SaveLions";
            this.SaveLions.Size = new System.Drawing.Size(142, 35);
            this.SaveLions.TabIndex = 39;
            this.SaveLions.Text = "Save";
            this.SaveLions.UseVisualStyleBackColor = true;
            this.SaveLions.Click += new System.EventHandler(this.SaveLions_Click);
            // 
            // PrintElephant
            // 
            this.PrintElephant.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintElephant.Location = new System.Drawing.Point(990, 326);
            this.PrintElephant.Name = "PrintElephant";
            this.PrintElephant.Size = new System.Drawing.Size(142, 35);
            this.PrintElephant.TabIndex = 38;
            this.PrintElephant.Text = "Print";
            this.PrintElephant.UseVisualStyleBackColor = true;
            this.PrintElephant.Click += new System.EventHandler(this.PrintElephant_Click);
            // 
            // AddElephant
            // 
            this.AddElephant.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddElephant.Location = new System.Drawing.Point(990, 218);
            this.AddElephant.Name = "AddElephant";
            this.AddElephant.Size = new System.Drawing.Size(142, 35);
            this.AddElephant.TabIndex = 37;
            this.AddElephant.Text = "Add";
            this.AddElephant.UseVisualStyleBackColor = true;
            this.AddElephant.Click += new System.EventHandler(this.AddElephant_Click);
            this.AddElephant.MouseLeave += new System.EventHandler(this.AddElephant_MouseLeave);
            this.AddElephant.MouseHover += new System.EventHandler(this.AddElephant_MouseHover);
            // 
            // RemoveElephant
            // 
            this.RemoveElephant.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveElephant.Location = new System.Drawing.Point(990, 272);
            this.RemoveElephant.Name = "RemoveElephant";
            this.RemoveElephant.Size = new System.Drawing.Size(142, 35);
            this.RemoveElephant.TabIndex = 36;
            this.RemoveElephant.Text = "Remove";
            this.RemoveElephant.UseVisualStyleBackColor = true;
            this.RemoveElephant.Click += new System.EventHandler(this.RemoveElephant_Click);
            this.RemoveElephant.MouseLeave += new System.EventHandler(this.RemoveElephant_MouseLeave);
            this.RemoveElephant.MouseHover += new System.EventHandler(this.RemoveElephant_MouseHover);
            // 
            // LoadDataLions
            // 
            this.LoadDataLions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataLions.Location = new System.Drawing.Point(990, 434);
            this.LoadDataLions.Name = "LoadDataLions";
            this.LoadDataLions.Size = new System.Drawing.Size(142, 35);
            this.LoadDataLions.TabIndex = 40;
            this.LoadDataLions.Text = "Load";
            this.LoadDataLions.UseVisualStyleBackColor = true;
            this.LoadDataLions.Click += new System.EventHandler(this.LoadDataLions_Click);
            // 
            // dataGridViewElephants
            // 
            this.dataGridViewElephants.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewElephants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElephants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LionIDChart,
            this.ElephantNameChart,
            this.ElephantAgeChart,
            this.ElephantGenderChart,
            this.ElephantColorChart,
            this.ElephantInfancyChart,
            this.ElephantTrunkLengtheChart});
            this.dataGridViewElephants.Location = new System.Drawing.Point(12, 195);
            this.dataGridViewElephants.Name = "dataGridViewElephants";
            this.dataGridViewElephants.RowHeadersWidth = 62;
            this.dataGridViewElephants.RowTemplate.Height = 28;
            this.dataGridViewElephants.Size = new System.Drawing.Size(964, 372);
            this.dataGridViewElephants.TabIndex = 35;
            // 
            // LionIDChart
            // 
            this.LionIDChart.HeaderText = "ID";
            this.LionIDChart.MinimumWidth = 8;
            this.LionIDChart.Name = "LionIDChart";
            this.LionIDChart.Width = 150;
            // 
            // ElephantNameChart
            // 
            this.ElephantNameChart.HeaderText = "Name";
            this.ElephantNameChart.MinimumWidth = 8;
            this.ElephantNameChart.Name = "ElephantNameChart";
            this.ElephantNameChart.Width = 150;
            // 
            // ElephantAgeChart
            // 
            this.ElephantAgeChart.HeaderText = "Age";
            this.ElephantAgeChart.MinimumWidth = 8;
            this.ElephantAgeChart.Name = "ElephantAgeChart";
            this.ElephantAgeChart.Width = 150;
            // 
            // ElephantGenderChart
            // 
            this.ElephantGenderChart.HeaderText = "Gender";
            this.ElephantGenderChart.MinimumWidth = 8;
            this.ElephantGenderChart.Name = "ElephantGenderChart";
            this.ElephantGenderChart.Width = 150;
            // 
            // ElephantColorChart
            // 
            this.ElephantColorChart.HeaderText = "Color";
            this.ElephantColorChart.MinimumWidth = 8;
            this.ElephantColorChart.Name = "ElephantColorChart";
            this.ElephantColorChart.Width = 150;
            // 
            // ElephantInfancyChart
            // 
            this.ElephantInfancyChart.HeaderText = "Infancy";
            this.ElephantInfancyChart.MinimumWidth = 8;
            this.ElephantInfancyChart.Name = "ElephantInfancyChart";
            this.ElephantInfancyChart.Width = 150;
            // 
            // ElephantTrunkLengtheChart
            // 
            this.ElephantTrunkLengtheChart.HeaderText = "Trunk Length";
            this.ElephantTrunkLengtheChart.MinimumWidth = 8;
            this.ElephantTrunkLengtheChart.Name = "ElephantTrunkLengtheChart";
            this.ElephantTrunkLengtheChart.Width = 150;
            // 
            // ElephantInfancyComboBox
            // 
            this.ElephantInfancyComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.ElephantInfancyComboBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantInfancyComboBox.FormattingEnabled = true;
            this.ElephantInfancyComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ElephantInfancyComboBox.Location = new System.Drawing.Point(444, 74);
            this.ElephantInfancyComboBox.Name = "ElephantInfancyComboBox";
            this.ElephantInfancyComboBox.Size = new System.Drawing.Size(169, 27);
            this.ElephantInfancyComboBox.TabIndex = 33;
            // 
            // ElephantGenderComboBox
            // 
            this.ElephantGenderComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.ElephantGenderComboBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantGenderComboBox.FormattingEnabled = true;
            this.ElephantGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ElephantGenderComboBox.Location = new System.Drawing.Point(92, 122);
            this.ElephantGenderComboBox.Name = "ElephantGenderComboBox";
            this.ElephantGenderComboBox.Size = new System.Drawing.Size(164, 27);
            this.ElephantGenderComboBox.TabIndex = 32;
            // 
            // ElephantColorTextBox
            // 
            this.ElephantColorTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantColorTextBox.Location = new System.Drawing.Point(446, 31);
            this.ElephantColorTextBox.Name = "ElephantColorTextBox";
            this.ElephantColorTextBox.Size = new System.Drawing.Size(168, 27);
            this.ElephantColorTextBox.TabIndex = 31;
            // 
            // ElephantAgeTextBox
            // 
            this.ElephantAgeTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantAgeTextBox.Location = new System.Drawing.Point(90, 75);
            this.ElephantAgeTextBox.Name = "ElephantAgeTextBox";
            this.ElephantAgeTextBox.Size = new System.Drawing.Size(168, 27);
            this.ElephantAgeTextBox.TabIndex = 30;
            this.ElephantAgeTextBox.TextChanged += new System.EventHandler(this.ElephantAgeTextBox_TextChanged);
            // 
            // ElephantNameTextBox
            // 
            this.ElephantNameTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ElephantNameTextBox.Location = new System.Drawing.Point(90, 34);
            this.ElephantNameTextBox.Name = "ElephantNameTextBox";
            this.ElephantNameTextBox.Size = new System.Drawing.Size(168, 27);
            this.ElephantNameTextBox.TabIndex = 29;
            this.ElephantNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ElephantNameTextBox.TextChanged += new System.EventHandler(this.LionNameTextBox_TextChanged);
            // 
            // trunkLength
            // 
            this.trunkLength.AutoSize = true;
            this.trunkLength.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trunkLength.Location = new System.Drawing.Point(314, 125);
            this.trunkLength.Name = "trunkLength";
            this.trunkLength.Size = new System.Drawing.Size(126, 19);
            this.trunkLength.TabIndex = 28;
            this.trunkLength.Text = "Trunk length(cm)";
            // 
            // ElephantInfancyStatus
            // 
            this.ElephantInfancyStatus.AutoSize = true;
            this.ElephantInfancyStatus.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantInfancyStatus.Location = new System.Drawing.Point(314, 75);
            this.ElephantInfancyStatus.Name = "ElephantInfancyStatus";
            this.ElephantInfancyStatus.Size = new System.Drawing.Size(59, 19);
            this.ElephantInfancyStatus.TabIndex = 27;
            this.ElephantInfancyStatus.Text = "Infancy";
            // 
            // ElephantColor
            // 
            this.ElephantColor.AutoSize = true;
            this.ElephantColor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantColor.Location = new System.Drawing.Point(314, 31);
            this.ElephantColor.Name = "ElephantColor";
            this.ElephantColor.Size = new System.Drawing.Size(45, 19);
            this.ElephantColor.TabIndex = 26;
            this.ElephantColor.Text = "Color";
            // 
            // ElephantGender
            // 
            this.ElephantGender.AutoSize = true;
            this.ElephantGender.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantGender.Location = new System.Drawing.Point(22, 125);
            this.ElephantGender.Name = "ElephantGender";
            this.ElephantGender.Size = new System.Drawing.Size(59, 19);
            this.ElephantGender.TabIndex = 25;
            this.ElephantGender.Text = "Gender";
            // 
            // ElephantAge
            // 
            this.ElephantAge.AutoSize = true;
            this.ElephantAge.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantAge.Location = new System.Drawing.Point(22, 80);
            this.ElephantAge.Name = "ElephantAge";
            this.ElephantAge.Size = new System.Drawing.Size(35, 19);
            this.ElephantAge.TabIndex = 24;
            this.ElephantAge.Text = "Age";
            // 
            // ElephantName
            // 
            this.ElephantName.AutoSize = true;
            this.ElephantName.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantName.Location = new System.Drawing.Point(22, 35);
            this.ElephantName.Name = "ElephantName";
            this.ElephantName.Size = new System.Drawing.Size(49, 19);
            this.ElephantName.TabIndex = 23;
            this.ElephantName.Text = "Name";
            // 
            // MammalsButtonElephant
            // 
            this.MammalsButtonElephant.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MammalsButtonElephant.Location = new System.Drawing.Point(990, 485);
            this.MammalsButtonElephant.Name = "MammalsButtonElephant";
            this.MammalsButtonElephant.Size = new System.Drawing.Size(142, 35);
            this.MammalsButtonElephant.TabIndex = 22;
            this.MammalsButtonElephant.Text = "Mammals";
            this.MammalsButtonElephant.UseVisualStyleBackColor = true;
            this.MammalsButtonElephant.Click += new System.EventHandler(this.MammalsButtonElephant_Click);
            // 
            // HomeButtonElephant
            // 
            this.HomeButtonElephant.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButtonElephant.Location = new System.Drawing.Point(990, 532);
            this.HomeButtonElephant.Name = "HomeButtonElephant";
            this.HomeButtonElephant.Size = new System.Drawing.Size(142, 35);
            this.HomeButtonElephant.TabIndex = 21;
            this.HomeButtonElephant.Text = "Home";
            this.HomeButtonElephant.UseVisualStyleBackColor = true;
            this.HomeButtonElephant.Click += new System.EventHandler(this.HomeButtonElephant_Click);
            // 
            // ElephantTrunkLengthTextBox
            // 
            this.ElephantTrunkLengthTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantTrunkLengthTextBox.Location = new System.Drawing.Point(446, 122);
            this.ElephantTrunkLengthTextBox.Name = "ElephantTrunkLengthTextBox";
            this.ElephantTrunkLengthTextBox.Size = new System.Drawing.Size(168, 27);
            this.ElephantTrunkLengthTextBox.TabIndex = 41;
            this.ElephantTrunkLengthTextBox.TextChanged += new System.EventHandler(this.ElephantTrunkLengthTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(966, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // TotalElephants
            // 
            this.TotalElephants.AutoSize = true;
            this.TotalElephants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalElephants.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalElephants.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotalElephants.Location = new System.Drawing.Point(734, 66);
            this.TotalElephants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalElephants.Name = "TotalElephants";
            this.TotalElephants.Size = new System.Drawing.Size(130, 46);
            this.TotalElephants.TabIndex = 43;
            this.TotalElephants.Text = "Total: 0";
            this.TotalElephants.Click += new System.EventHandler(this.TotalElephants_Click);
            // 
            // ElephantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1144, 588);
            this.Controls.Add(this.TotalElephants);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ElephantTrunkLengthTextBox);
            this.Controls.Add(this.SaveLions);
            this.Controls.Add(this.PrintElephant);
            this.Controls.Add(this.AddElephant);
            this.Controls.Add(this.RemoveElephant);
            this.Controls.Add(this.LoadDataLions);
            this.Controls.Add(this.dataGridViewElephants);
            this.Controls.Add(this.ElephantInfancyComboBox);
            this.Controls.Add(this.ElephantGenderComboBox);
            this.Controls.Add(this.ElephantColorTextBox);
            this.Controls.Add(this.ElephantAgeTextBox);
            this.Controls.Add(this.ElephantNameTextBox);
            this.Controls.Add(this.trunkLength);
            this.Controls.Add(this.ElephantInfancyStatus);
            this.Controls.Add(this.ElephantColor);
            this.Controls.Add(this.ElephantGender);
            this.Controls.Add(this.ElephantAge);
            this.Controls.Add(this.ElephantName);
            this.Controls.Add(this.MammalsButtonElephant);
            this.Controls.Add(this.HomeButtonElephant);
            this.Name = "ElephantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElephantsForm";
            ((System.ComponentModel.ISupportInitialize)(this.AgeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElephants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocumentLions;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogLions;
        private System.Windows.Forms.ErrorProvider AgeError;
        private System.Windows.Forms.Button SaveLions;
        private System.Windows.Forms.Button PrintElephant;
        private System.Windows.Forms.Button AddElephant;
        private System.Windows.Forms.Button RemoveElephant;
        private System.Windows.Forms.Button LoadDataLions;
        private System.Windows.Forms.DataGridView dataGridViewElephants;
        private System.Windows.Forms.ComboBox ElephantInfancyComboBox;
        private System.Windows.Forms.ComboBox ElephantGenderComboBox;
        private System.Windows.Forms.TextBox ElephantColorTextBox;
        private System.Windows.Forms.TextBox ElephantAgeTextBox;
        private System.Windows.Forms.TextBox ElephantNameTextBox;
        private System.Windows.Forms.Label trunkLength;
        private System.Windows.Forms.Label ElephantInfancyStatus;
        private System.Windows.Forms.Label ElephantColor;
        private System.Windows.Forms.Label ElephantGender;
        private System.Windows.Forms.Label ElephantAge;
        private System.Windows.Forms.Label ElephantName;
        private System.Windows.Forms.Button MammalsButtonElephant;
        private System.Windows.Forms.Button HomeButtonElephant;
        private System.Windows.Forms.TextBox ElephantTrunkLengthTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionIDChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElephantNameChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElephantAgeChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElephantGenderChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElephantColorChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElephantInfancyChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElephantTrunkLengtheChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TotalElephants;
    }
}