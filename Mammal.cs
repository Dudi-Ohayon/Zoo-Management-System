using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class Mammal : Animal
    {
        private bool _infancy;

        public Mammal(string name, string gender, double age, string color, bool infancy) : base(name, gender, age, color)
        {
            this._infancy = infancy;
        }

        public bool Infancy
        {
            get { return _infancy; }
            set { _infancy = value; }
        }

    }
}
