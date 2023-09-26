namespace ZooMangementSystem
{
    partial class AnimalAdded
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();
            this.LionMSG = new System.Windows.Forms.Label();
            this.MSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 20);
            this.panel1.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.SkyBlue;
            this.OK.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(336, 147);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(88, 32);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // LionMSG
            // 
            this.LionMSG.AutoSize = true;
            this.LionMSG.Location = new System.Drawing.Point(313, 46);
            this.LionMSG.Name = "LionMSG";
            this.LionMSG.Size = new System.Drawing.Size(0, 20);
            this.LionMSG.TabIndex = 2;
            // 
            // MSG
            // 
            this.MSG.AutoSize = true;
            this.MSG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSG.Location = new System.Drawing.Point(162, 54);
            this.MSG.Name = "MSG";
            this.MSG.Size = new System.Drawing.Size(60, 29);
            this.MSG.TabIndex = 3;
            this.MSG.Text = "MSG";
            this.MSG.Click += new System.EventHandler(this.MSG_Click);
            // 
            // AnimalAdded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.MSG);
            this.Controls.Add(this.LionMSG);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.panel1);
            this.Name = "AnimalAdded";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalAdded";
            this.Load += new System.EventHandler(this.LionAdded_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label LionMSG;
        private System.Windows.Forms.Label MSG;
    }
}