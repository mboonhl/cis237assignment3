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

        public void NewDroid(string _model, string _material, string _color, int _lang)
        {
            droidarray[index] = new Protical(_model, _material, _color, _lang);
            index++;
        }

        public void NewDroid(string _model, string _material, string _color, bool _tool, bool _comp, bool _arm)
        {
            droidarray[index] = new Utility(_model, _material, _color, _tool, _comp, _arm);
            index++;
        }

        public void NewDroid(string _model, string _material, string _color, bool _tool, bool _comp, bool _arm,
            bool _trash, bool _vacuum)
        {
            droidarray[index] = new Janitor(_model, _material, _color, _tool, _comp, _arm, _trash, _vacuum);
            index++;
        }

        public void NewDroid(string _model, string _material, string _color, bool _tool, bool _comp, bool _arm,
            bool _fire, int _ships)
        {
            droidarray[index] = new Astromech(_model, _material, _color, _tool, _comp, _arm, _fire, _ships);
            index++;
        }

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
