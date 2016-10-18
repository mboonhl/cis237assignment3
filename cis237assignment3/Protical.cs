using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protical : Droid
    {
        //Properties
        private int numberOfLanguages;

        //Constants
        const decimal CostPerLanguage = 20m;

        //Constructor with relation to parent class
        public Protical(string _model, string _material, string _color, int _numbLanguages) : base(_model,_material, _color)
        {
            numberOfLanguages = _numbLanguages;
            CalculateTotalCost();
        }

        //Empty Constructor
        public Protical() { }

        //Methods

        //Override to string to add varibales for the class
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Number of Languages: " + numberOfLanguages;
        }

        //Calculates new total cost with languages
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            totalCostDecimal += (numberOfLanguages * CostPerLanguage);
        }
    }
}
