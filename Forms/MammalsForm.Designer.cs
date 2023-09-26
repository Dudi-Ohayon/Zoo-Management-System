namespace ZooMangementSystem
{
    partial class MammalsForm
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
            this.LionsButton = new System.Windows.Forms.Button();
            this.HomeButtonMammal = new System.Windows.Forms.Button();
            this.ElephantsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LionsButton
            // 
            this.LionsButton.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LionsButton.Location = new System.Drawing.Point(482, 185);
            this.LionsButton.Name = "LionsButton";
            this.LionsButton.Size = new System.Drawing.Size(136, 39);
            this.LionsButton.TabIndex = 0;
            this.LionsButton.Text = "Lions";
            this.LionsButton.UseVisualStyleBackColor = true;
            this.LionsButton.Click += new System.EventHandler(this.LionsButton_Click);
            // 
            // HomeButtonMammal
            // 
            this.HomeButtonMammal.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButtonMammal.Location = new System.Drawing.Point(482, 296);
            this.HomeButtonMammal.Name = "HomeButtonMammal";
            this.HomeButtonMammal.Size = new System.Drawing.Size(136, 35);
            this.HomeButtonMammal.TabIndex = 1;
            this.HomeButtonMammal.Text = "Home";
            this.HomeButtonMammal.UseVisualStyleBackColor = true;
            this.HomeButtonMammal.Click += new System.EventHandler(this.button2_Click);
            // 
            // ElephantsButton
            // 
            this.ElephantsButton.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElephantsButton.Location = new System.Drawing.Point(482, 239);
            this.ElephantsButton.Name = "ElephantsButton";
            this.ElephantsButton.Size = new System.Drawing.Size(136, 39);
            this.ElephantsButton.TabIndex = 2;
            this.ElephantsButton.Text = "Elephants";
            this.ElephantsButton.UseVisualStyleBackColor = true;
            this.ElephantsButton.Click += new System.EventHandler(this.ElephantsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 97);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAMMALS";
            // 
            // MammalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1145, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElephantsButton);
            this.Controls.Add(this.HomeButtonMammal);
            this.Controls.Add(this.LionsButton);
            this.Name = "MammalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MammalsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LionsButton;
        private System.Windows.Forms.Button HomeButtonMammal;
        private System.Windows.Forms.Button ElephantsButton;
        private System.Windows.Forms.Label label1;
    }
}