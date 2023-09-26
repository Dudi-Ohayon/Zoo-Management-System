namespace ZooMangementSystem
{
    partial class FishesForms
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
            this.SharkButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SharkButton
            // 
            this.SharkButton.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharkButton.Location = new System.Drawing.Point(480, 212);
            this.SharkButton.Name = "SharkButton";
            this.SharkButton.Size = new System.Drawing.Size(173, 41);
            this.SharkButton.TabIndex = 0;
            this.SharkButton.Text = "Shark";
            this.SharkButton.UseVisualStyleBackColor = true;
            this.SharkButton.Click += new System.EventHandler(this.SharkButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(480, 268);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(173, 37);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 97);
            this.label1.TabIndex = 4;
            this.label1.Text = "FISH";
            // 
            // FishesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1145, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.SharkButton);
            this.Name = "FishesForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FishesForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SharkButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label1;
    }
}