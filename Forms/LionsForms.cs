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
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using System.IO;


namespace ZooMangementSystem
{
    [Serializable]
    public partial class LionsForms : Form
    {
        Operations operations = new Operations();
        List<Lion> lions = new List<Lion>();
        Bitmap bitmap;

        public LionsForms()
        {
            InitializeComponent();
        }

        private void HomeButtonLions_Click(object sender, EventArgs e) // Back to the home screen 
        {
            FormManager.MainForm();
            this.Hide();
            
        }

        private void MammalsButtonLions_Click(object sender, EventArgs e) // Going to the mammals screen 
        {
            FormManager.ShowMammalsForms();
            this.Hide();
        }

        private void LionNameTextBox_TextChanged(object sender, EventArgs e)
        {
       
            operations.animalTextBox(LionNameTextBox, "lion");
        }

        private void LionAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            operations.aniamlAgeBox(LionAgeTextBox);
        }

        private void AddLion_Click(object sender, EventArgs e)
        {

            if (!operations.checkTextBox(LionNameTextBox ,LionAgeTextBox,LionColorTextBox,LionGenderComboBox) && (LionInfancyComboBox.Text == "") && (LionHaveManeComboBox.Text ==""))
            {
                MessageBox.Show("Please check again all the fields!");
            }

            else
            {
                double lionAge = Convert.ToDouble(LionAgeTextBox.Text);
                bool lionInfancy;
                bool haveMane;


                if (LionInfancyComboBox.Text == "Yes")
                {
                    lionInfancy = true;
                }

                else
                {
                    lionInfancy = false;
                }

                if (LionHaveManeComboBox.Text == "Yes")
                {
                    haveMane = true;
                }

                else
                {
                    haveMane = false;
                }

                Lion newLion = new Lion(LionNameTextBox.Text, LionGenderComboBox.Text, lionAge, LionColorTextBox.Text, lionInfancy, haveMane);

                dataGridView1.Rows.Add(newLion.AnimalID , newLion.Name, newLion.Age, newLion.Gender, newLion.Color, LionInfancyComboBox.Text, LionHaveManeComboBox.Text);

                lions.Add(newLion);

                DataManager.AddAnimal(newLion); // Add the new lion to the collaction list  

                newLion.makeSound(); // -> polymorphism 

                AnimalAdded animalAddedMessage = new AnimalAdded(); /// Lion successfully added message -> polymorphism 

                animalAddedMessage.Name = newLion.Name;

                animalAddedMessage.AnimalType = "lion";

                animalAddedMessage.AnimalMeal = newLion.eat(); // -> polymorphism 

                animalAddedMessage.Show();

                operations.clearFields(LionNameTextBox, LionAgeTextBox, LionColorTextBox, LionGenderComboBox);

                LionInfancyComboBox.Text = ""; // Additional fields 
                LionHaveManeComboBox.Text = "";

                FormManager.UpdateAnimalCounter();

                TotalLions.Text = "Total: " +  DataManager.animalCountByType(typeof(Lion));

            }          
    }
        private void remove()
        {
            if (DataManager.animalCountByType(typeof(Lion)) > 0){

                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                DataManager.GetAnimals().RemoveAt(rowIndex); // Remove from the list of the animals 

                dataGridView1.Rows.RemoveAt(rowIndex);

                FormManager.UpdateAnimalCounter();

                TotalLions.Text = "Total: " + DataManager.animalCountByType(typeof(Lion));
            }

            else
            {
                MessageBox.Show("There are no lions to remove!");
            }
        }

        private void RemoveLion_Click(object sender, EventArgs e)
        {
          
            try
            {
                remove();
            }

            catch(Exception ex) 
            {
                MessageBox.Show("You selected an empty field, please try again!");
            }           
        }

        private void PrintLions_Click(object sender, EventArgs e)
        {
            
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap,new Rectangle(0,0,dataGridView1.Width,dataGridView1.Height));
            printPreviewDialogLions.PrintPreviewControl.Zoom = 1;
            printPreviewDialogLions.ShowDialog();
            dataGridView1.Height = height;
        }

        private void printDocumentLions_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }

        private void AddLion_MouseHover(object sender, EventArgs e)
        {
            AddLion.BackColor = Color.LightBlue;
        }

        private void AddLion_MouseLeave(object sender, EventArgs e)
        {
            AddLion.BackColor = Color.White;
        }

        private void RemoveLion_MouseHover_1(object sender, EventArgs e)
        {
            RemoveLion.BackColor = Color.LightCoral;
        }

        private void RemoveLion_MouseLeave(object sender, EventArgs e)
        {
            RemoveLion.BackColor = Color.White;
        }

        // serialization & deserialization //

        private void SaveLions_Click(object sender, EventArgs e)
        {
            operations.saveFile(saveFileDialog1);
        }

        private void LoadDataLions_Click(object sender, EventArgs e)
        {
            operations.loadFile(openFileDialog1, dataGridView1 , typeof(Lion) , TotalLions);
        }

    }
}
