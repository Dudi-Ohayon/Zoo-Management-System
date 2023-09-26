namespace ZooMangementSystem
{
    partial class LionsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LionsForms));
            this.HomeButtonLions = new System.Windows.Forms.Button();
            this.MammalsButtonLions = new System.Windows.Forms.Button();
            this.LionName = new System.Windows.Forms.Label();
            this.LionAge = new System.Windows.Forms.Label();
            this.LionGender = new System.Windows.Forms.Label();
            this.LionColor = new System.Windows.Forms.Label();
            this.LionInfancyStatus = new System.Windows.Forms.Label();
            this.LionHaveMane = new System.Windows.Forms.Label();
            this.LionNameTextBox = new System.Windows.Forms.TextBox();
            this.LionAgeTextBox = new System.Windows.Forms.TextBox();
            this.LionColorTextBox = new System.Windows.Forms.TextBox();
            this.LionGenderComboBox = new System.Windows.Forms.ComboBox();
            this.LionInfancyComboBox = new System.Windows.Forms.ComboBox();
            this.LionHaveManeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LionIDChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LionNameChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LionAgeChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LionGenderChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LionColorChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LionInfancyChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LionHaveManeChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveLion = new System.Windows.Forms.Button();
            this.AddLion = new System.Windows.Forms.Button();
            this.PrintLions = new System.Windows.Forms.Button();
            this.SaveLions = new System.Windows.Forms.Button();
            this.AgeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.printPreviewDialogLions = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentLions = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LoadDataLions = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalLions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButtonLions
            // 
            this.HomeButtonLions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButtonLions.Location = new System.Drawing.Point(660, 352);
            this.HomeButtonLions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeButtonLions.Name = "HomeButtonLions";
            this.HomeButtonLions.Size = new System.Drawing.Size(95, 23);
            this.HomeButtonLions.TabIndex = 0;
            this.HomeButtonLions.Text = "Home";
            this.HomeButtonLions.UseVisualStyleBackColor = true;
            this.HomeButtonLions.Click += new System.EventHandler(this.HomeButtonLions_Click);
            // 
            // MammalsButtonLions
            // 
            this.MammalsButtonLions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MammalsButtonLions.Location = new System.Drawing.Point(660, 319);
            this.MammalsButtonLions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MammalsButtonLions.Name = "MammalsButtonLions";
            this.MammalsButtonLions.Size = new System.Drawing.Size(95, 23);
            this.MammalsButtonLions.TabIndex = 1;
            this.MammalsButtonLions.Text = "Mammals";
            this.MammalsButtonLions.UseVisualStyleBackColor = true;
            this.MammalsButtonLions.Click += new System.EventHandler(this.MammalsButtonLions_Click);
            // 
            // LionName
            // 
            this.LionName.AutoSize = true;
            this.LionName.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionName.Location = new System.Drawing.Point(15, 29);
            this.LionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LionName.Name = "LionName";
            this.LionName.Size = new System.Drawing.Size(34, 13);
            this.LionName.TabIndex = 2;
            this.LionName.Text = "Name";
            // 
            // LionAge
            // 
            this.LionAge.AutoSize = true;
            this.LionAge.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionAge.Location = new System.Drawing.Point(15, 57);
            this.LionAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LionAge.Name = "LionAge";
            this.LionAge.Size = new System.Drawing.Size(27, 13);
            this.LionAge.TabIndex = 3;
            this.LionAge.Text = "Age";
            // 
            // LionGender
            // 
            this.LionGender.AutoSize = true;
            this.LionGender.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionGender.Location = new System.Drawing.Point(15, 86);
            this.LionGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LionGender.Name = "LionGender";
            this.LionGender.Size = new System.Drawing.Size(46, 13);
            this.LionGender.TabIndex = 4;
            this.LionGender.Text = "Gender";
            // 
            // LionColor
            // 
            this.LionColor.AutoSize = true;
            this.LionColor.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionColor.Location = new System.Drawing.Point(209, 27);
            this.LionColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LionColor.Name = "LionColor";
            this.LionColor.Size = new System.Drawing.Size(37, 13);
            this.LionColor.TabIndex = 5;
            this.LionColor.Text = "Color";
            // 
            // LionInfancyStatus
            // 
            this.LionInfancyStatus.AutoSize = true;
            this.LionInfancyStatus.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionInfancyStatus.Location = new System.Drawing.Point(209, 56);
            this.LionInfancyStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LionInfancyStatus.Name = "LionInfancyStatus";
            this.LionInfancyStatus.Size = new System.Drawing.Size(46, 13);
            this.LionInfancyStatus.TabIndex = 6;
            this.LionInfancyStatus.Text = "Infancy";
            // 
            // LionHaveMane
            // 
            this.LionHaveMane.AutoSize = true;
            this.LionHaveMane.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionHaveMane.Location = new System.Drawing.Point(209, 86);
            this.LionHaveMane.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LionHaveMane.Name = "LionHaveMane";
            this.LionHaveMane.Size = new System.Drawing.Size(65, 13);
            this.LionHaveMane.TabIndex = 7;
            this.LionHaveMane.Text = "Have Mane";
            // 
            // LionNameTextBox
            // 
            this.LionNameTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.LionNameTextBox.Location = new System.Drawing.Point(60, 27);
            this.LionNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LionNameTextBox.Name = "LionNameTextBox";
            this.LionNameTextBox.Size = new System.Drawing.Size(113, 21);
            this.LionNameTextBox.TabIndex = 8;
            this.LionNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LionNameTextBox.TextChanged += new System.EventHandler(this.LionNameTextBox_TextChanged);
            // 
            // LionAgeTextBox
            // 
            this.LionAgeTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionAgeTextBox.Location = new System.Drawing.Point(60, 55);
            this.LionAgeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LionAgeTextBox.Name = "LionAgeTextBox";
            this.LionAgeTextBox.Size = new System.Drawing.Size(113, 21);
            this.LionAgeTextBox.TabIndex = 9;
            this.LionAgeTextBox.TextChanged += new System.EventHandler(this.LionAgeTextBox_TextChanged);
            // 
            // LionColorTextBox
            // 
            this.LionColorTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionColorTextBox.Location = new System.Drawing.Point(273, 26);
            this.LionColorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LionColorTextBox.Name = "LionColorTextBox";
            this.LionColorTextBox.Size = new System.Drawing.Size(113, 21);
            this.LionColorTextBox.TabIndex = 10;
            // 
            // LionGenderComboBox
            // 
            this.LionGenderComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.LionGenderComboBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionGenderComboBox.FormattingEnabled = true;
            this.LionGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.LionGenderComboBox.Location = new System.Drawing.Point(61, 84);
            this.LionGenderComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LionGenderComboBox.Name = "LionGenderComboBox";
            this.LionGenderComboBox.Size = new System.Drawing.Size(111, 21);
            this.LionGenderComboBox.TabIndex = 11;
            // 
            // LionInfancyComboBox
            // 
            this.LionInfancyComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.LionInfancyComboBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionInfancyComboBox.FormattingEnabled = true;
            this.LionInfancyComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.LionInfancyComboBox.Location = new System.Drawing.Point(273, 53);
            this.LionInfancyComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LionInfancyComboBox.Name = "LionInfancyComboBox";
            this.LionInfancyComboBox.Size = new System.Drawing.Size(113, 21);
            this.LionInfancyComboBox.TabIndex = 12;
            // 
            // LionHaveManeComboBox
            // 
            this.LionHaveManeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.LionHaveManeComboBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionHaveManeComboBox.FormattingEnabled = true;
            this.LionHaveManeComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.LionHaveManeComboBox.Location = new System.Drawing.Point(273, 84);
            this.LionHaveManeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LionHaveManeComboBox.Name = "LionHaveManeComboBox";
            this.LionHaveManeComboBox.Size = new System.Drawing.Size(113, 21);
            this.LionHaveManeComboBox.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LionIDChart,
            this.LionNameChart,
            this.LionAgeChart,
            this.LionGenderChart,
            this.LionColorChart,
            this.LionInfancyChart,
            this.LionHaveManeChart});
            this.dataGridView1.Location = new System.Drawing.Point(8, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(643, 242);
            this.dataGridView1.TabIndex = 14;
            // 
            // LionIDChart
            // 
            this.LionIDChart.HeaderText = "ID";
            this.LionIDChart.MinimumWidth = 8;
            this.LionIDChart.Name = "LionIDChart";
            this.LionIDChart.Width = 150;
            // 
            // LionNameChart
            // 
            this.LionNameChart.HeaderText = "Name";
            this.LionNameChart.MinimumWidth = 8;
            this.LionNameChart.Name = "LionNameChart";
            this.LionNameChart.Width = 150;
            // 
            // LionAgeChart
            // 
            this.LionAgeChart.HeaderText = "Age";
            this.LionAgeChart.MinimumWidth = 8;
            this.LionAgeChart.Name = "LionAgeChart";
            this.LionAgeChart.Width = 150;
            // 
            // LionGenderChart
            // 
            this.LionGenderChart.HeaderText = "Gender";
            this.LionGenderChart.MinimumWidth = 8;
            this.LionGenderChart.Name = "LionGenderChart";
            this.LionGenderChart.Width = 150;
            // 
            // LionColorChart
            // 
            this.LionColorChart.HeaderText = "Color";
            this.LionColorChart.MinimumWidth = 8;
            this.LionColorChart.Name = "LionColorChart";
            this.LionColorChart.Width = 150;
            // 
            // LionInfancyChart
            // 
            this.LionInfancyChart.HeaderText = "Infancy";
            this.LionInfancyChart.MinimumWidth = 8;
            this.LionInfancyChart.Name = "LionInfancyChart";
            this.LionInfancyChart.Width = 150;
            // 
            // LionHaveManeChart
            // 
            this.LionHaveManeChart.HeaderText = "Have Mane";
            this.LionHaveManeChart.MinimumWidth = 8;
            this.LionHaveManeChart.Name = "LionHaveManeChart";
            this.LionHaveManeChart.Width = 150;
            // 
            // RemoveLion
            // 
            this.RemoveLion.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveLion.Location = new System.Drawing.Point(660, 175);
            this.RemoveLion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveLion.Name = "RemoveLion";
            this.RemoveLion.Size = new System.Drawing.Size(95, 23);
            this.RemoveLion.TabIndex = 15;
            this.RemoveLion.Text = "Remove";
            this.RemoveLion.UseVisualStyleBackColor = true;
            this.RemoveLion.Click += new System.EventHandler(this.RemoveLion_Click);
            this.RemoveLion.MouseLeave += new System.EventHandler(this.RemoveLion_MouseLeave);
            this.RemoveLion.MouseHover += new System.EventHandler(this.RemoveLion_MouseHover_1);
            // 
            // AddLion
            // 
            this.AddLion.BackColor = System.Drawing.Color.White;
            this.AddLion.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLion.Location = new System.Drawing.Point(660, 138);
            this.AddLion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddLion.Name = "AddLion";
            this.AddLion.Size = new System.Drawing.Size(95, 23);
            this.AddLion.TabIndex = 16;
            this.AddLion.Text = "Add";
            this.AddLion.UseVisualStyleBackColor = false;
            this.AddLion.Click += new System.EventHandler(this.AddLion_Click);
            this.AddLion.MouseLeave += new System.EventHandler(this.AddLion_MouseLeave);
            this.AddLion.MouseHover += new System.EventHandler(this.AddLion_MouseHover);
            // 
            // PrintLions
            // 
            this.PrintLions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintLions.Location = new System.Drawing.Point(660, 212);
            this.PrintLions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrintLions.Name = "PrintLions";
            this.PrintLions.Size = new System.Drawing.Size(95, 23);
            this.PrintLions.TabIndex = 17;
            this.PrintLions.Text = "Print";
            this.PrintLions.UseVisualStyleBackColor = true;
            this.PrintLions.Click += new System.EventHandler(this.PrintLions_Click);
            // 
            // SaveLions
            // 
            this.SaveLions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLions.Location = new System.Drawing.Point(660, 248);
            this.SaveLions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveLions.Name = "SaveLions";
            this.SaveLions.Size = new System.Drawing.Size(95, 23);
            this.SaveLions.TabIndex = 19;
            this.SaveLions.Text = "Save";
            this.SaveLions.UseVisualStyleBackColor = true;
            this.SaveLions.Click += new System.EventHandler(this.SaveLions_Click);
            // 
            // AgeError
            // 
            this.AgeError.ContainerControl = this;
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
            // printDocumentLions
            // 
            this.printDocumentLions.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentLions_PrintPage);
            // 
            // LoadDataLions
            // 
            this.LoadDataLions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataLions.Location = new System.Drawing.Point(660, 283);
            this.LoadDataLions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadDataLions.Name = "LoadDataLions";
            this.LoadDataLions.Size = new System.Drawing.Size(95, 23);
            this.LoadDataLions.TabIndex = 20;
            this.LoadDataLions.Text = "Load";
            this.LoadDataLions.UseVisualStyleBackColor = true;
            this.LoadDataLions.Click += new System.EventHandler(this.LoadDataLions_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // TotalLions
            // 
            this.TotalLions.AutoSize = true;
            this.TotalLions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLions.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotalLions.Location = new System.Drawing.Point(447, 48);
            this.TotalLions.Name = "TotalLions";
            this.TotalLions.Size = new System.Drawing.Size(88, 31);
            this.TotalLions.TabIndex = 22;
            this.TotalLions.Text = "Total: 0";
            // 
            // LionsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(763, 382);
            this.Controls.Add(this.TotalLions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadDataLions);
            this.Controls.Add(this.SaveLions);
            this.Controls.Add(this.PrintLions);
            this.Controls.Add(this.AddLion);
            this.Controls.Add(this.RemoveLion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LionHaveManeComboBox);
            this.Controls.Add(this.LionInfancyComboBox);
            this.Controls.Add(this.LionGenderComboBox);
            this.Controls.Add(this.LionColorTextBox);
            this.Controls.Add(this.LionAgeTextBox);
            this.Controls.Add(this.LionNameTextBox);
            this.Controls.Add(this.LionHaveMane);
            this.Controls.Add(this.LionInfancyStatus);
            this.Controls.Add(this.LionColor);
            this.Controls.Add(this.LionGender);
            this.Controls.Add(this.LionAge);
            this.Controls.Add(this.LionName);
            this.Controls.Add(this.MammalsButtonLions);
            this.Controls.Add(this.HomeButtonLions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LionsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LionsForms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButtonLions;
        private System.Windows.Forms.Button MammalsButtonLions;
        private System.Windows.Forms.Label LionName;
        private System.Windows.Forms.Label LionAge;
        private System.Windows.Forms.Label LionGender;
        private System.Windows.Forms.Label LionColor;
        private System.Windows.Forms.Label LionInfancyStatus;
        private System.Windows.Forms.Label LionHaveMane;
        private System.Windows.Forms.TextBox LionNameTextBox;
        private System.Windows.Forms.TextBox LionAgeTextBox;
        private System.Windows.Forms.TextBox LionColorTextBox;
        private System.Windows.Forms.ComboBox LionGenderComboBox;
        private System.Windows.Forms.ComboBox LionInfancyComboBox;
        private System.Windows.Forms.ComboBox LionHaveManeComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RemoveLion;
        private System.Windows.Forms.Button AddLion;
        private System.Windows.Forms.Button PrintLions;
        private System.Windows.Forms.Button SaveLions;
        private System.Windows.Forms.ErrorProvider AgeError;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogLions;
        private System.Drawing.Printing.PrintDocument printDocumentLions;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button LoadDataLions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionIDChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionNameChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionAgeChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionGenderChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionColorChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionInfancyChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn LionHaveManeChart;
        private System.Windows.Forms.Label TotalLions;
    }
}