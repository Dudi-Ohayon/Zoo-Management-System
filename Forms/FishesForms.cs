using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMangementSystem
{
    public partial class FishesForms : Form
    {
        public FishesForms()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e) // Back to the home screen
        {
            FormManager.MainForm();
            this.Hide();
        }

        private void SharkButton_Click(object sender, EventArgs e) 
        {
            FormManager.ShowSharkForms();
            this.Hide();
        }

       
    }
}
