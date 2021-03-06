﻿using System;
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

        //Constuctor with relation to parent class
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

        //Override to string to add varibales for the class
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Trash Compactor: " + trashCompactorBool +
                   Environment.NewLine + " Vacuum: " + vacuumBool;

        }

        //Override for Calculate total to add in variables for the class
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            if (trashCompactorBool)
            {
                totalCostDecimal += 50m;
            }
            if(vacuumBool)
            {
                totalCostDecimal += 50m;
            }
        }

    }
}
