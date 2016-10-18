using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        //Instantiate the array of droids
        IDroid[] droidarray = new Droid[5000];

        //Variables
        int index = 0;

        //Overloaded method to make a new spot in the droid array for the new Protical droid
        public void NewDroid(string _model, string _material, string _color, int _lang)
        {
            droidarray[index] = new Protical(_model, _material, _color, _lang);
            index++;
        }

        //Overloaded method to make a new spot in the droid array for the new Utility droid
        public void NewDroid(string _model, string _material, string _color, bool _tool, bool _comp, bool _arm)
        {
            droidarray[index] = new Utility(_model, _material, _color, _tool, _comp, _arm);
            index++;
        }

        //Overloaded method to make a new spot in the droid array for the new Janitor droid
        public void NewDroid(string _model, string _material, string _color, bool _tool, bool _comp, bool _arm,
            bool _trash, bool _vacuum)
        {
            droidarray[index] = new Janitor(_model, _material, _color, _tool, _comp, _arm, _trash, _vacuum);
            index++;
        }

        //Overloaded method to make a new spot in the droid array for the new Astromech droid
        public void NewDroid(string _model, string _material, string _color, bool _tool, bool _comp, bool _arm,
            bool _fire, int _ships)
        {
            droidarray[index] = new Astromech(_model, _material, _color, _tool, _comp, _arm, _fire, _ships);
            index++;
        }

        //Method to print all droids in the array
        public void PrintDroids()
        {
            int counter = 0;

            while (counter < index)
            {
                Console.WriteLine(droidarray[counter]);
                counter++;
            }

        }

    }
}
