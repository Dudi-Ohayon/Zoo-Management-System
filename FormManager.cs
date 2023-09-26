using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMangementSystem
{
    public static class FormManager
    {
        private static MainForm mainForm;
        private static MammalsForm mammalsForm;
        private static FishesForms fishForm;
        private static LionsForms lionsForm;
        private static ElephantsForm elephantsForm;
        private static SharksForm sharksForm;


        public static void InitializeForms(MainForm mainFormReference)
        {
            mainForm = mainFormReference;
        }
        
        public static void MainForm()
        {
            mainForm.Show(); 
        }

        public static void UpdateAnimalCounter()
        {
            mainForm.updateAnimalCountLabel(DataManager.AnimalCount());
        }
        
        public static void ShowMammalsForms()
        {

            if (mammalsForm == null || mammalsForm.IsDisposed) 
            {
                mammalsForm = new MammalsForm();
                mammalsForm.FormClosed += (sender, e) => mammalsForm = null;
            }
           
            mammalsForm.Show();
            mammalsForm.Location = mainForm.Location;
            mainForm.Hide();
        }

        public static void ShowFishForms()
        {

            if (fishForm == null || fishForm.IsDisposed)
            {
                fishForm = new FishesForms();
                fishForm.FormClosed += (sender, e) => fishForm = null;
            }

            fishForm.Show();
            fishForm.Location = mainForm.Location;
            mainForm.Hide();
        }



        public static void ShowLionsForms()
        {

            if (lionsForm == null || lionsForm.IsDisposed)
            {
                lionsForm = new LionsForms();
                lionsForm.FormClosed += (sender, e) => lionsForm = null;
            }
            
            lionsForm.Show();
            lionsForm.Location = mainForm.Location;
            mainForm.Hide();
            
        }

        public static void ShowElephantForms()
        {

            if (elephantsForm == null || elephantsForm.IsDisposed)
            {
                elephantsForm = new ElephantsForm();
                elephantsForm.FormClosed += (sender, e) => elephantsForm = null;
            }

            elephantsForm.Show();
            elephantsForm.Location = mainForm.Location;
            mainForm.Hide();

        }

        public static void ShowSharkForms()
        {

            if (sharksForm == null || sharksForm.IsDisposed)
            {
                sharksForm = new SharksForm();
                sharksForm.FormClosed += (sender, e) => sharksForm = null;
            }

            sharksForm.Show();
            sharksForm.Location = mainForm.Location;
            mainForm.Hide();

        }

    }
}
