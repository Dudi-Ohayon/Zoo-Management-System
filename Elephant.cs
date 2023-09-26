using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace ZooMangementSystem
{
    [Serializable]
    public class Elephant : Mammal
    {
        private int _trunkLength; 

        public Elephant(string name, string gender, double age, string color, bool infancy, int sharpLength) : base(name, gender, age, color, infancy)
        {
            this._trunkLength = sharpLength;
        }

        public int SharpLength
        {
            get { return _trunkLength; }
            set { _trunkLength = value; }
        }

        public override string eat()
        {
            return "vegetation";
        }

        public override void makeSound()
        {

            string audioFilePath = "Sounds\\elephant.wav";
            SoundPlayer _soundPlayer = new SoundPlayer(audioFilePath);
            _soundPlayer.Play();
        }
    }
}
