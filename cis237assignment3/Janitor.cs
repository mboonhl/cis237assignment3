using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        //Variables
        private bool trashCompactorBool;
        private bool vacuumBool;

        //Constuctors
        public Janitor(string _model, string _material, string _color, bool _toolbox, bool _computerConnection, bool _arm, bool _trashCompactor, bool _vacuum) :
            base(_model, _material, _color, _toolbox, _computerConnection, _arm)
        {
            trashCompactorBool = _trashCompactor;
            vacuumBool = _vacuum;

            CalculateTotalCost();
        }

        //Empty Constructor
        public Janitor() { }

        //Methods
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Trash Compactor: " + trashCompactorBool + Environment.NewLine + " Vacuum: " + vacuumBool;
        }

        public override void CalculateTotalCost()
        {
            if(trashCompactorBool)
            {
                TotalCost += 50m;
            }
            if(vacuumBool)
            {
                TotalCost += 50m;
            }
        }

    }
}
