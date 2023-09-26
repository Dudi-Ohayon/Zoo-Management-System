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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ZooMangementSystem
{
    public partial class MainForm : Form
    {
        
        List<Animal> animals = new List<Animal>();
        private List<int> animalsID = new List<int>();
        
        public MainForm()
        {
            InitializeComponent();
            FormManager.InitializeForms(this);
            
        }

        public List<Animal> Get_Animal_List()
        {
            return animals;
        }

        public List<int> Get_Animal_ID_List()
        {
            return animalsID;
        }

        private void MammalHomeBTN_Click(object sender, EventArgs e)
        {
           FormManager.ShowMammalsForms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormManager.ShowFishForms();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            animalsCounter.Text = animalsCounter.Text = "Total " + 0 + " animals";
            timeLable.Text = DateTime.Now.ToLongTimeString();
            DateLable.Text = DateTime.Now.ToLongDateString();          
        }

        public void updateAnimalCountLabel(int count)
        {
           
            animalsCounter.Text = "Total " + count + " animals";
            LionCounter.Text = "Lions: " + DataManager.animalCountByType(typeof(Lion));
            ElephantCounter.Text = "Elephants: " + DataManager.animalCountByType(typeof(Elephant));
            SharkCounter.Text = "Sharks: " + DataManager.animalCountByType(typeof(Shark)); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLable.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void animalsCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void animalsCounter_Click(object sender, EventArgs e)
        {

        }
    }
}
