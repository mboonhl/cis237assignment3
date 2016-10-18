using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        //Variables
        protected bool toolboxBool;
        protected bool computerConnectionBool;
        protected bool armBool;

        //Constructors
        public Utility(string _model, string _material, string _color, bool _toolbox, bool _computerConnection, bool _arm) : base(_model, _material, _color)
        {
            toolboxBool = _toolbox;
            computerConnectionBool = _computerConnection;
            armBool = _arm;

            CalculateTotalCost();
        }

        //Empty Constructor
        public Utility() { }

        //Methods
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Toolbox: " + toolboxBool + Environment.NewLine + "Computer Connection: " + computerConnectionBool +
                Environment.NewLine + "Arm: " + armBool;

        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            if (toolboxBool)
            {
                totalCostDecimal += 50m;
            }
            if(computerConnectionBool)
            {
                totalCostDecimal += 50m;
            }
            if(armBool)
            {
                totalCostDecimal += 50m;
            }
        }


    }
}
