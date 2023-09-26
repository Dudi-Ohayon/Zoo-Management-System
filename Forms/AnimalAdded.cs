using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ZooMangementSystem
{
    public partial class AnimalAdded : Form
    {
        public string AnimalType { get; set; }
        public string AnimalName { get; set; }

        public string AnimalMeal { get; set; }
        public AnimalAdded()
        {
            InitializeComponent();
        }


 
        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
  
        private void LionAdded_Load(object sender, EventArgs e )
        {
            MSG.Text = "        The " + AnimalType + " " +"successfully added! \n Please pay attention this" +" " + AnimalType+ " " + "eat:" + " " + AnimalMeal; 
        }

        private void MSG_Click(object sender, EventArgs e)
        {
            
        }
    }
}
