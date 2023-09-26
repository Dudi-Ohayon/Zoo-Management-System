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
using WindowsFormsApp1;

namespace ZooMangementSystem
{
    public partial class SharksForm : Form

    {
        Operations operations = new Operations();
        
        Bitmap bitmap;
        public SharksForm()
        {
            InitializeComponent();
        }

        private void FishesButtonLions_Click(object sender, EventArgs e)
        {
            FormManager.ShowFishForms();
            this.Hide();
        }

        private void HomeButtonSharks_Click(object sender, EventArgs e)
        {
            FormManager.MainForm();
            this.Hide();
        }

        private void SharkNameTextBox_TextChanged(object sender, EventArgs e)
        {
            operations.animalTextBox(SharkNameTextBox, "shark");
        }

        private void SharkAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            operations.aniamlAgeBox(SharkAgeTextBox);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SharkFinLengthTextBox.Text.Contains("-") || Regex.IsMatch(SharkFinLengthTextBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter a possitive number");
                SharkNameTextBox.Text = "";
               
            }
        }

        private void AddShark_Click(object sender, EventArgs e)
        {
            if (!operations.checkTextBox(SharkNameTextBox, SharkAgeTextBox, SharkColorTextBox, SharkGenderComboBox) || (SharkWaterTypeComboBox.Text == "") || (SharkFinLengthTextBox.Text == ""))
            {
                MessageBox.Show("Please check again all the fields!");
            }

            else
            {
                double sharkAge = Convert.ToDouble(SharkAgeTextBox.Text);
                
                double finLength = Convert.ToDouble(SharkFinLengthTextBox.Text);

                Shark newSharks = new Shark(SharkNameTextBox.Text, SharkGenderComboBox.Text, sharkAge, SharkColorTextBox.Text, SharkWaterTypeComboBox.Text, finLength);

                SharkDataGridView.Rows.Add(newSharks.AnimalID , newSharks.Name , newSharks.Age , newSharks.Gender , newSharks.Color , newSharks.WaterType , newSharks.FinLength);

                DataManager.AddAnimal(newSharks); // Add the new shark to the collaction list 

                newSharks.makeSound(); // -> polymorphism 

                AnimalAdded animalAddedMessage = new AnimalAdded(); /// shark successfully added message -> polymorphism 

                animalAddedMessage.Name = newSharks.Name;

                animalAddedMessage.AnimalType = "shark";

                animalAddedMessage.AnimalMeal = newSharks.eat();

                animalAddedMessage.Show();

                operations.clearFields(SharkNameTextBox, SharkAgeTextBox, SharkColorTextBox, SharkGenderComboBox);
                SharkWaterTypeComboBox.Text = "";
                SharkFinLengthTextBox.Text = "";

                FormManager.UpdateAnimalCounter();

                TotalShark.Text = "Total: " + DataManager.animalCountByType(typeof(Shark));
            }
        }

        private void remove()
        {
            if (DataManager.animalCountByType(typeof(Shark)) > 0)
            {

                int rowIndex = SharkDataGridView.CurrentCell.RowIndex;

                DataManager.GetAnimals().RemoveAt(rowIndex); // Remove from the animal list

                SharkDataGridView.Rows.RemoveAt(rowIndex);

                FormManager.UpdateAnimalCounter();

                TotalShark.Text = "Total: " + DataManager.animalCountByType(typeof(Shark));
            }

            else
            {
                MessageBox.Show("There are no sharks to remove!");
            }
        }

        private void RemoveShark_Click(object sender, EventArgs e)
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

        private void PrintShark_Click(object sender, EventArgs e)
        {
            int height = SharkDataGridView.Height;
            SharkDataGridView.Height = SharkDataGridView.RowCount * SharkDataGridView.RowTemplate.Height * 2;
            bitmap = new Bitmap(SharkDataGridView.Width, SharkDataGridView.Height);
            SharkDataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, SharkDataGridView.Width, SharkDataGridView.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            SharkDataGridView.Height = height;
        }

        private void printDocumentShark_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void SaveSharks_Click(object sender, EventArgs e)
        {
            operations.saveFile(saveFileDialog1);
        }

        private void LoadDataSharks_Click(object sender, EventArgs e)
        {
            operations.loadFile(openFileDialog1, SharkDataGridView, typeof(Shark) , TotalShark);
        }

        private void AddShark_MouseHover(object sender, EventArgs e)
        {
            AddShark.BackColor = Color.LightBlue;
        }

        private void AddShark_MouseLeave(object sender, EventArgs e)
        {
            AddShark.BackColor = Color.White;
        }

        private void RemoveShark_MouseHover(object sender, EventArgs e)
        {
            RemoveShark.BackColor = Color.LightCoral;
        }

        private void RemoveShark_MouseLeave(object sender, EventArgs e)
        {
            RemoveShark.BackColor= Color.White;
        }
    }
}
