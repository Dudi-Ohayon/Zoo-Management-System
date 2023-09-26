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
    public partial class MammalsForm : Form
    {
        public MammalsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // Back to the home screen
        {
            FormManager.MainForm();
            this.Hide();
        }

        private void LionsButton_Click(object sender, EventArgs e) // Going into the lions section 
        {
          
            FormManager.ShowLionsForms();
            this.Hide();
        }

        private void ElephantsButton_Click(object sender, EventArgs e) // Going into the Elephants section
        {
            FormManager.ShowElephantForms();
            this.Hide();
        }
    }
}
