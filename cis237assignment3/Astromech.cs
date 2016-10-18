using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        //Variables
        private bool fireExtinguisherBool;
        private int numberOfShipsInt;

        //Constant
        const decimal CostPerShip = 100m;

        //Constuctors
        public Astromech(string _model, string _material, string _color, bool _toolbox, bool _computerConnection, bool _arm, bool _fireExtinguisher, int _ships) :
            base(_model, _material, _color, _toolbox, _computerConnection, _arm)
        {
            fireExtinguisherBool = _fireExtinguisher;
            numberOfShipsInt = _ships;

            CalculateTotalCost();
        }

        //Empty Constuctor
        public Astromech() { }

        //Methods
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Fire Extinguisher: " + fireExtinguisherBool +
                   Environment.NewLine + "Number of ships: " + numberOfShipsInt;

        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            if (fireExtinguisherBool)
            {
                totalCostDecimal += 50m;
            }
            if(numberOfShipsInt != 0)
            {
                totalCostDecimal += (numberOfShipsInt * CostPerShip);
            }
        }



    }
}
