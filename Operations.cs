using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ZooMangementSystem
{
    public class Operations
    {
     

        /// Data validation 
        public void animalTextBox(TextBox currentAnimal , string animal)
        {
            if (!currentAnimal.Text.All(Char.IsLetter))
            {
                MessageBox.Show("The name of the" + "  " + animal + " should contain only letters!");
                currentAnimal.Text = "";
            }
        }

        public void aniamlAgeBox(TextBox currentAnimal)
        {
            if (currentAnimal.Text.Contains("-") || Regex.IsMatch(currentAnimal.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a possitive number");
                currentAnimal.Text = "";
            }
        }

        public bool checkTextBox( TextBox currentAnimalName , TextBox currentAnimalAge , TextBox currentAnimalColor , ComboBox currentAnimalGender )
        {
            string[] textBox = { currentAnimalName.Text, currentAnimalAge.Text, currentAnimalColor.Text, currentAnimalGender.Text };

            foreach (var text in textBox)
            {
                if (text == "") // Empty field
                {
                    return false;
                }

            }

            return true;

        }

        public void clearFields(TextBox currentAnimalName, TextBox currentAnimalAge, TextBox currentAnimalColor, ComboBox currentAnimalGender)
        {
            currentAnimalName.Text = "";
            currentAnimalAge.Text = "";
            currentAnimalColor.Text = "";
            currentAnimalGender.Text = "";
        }

        public void saveFile(SaveFileDialog saveFileDialog)
        {
            saveFileDialog.Filter = "Binary files (*.bin)|*.bin|All Files (*.*)|*.*";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                DataManager.SaveData(fileName);
            }
        }

        public void loadFile(OpenFileDialog openFileDialog , DataGridView dataGridView , Type animalType , Label totalAnimalType) 
        {
            openFileDialog.Filter = "Binary files (*.bin)|*.bin|All Files (*.*)|*.*";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                DataManager.LoadData(fileName, dataGridView, animalType , totalAnimalType);
            }
        }
    }
}
