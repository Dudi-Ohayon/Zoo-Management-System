using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormsApp1;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ZooMangementSystem
{
    public static class DataManager
    {
        private static List<Animal> animals = new List<Animal>();
        private static object binaryFormatter;
       
        public static List<Animal> GetAnimals() { return animals; }

        public static void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            
        }

        public static void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public static int AnimalCount()
        {
            return animals.Count; 
        }


        public static int animalCountByType(Type type)
        {
            int counter = 0;

            foreach (Animal animal in animals) 
            {
            
                if(type == animal.GetType())
                {
                    counter++;
                }
            }

            return counter;
        }

    
    
        public static void SaveData(string filepath) 
        { 
            try
            {
                using(FileStream fs = new FileStream(filepath,FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, animals);
                }
            }

            catch(Exception ex) 
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        public static void LoadData(string filepath , DataGridView currentDataGrid , Type animalType , Label totalAnimalType) 
        {
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    List<Animal> loadedAnimals = (List<Animal>)formatter.Deserialize(fs);
                    animals = loadedAnimals;
                    FormManager.UpdateAnimalCounter();
                    DataManager.animalCountByType(animalType);
                    
                }
                MessageBox.Show("Data loaded successfully");
                
                currentDataGrid.Rows.Clear();

                if(animalType == typeof(Lion))
                {
                    foreach (Lion lion in animals)
                    {
                        currentDataGrid.Rows.Add(lion.AnimalID, lion.Name, lion.Age, lion.Gender, lion.Color, lion.Infancy, lion.HaveMane);
                    }

                    totalAnimalType.Text = "Total: " + DataManager.animalCountByType(animalType);
                }

                else if(animalType == typeof(Elephant))
                {
                    foreach (Elephant elephants in animals)
                    {
                        currentDataGrid.Rows.Add(elephants.AnimalID, elephants.Name, elephants.Age, elephants.Gender, elephants.Color, elephants.Infancy, elephants.SharpLength);
                    }
                    
                    totalAnimalType.Text = "Total: " +DataManager.animalCountByType(animalType);
                }

                else if (animalType == typeof(Shark))
                {
                    foreach (Shark sharks in animals)
                    {
                        currentDataGrid.Rows.Add(sharks.AnimalID, sharks.Name, sharks.Age, sharks.Gender, sharks.Color, sharks.WaterType, sharks.FinLength);
                    }

                    totalAnimalType.Text = "Total: " + DataManager.animalCountByType(animalType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
