using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class Animal
    {
        
        private string _name;
        private string _gender;
        private double _age;
        private string _color;
        private static int _animalsCounter;
        private int _animalId;
        private Random rnd;

        public Animal(string name, string gender, double age, string color)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._color = color;
            _animalsCounter++;
            rnd = new Random();
            _animalId = rnd.Next();
            
        }
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { this._gender = value; }
        }

        public double Age
        {
            get { return _age; }
            set { this._age = value; }
        }

        public string Color
        {
            get { return _color; }
            set { this._color = value; }
        }

        public int AnimalCounter
        {
            get { return _animalsCounter; }
            set { _animalsCounter = value; }
        }

        public int AnimalID
        {
            get { return _animalId; }

        }
        public virtual string eat()
        {
            return "";
        }
        

        public virtual void makeSound() { }

    }

}


