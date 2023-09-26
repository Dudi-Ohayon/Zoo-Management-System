using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows.Forms.PropertyGridInternal;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Lion : Mammal
    {
        private bool _haveMane;
        private static int _lionsCounter;

        public Lion(string name, string gender, double age, string color, bool infancy, bool haveMane) : base(name, gender, age, color, infancy)
        {
            this._haveMane = haveMane;
            _lionsCounter++;
        }
        
        public bool HaveMane
        {
            get { return _haveMane; }
            set { _haveMane = value; }
        }

        public int LionsCounter
        {
            get { return _lionsCounter; } 
            set { _lionsCounter = value; }
        }

        public override string eat()
        {
            return "meat";
        }

        public override void makeSound()
        {
            string audioFilePath = "Sounds\\lion-roar1.wav.wav";
            SoundPlayer _soundPlayer = new SoundPlayer(audioFilePath);
            _soundPlayer.Play();
        }

    }
}
