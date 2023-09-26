namespace ZooMangementSystem
{
    partial class SharksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharksForm));
            this.LoadDataSharks = new System.Windows.Forms.Button();
            this.SaveSharks = new System.Windows.Forms.Button();
            this.PrintShark = new System.Windows.Forms.Button();
            this.AddShark = new System.Windows.Forms.Button();
            this.RemoveShark = new System.Windows.Forms.Button();
            this.SharkDataGridView = new System.Windows.Forms.DataGridView();
            this.SharkIDChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharkNameChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharkAgeChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharkGenderChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharkColorChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharkWaterTypeChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharkFinLengthChart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharkWaterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SharkGenderComboBox = new System.Windows.Forms.ComboBox();
            this.SharkColorTextBox = new System.Windows.Forms.TextBox();
            this.SharkAgeTextBox = new System.Windows.Forms.TextBox();
            this.SharkNameTextBox = new System.Windows.Forms.TextBox();
            this.SharkFinLengh = new System.Windows.Forms.Label();
            this.SharkWaterType = new System.Windows.Forms.Label();
            this.SharkColor = new System.Windows.Forms.Label();
            this.SharkGender = new System.Windows.Forms.Label();
            this.SharkAge = new System.Windows.Forms.Label();
            this.SharkName = new System.Windows.Forms.Label();
            this.FishesButton = new System.Windows.Forms.Button();
            this.HomeButtonSharks = new System.Windows.Forms.Button();
            this.SharkFinLengthTextBox = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentShark = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalShark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SharkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDataSharks
            // 
            this.LoadDataSharks.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataSharks.Location = new System.Drawing.Point(660, 280);
            this.LoadDataSharks.Margin = new System.Windows.Forms.Padding(2);
            this.LoadDataSharks.Name = "LoadDataSharks";
            this.LoadDataSharks.Size = new System.Drawing.Size(95, 23);
            this.LoadDataSharks.TabIndex = 40;
            this.LoadDataSharks.Text = "Load";
            this.LoadDataSharks.UseVisualStyleBackColor = true;
            this.LoadDataSharks.Click += new System.EventHandler(this.LoadDataSharks_Click);
            // 
            // SaveSharks
            // 
            this.SaveSharks.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSharks.Location = new System.Drawing.Point(660, 246);
            this.SaveSharks.Margin = new System.Windows.Forms.Padding(2);
            this.SaveSharks.Name = "SaveSharks";
            this.SaveSharks.Size = new System.Drawing.Size(95, 23);
            this.SaveSharks.TabIndex = 39;
            this.SaveSharks.Text = "Save";
            this.SaveSharks.UseVisualStyleBackColor = true;
            this.SaveSharks.Click += new System.EventHandler(this.SaveSharks_Click);
            // 
            // PrintShark
            // 
            this.PrintShark.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintShark.Location = new System.Drawing.Point(660, 212);
            this.PrintShark.Margin = new System.Windows.Forms.Padding(2);
            this.PrintShark.Name = "PrintShark";
            this.PrintShark.Size = new System.Drawing.Size(95, 23);
            this.PrintShark.TabIndex = 38;
            this.PrintShark.Text = "Print";
            this.PrintShark.UseVisualStyleBackColor = true;
            this.PrintShark.Click += new System.EventHandler(this.PrintShark_Click);
            // 
            // AddShark
            // 
            this.AddShark.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShark.Location = new System.Drawing.Point(660, 142);
            this.AddShark.Margin = new System.Windows.Forms.Padding(2);
            this.AddShark.Name = "AddShark";
            this.AddShark.Size = new System.Drawing.Size(95, 23);
            this.AddShark.TabIndex = 37;
            this.AddShark.Text = "Add";
            this.AddShark.UseVisualStyleBackColor = true;
            this.AddShark.Click += new System.EventHandler(this.AddShark_Click);
            this.AddShark.MouseLeave += new System.EventHandler(this.AddShark_MouseLeave);
            this.AddShark.MouseHover += new System.EventHandler(this.AddShark_MouseHover);
            // 
            // RemoveShark
            // 
            this.RemoveShark.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveShark.Location = new System.Drawing.Point(660, 177);
            this.RemoveShark.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveShark.Name = "RemoveShark";
            this.RemoveShark.Size = new System.Drawing.Size(95, 23);
            this.RemoveShark.TabIndex = 36;
            this.RemoveShark.Text = "Remove";
            this.RemoveShark.UseVisualStyleBackColor = true;
            this.RemoveShark.Click += new System.EventHandler(this.RemoveShark_Click);
            this.RemoveShark.MouseLeave += new System.EventHandler(this.RemoveShark_MouseLeave);
            this.RemoveShark.MouseHover += new System.EventHandler(this.RemoveShark_MouseHover);
            // 
            // SharkDataGridView
            // 
            this.SharkDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SharkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SharkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SharkIDChart,
            this.SharkNameChart,
            this.SharkAgeChart,
            this.SharkGenderChart,
            this.SharkColorChart,
            this.SharkWaterTypeChart,
            this.SharkFinLengthChart});
            this.SharkDataGridView.Location = new System.Drawing.Point(8, 127);
            this.SharkDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SharkDataGridView.Name = "SharkDataGridView";
            this.SharkDataGridView.RowHeadersWidth = 62;
            this.SharkDataGridView.RowTemplate.Height = 28;
            this.SharkDataGridView.Size = new System.Drawing.Size(643, 242);
            this.SharkDataGridView.TabIndex = 35;
            // 
            // SharkIDChart
            // 
            this.SharkIDChart.HeaderText = "ID";
            this.SharkIDChart.MinimumWidth = 8;
            this.SharkIDChart.Name = "SharkIDChart";
            this.SharkIDChart.Width = 150;
            // 
            // SharkNameChart
            // 
            this.SharkNameChart.HeaderText = "Name";
            this.SharkNameChart.MinimumWidth = 8;
            this.SharkNameChart.Name = "SharkNameChart";
            this.SharkNameChart.Width = 150;
            // 
            // SharkAgeChart
            // 
            this.SharkAgeChart.HeaderText = "Age";
            this.SharkAgeChart.MinimumWidth = 8;
            this.SharkAgeChart.Name = "SharkAgeChart";
            this.SharkAgeChart.Width = 150;
            // 
            // SharkGenderChart
            // 
            this.SharkGenderChart.HeaderText = "Gender";
            this.SharkGenderChart.MinimumWidth = 8;
            this.SharkGenderChart.Name = "SharkGenderChart";
            this.SharkGenderChart.Width = 150;
            // 
            // SharkColorChart
            // 
            this.SharkColorChart.HeaderText = "Color";
            this.SharkColorChart.MinimumWidth = 8;
            this.SharkColorChart.Name = "SharkColorChart";
            this.SharkColorChart.Width = 150;
            // 
            // SharkWaterTypeChart
            // 
            this.SharkWaterTypeChart.HeaderText = "Water Type";
            this.SharkWaterTypeChart.MinimumWidth = 8;
            this.SharkWaterTypeChart.Name = "SharkWaterTypeChart";
            this.SharkWaterTypeChart.Width = 150;
            // 
            // SharkFinLengthChart
            // 
            this.SharkFinLengthChart.HeaderText = "Fin Length";
            this.SharkFinLengthChart.MinimumWidth = 8;
            this.SharkFinLengthChart.Name = "SharkFinLengthChart";
            this.SharkFinLengthChart.Width = 150;
            // 
            // SharkWaterTypeComboBox
            // 
            this.SharkWaterTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.SharkWaterTypeComboBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkWaterTypeComboBox.FormattingEnabled = true;
            this.SharkWaterTypeComboBox.Items.AddRange(new object[] {
            "Fresh",
            "Salty"});
            this.SharkWaterTypeComboBox.Location = new System.Drawing.Point(273, 46);
            this.SharkWaterTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SharkWaterTypeComboBox.Name = "SharkWaterTypeComboBox";
            this.SharkWaterTypeComboBox.Size = new System.Drawing.Size(113, 21);
            this.SharkWaterTypeComboBox.TabIndex = 33;
            // 
            // SharkGenderComboBox
            // 
            this.SharkGenderComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.SharkGenderComboBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkGenderComboBox.FormattingEnabled = true;
            this.SharkGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SharkGenderComboBox.Location = new System.Drawing.Point(60, 76);
            this.SharkGenderComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SharkGenderComboBox.Name = "SharkGenderComboBox";
            this.SharkGenderComboBox.Size = new System.Drawing.Size(113, 21);
            this.SharkGenderComboBox.TabIndex = 32;
            // 
            // SharkColorTextBox
            // 
            this.SharkColorTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkColorTextBox.Location = new System.Drawing.Point(273, 18);
            this.SharkColorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SharkColorTextBox.Name = "SharkColorTextBox";
            this.SharkColorTextBox.Size = new System.Drawing.Size(113, 21);
            this.SharkColorTextBox.TabIndex = 31;
            // 
            // SharkAgeTextBox
            // 
            this.SharkAgeTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkAgeTextBox.Location = new System.Drawing.Point(60, 48);
            this.SharkAgeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SharkAgeTextBox.Name = "SharkAgeTextBox";
            this.SharkAgeTextBox.Size = new System.Drawing.Size(113, 21);
            this.SharkAgeTextBox.TabIndex = 30;
            this.SharkAgeTextBox.TextChanged += new System.EventHandler(this.SharkAgeTextBox_TextChanged);
            // 
            // SharkNameTextBox
            // 
            this.SharkNameTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SharkNameTextBox.Location = new System.Drawing.Point(60, 20);
            this.SharkNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SharkNameTextBox.Name = "SharkNameTextBox";
            this.SharkNameTextBox.Size = new System.Drawing.Size(113, 21);
            this.SharkNameTextBox.TabIndex = 29;
            this.SharkNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SharkNameTextBox.TextChanged += new System.EventHandler(this.SharkNameTextBox_TextChanged);
            // 
            // SharkFinLengh
            // 
            this.SharkFinLengh.AutoSize = true;
            this.SharkFinLengh.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkFinLengh.Location = new System.Drawing.Point(209, 79);
            this.SharkFinLengh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SharkFinLengh.Name = "SharkFinLengh";
            this.SharkFinLengh.Size = new System.Drawing.Size(55, 13);
            this.SharkFinLengh.TabIndex = 28;
            this.SharkFinLengh.Text = "Fin Length";
            // 
            // SharkWaterType
            // 
            this.SharkWaterType.AutoSize = true;
            this.SharkWaterType.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkWaterType.Location = new System.Drawing.Point(209, 47);
            this.SharkWaterType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SharkWaterType.Name = "SharkWaterType";
            this.SharkWaterType.Size = new System.Drawing.Size(60, 13);
            this.SharkWaterType.TabIndex = 27;
            this.SharkWaterType.Text = "Water Type";
            // 
            // SharkColor
            // 
            this.SharkColor.AutoSize = true;
            this.SharkColor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkColor.Location = new System.Drawing.Point(209, 19);
            this.SharkColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SharkColor.Name = "SharkColor";
            this.SharkColor.Size = new System.Drawing.Size(32, 13);
            this.SharkColor.TabIndex = 26;
            this.SharkColor.Text = "Color";
            // 
            // SharkGender
            // 
            this.SharkGender.AutoSize = true;
            this.SharkGender.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkGender.Location = new System.Drawing.Point(15, 79);
            this.SharkGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SharkGender.Name = "SharkGender";
            this.SharkGender.Size = new System.Drawing.Size(42, 13);
            this.SharkGender.TabIndex = 25;
            this.SharkGender.Text = "Gender";
            // 
            // SharkAge
            // 
            this.SharkAge.AutoSize = true;
            this.SharkAge.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkAge.Location = new System.Drawing.Point(15, 49);
            this.SharkAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SharkAge.Name = "SharkAge";
            this.SharkAge.Size = new System.Drawing.Size(25, 13);
            this.SharkAge.TabIndex = 24;
            this.SharkAge.Text = "Age";
            // 
            // SharkName
            // 
            this.SharkName.AutoSize = true;
            this.SharkName.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkName.Location = new System.Drawing.Point(15, 21);
            this.SharkName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SharkName.Name = "SharkName";
            this.SharkName.Size = new System.Drawing.Size(34, 13);
            this.SharkName.TabIndex = 23;
            this.SharkName.Text = "Name";
            // 
            // FishesButton
            // 
            this.FishesButton.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FishesButton.Location = new System.Drawing.Point(660, 315);
            this.FishesButton.Margin = new System.Windows.Forms.Padding(2);
            this.FishesButton.Name = "FishesButton";
            this.FishesButton.Size = new System.Drawing.Size(95, 23);
            this.FishesButton.TabIndex = 22;
            this.FishesButton.Text = "Fish";
            this.FishesButton.UseVisualStyleBackColor = true;
            this.FishesButton.Click += new System.EventHandler(this.FishesButtonLions_Click);
            // 
            // HomeButtonSharks
            // 
            this.HomeButtonSharks.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButtonSharks.Location = new System.Drawing.Point(660, 346);
            this.HomeButtonSharks.Margin = new System.Windows.Forms.Padding(2);
            this.HomeButtonSharks.Name = "HomeButtonSharks";
            this.HomeButtonSharks.Size = new System.Drawing.Size(95, 23);
            this.HomeButtonSharks.TabIndex = 21;
            this.HomeButtonSharks.Text = "Home";
            this.HomeButtonSharks.UseVisualStyleBackColor = true;
            this.HomeButtonSharks.Click += new System.EventHandler(this.HomeButtonSharks_Click);
            // 
            // SharkFinLengthTextBox
            // 
            this.SharkFinLengthTextBox.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkFinLengthTextBox.Location = new System.Drawing.Point(273, 78);
            this.SharkFinLengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SharkFinLengthTextBox.Name = "SharkFinLengthTextBox";
            this.SharkFinLengthTextBox.Size = new System.Drawing.Size(113, 21);
            this.SharkFinLengthTextBox.TabIndex = 41;
            this.SharkFinLengthTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocumentShark;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocumentShark
            // 
            this.printDocumentShark.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentShark_PrintPage);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // TotalShark
            // 
            this.TotalShark.AutoSize = true;
            this.TotalShark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalShark.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalShark.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotalShark.Location = new System.Drawing.Point(469, 43);
            this.TotalShark.Name = "TotalShark";
            this.TotalShark.Size = new System.Drawing.Size(88, 31);
            this.TotalShark.TabIndex = 44;
            this.TotalShark.Text = "Total: 0";
            // 
            // SharksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(763, 382);
            this.Controls.Add(this.TotalShark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SharkFinLengthTextBox);
            this.Controls.Add(this.LoadDataSharks);
            this.Controls.Add(this.SaveSharks);
            this.Controls.Add(this.PrintShark);
            this.Controls.Add(this.AddShark);
            this.Controls.Add(this.RemoveShark);
            this.Controls.Add(this.SharkDataGridView);
            this.Controls.Add(this.SharkWaterTypeComboBox);
            this.Controls.Add(this.SharkGenderComboBox);
            this.Controls.Add(this.SharkColorTextBox);
            this.Controls.Add(this.SharkAgeTextBox);
            this.Controls.Add(this.SharkNameTextBox);
            this.Controls.Add(this.SharkFinLengh);
            this.Controls.Add(this.SharkWaterType);
            this.Controls.Add(this.SharkColor);
            this.Controls.Add(this.SharkGender);
            this.Controls.Add(this.SharkAge);
            this.Controls.Add(this.SharkName);
            this.Controls.Add(this.FishesButton);
            this.Controls.Add(this.HomeButtonSharks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SharksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharksForm";
            ((System.ComponentModel.ISupportInitialize)(this.SharkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadDataSharks;
        private System.Windows.Forms.Button SaveSharks;
        private System.Windows.Forms.Button PrintShark;
        private System.Windows.Forms.Button AddShark;
        private System.Windows.Forms.Button RemoveShark;
        private System.Windows.Forms.DataGridView SharkDataGridView;
        private System.Windows.Forms.ComboBox SharkWaterTypeComboBox;
        private System.Windows.Forms.ComboBox SharkGenderComboBox;
        private System.Windows.Forms.TextBox SharkColorTextBox;
        private System.Windows.Forms.TextBox SharkAgeTextBox;
        private System.Windows.Forms.TextBox SharkNameTextBox;
        private System.Windows.Forms.Label SharkFinLengh;
        private System.Windows.Forms.Label SharkWaterType;
        private System.Windows.Forms.Label SharkColor;
        private System.Windows.Forms.Label SharkGender;
        private System.Windows.Forms.Label SharkAge;
        private System.Windows.Forms.Label SharkName;
        private System.Windows.Forms.Button FishesButton;
        private System.Windows.Forms.Button HomeButtonSharks;
        private System.Windows.Forms.TextBox SharkFinLengthTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharkIDChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharkNameChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharkAgeChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharkGenderChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharkColorChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharkWaterTypeChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharkFinLengthChart;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocumentShark;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TotalShark;
    }
}