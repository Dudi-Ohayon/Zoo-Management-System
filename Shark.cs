using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ZooMangementSystem
{
    [Serializable]
    public class Shark : Fish
    {
        private double _finLength;

        public Shark(string name , string gender , double age , string color , string waterType , double finLenth) : base(name, gender , age , color , waterType)
        {
            this._finLength= finLenth;
        }


        public double FinLength
        {
            get { return _finLength; }
            set { _finLength = value; }
        }

        public override string eat()
        {
            return "fish";
        }

        public override void makeSound()
        {
            
            string audioFilePath = "Sounds\\shark.wav"; 
            SoundPlayer _soundPlayer = new SoundPlayer(audioFilePath);
            _soundPlayer.Play();
            
        }
    }
}
