using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace ZooMangementSystem
{
    [Serializable]
    public abstract class Fish : Animal
    {
        private string _waterType; // Fresh or Salt 

        public Fish(string name, string gender, double age, string color , string waterType) : base(name, gender, age, color) 
        {
            this._waterType = waterType;
        }

        public string WaterType
        {
            get { return _waterType; }
            set { _waterType = value; }
        }

    }
}
