using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooMangementSystem
{
    public partial class ElephantsForm : Form
    {
        Operations operations = new Operations();
        Bitmap bitmap;
        public ElephantsForm()
        {
            InitializeComponent();
        }

        private void HomeButtonElephant_Click(object sender, EventArgs e)
        {
            FormManager.MainForm();
            this.Hide();
        }

        private void MammalsButtonElephant_Click(object sender, EventArgs e)
        {
            FormManager.ShowMammalsForms();
            this.Hide();
        }

        private void LionNameTextBox_TextChanged(object sender, EventArgs e)
        {
            operations.animalTextBox(ElephantNameTextBox, "elephant");
        }

        private void ElephantAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            operations.aniamlAgeBox(ElephantAgeTextBox);
        }

        private void ElephantTrunkLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ElephantTrunkLengthTextBox.Text.Contains("-") || Regex.IsMatch(ElephantTrunkLengthTextBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a possitive number");
                ElephantTrunkLengthTextBox.Text = "";
            }
        }

        private void AddElephant_Click(object sender, EventArgs e)
        {
            
            if (!operations.checkTextBox(ElephantNameTextBox, ElephantAgeTextBox, ElephantColorTextBox, ElephantGenderComboBox) || (ElephantInfancyComboBox.Text == "") || (ElephantTrunkLengthTextBox.Text == ""))
            {
                MessageBox.Show("Please check again all the fields!");
            }

            else
            {

                double elephantAge = Convert.ToDouble(ElephantAgeTextBox.Text);
                int trunkLength = Convert.ToInt16(ElephantTrunkLengthTextBox.Text);
                bool ElephantsInfancy;

                if (ElephantInfancyComboBox.Text == "Yes")
                {
                    ElephantsInfancy = true;
                }

                else
                {
                    ElephantsInfancy = false;
                }


                Elephant newElephants = new Elephant(ElephantNameTextBox.Text, ElephantGenderComboBox.Text, elephantAge, ElephantColorTextBox.Text, ElephantsInfancy, trunkLength);

                dataGridViewElephants.Rows.Add(newElephants.AnimalID, newElephants.Name, newElephants.Age, newElephants.Gender, newElephants.Color, newElephants.Infancy, newElephants.SharpLength);

                DataManager.AddAnimal(newElephants); // Add the new Elephant to the collaction list 

                newElephants.makeSound(); // -> polymorphism

                AnimalAdded animalAddedMessage = new AnimalAdded(); /// Elephants successfully added message -> polymorphism 

                animalAddedMessage.Name = newElephants.Name;

                animalAddedMessage.AnimalType = "elephant";

                animalAddedMessage.AnimalMeal = newElephants.eat();

                animalAddedMessage.Show();

                operations.clearFields(ElephantNameTextBox, ElephantAgeTextBox, ElephantColorTextBox, ElephantGenderComboBox);

                ElephantInfancyComboBox.Text = ""; // Additional fields
                ElephantTrunkLengthTextBox.Text = "";

                FormManager.UpdateAnimalCounter();

                DataManager.animalCountByType(newElephants.GetType());

                TotalElephants.Text = "Total: " + DataManager.animalCountByType(typeof(Elephant));
            }
        }

        private void remove()
        {
            if (DataManager.animalCountByType(typeof(Elephant)) > 0)
            {

                int rowIndex = dataGridViewElephants.CurrentCell.RowIndex;

                DataManager.GetAnimals().RemoveAt(rowIndex);

                dataGridViewElephants.Rows.RemoveAt(rowIndex);

                FormManager.UpdateAnimalCounter();

                TotalElephants.Text = "Total: " + DataManager.animalCountByType(typeof(Elephant));
            }

            else
            {
                MessageBox.Show("There are no elephants to remove!");
            }

        }

        private void RemoveElephant_Click(object sender, EventArgs e)
        {
            try
            {
                remove();
            }

            catch (Exception ex)
            {
                MessageBox.Show("You selected an empty field, please try again!");
            }
        }

        private void PrintElephant_Click(object sender, EventArgs e)
        {
            int height = dataGridViewElephants.Height;
            dataGridViewElephants.Height = dataGridViewElephants.RowCount * dataGridViewElephants.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridViewElephants.Width, dataGridViewElephants.Height);
            dataGridViewElephants.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridViewElephants.Width, dataGridViewElephants.Height));
            printPreviewDialogLions.PrintPreviewControl.Zoom = 1;
            printPreviewDialogLions.ShowDialog();
            dataGridViewElephants.Height = height;
        }

        private void printDocumentLions_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void SaveLions_Click(object sender, EventArgs e)
        {
            operations.saveFile(saveFileDialog1);
        }

        private void LoadDataLions_Click(object sender, EventArgs e)
        {
            operations.loadFile(openFileDialog1, dataGridViewElephants, typeof(Elephant) , TotalElephants);
        }

        private void AddElephant_MouseHover(object sender, EventArgs e)
        {
            AddElephant.BackColor = Color.LightBlue;
        }

        private void AddElephant_MouseLeave(object sender, EventArgs e)
        {
            AddElephant.BackColor = Color.White;
        }

        private void RemoveElephant_MouseHover(object sender, EventArgs e)
        {
            RemoveElephant.BackColor = Color.LightCoral;
        }

        private void RemoveElephant_MouseLeave(object sender, EventArgs e)
        {
            RemoveElephant.BackColor = Color.White;
        }

        private void TotalElephants_Click(object sender, EventArgs e)
        {

        }
    }
}
