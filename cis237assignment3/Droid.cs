using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        //Variables
        private string materialString;
        private string modelString;
        private string colorString;
        private decimal baseCostDecimal;
        public decimal totalCostDecimal;

        //Properties
        public decimal TotalCost
        {
            set { totalCostDecimal = value; }
            get { return totalCostDecimal; }
        }

        //Constructors
        public Droid(string _model, string _material, string _color)
        {
            modelString = _model;
            materialString = _material;
            colorString = _color;

            BaseCost();           

        }

        //Empty Constructor
        public Droid() { }

        //Methods
        //Overrides ToString method to return droid values
        public override string ToString()
        {
            return Environment.NewLine + Environment.NewLine + "Model: " + modelString + Environment.NewLine + "Material: " + materialString + Environment.NewLine + "Color: " + colorString
                + Environment.NewLine + "Base Cost: " + baseCostDecimal + Environment.NewLine + "Total Cost: " + totalCostDecimal;
        }

        //Calculates base cost of Droid type and material
        public void BaseCost()
        {
            baseCostDecimal = 0;

            //Case structor to change cost based on droid type
            switch(modelString)
            {
                case "Protical":
                    baseCostDecimal = 100m;
                    break;

                case "Utility":
                    baseCostDecimal = 200m;
                    break;

                case "Janitor":
                    baseCostDecimal = 300m;
                    break;

                case "Astromech":
                    baseCostDecimal = 1000m;
                    break;                    
            }

            //case structor to change cost of droid depending on material
            switch(materialString)
            {
                case "Cantium":
                    baseCostDecimal += 400m;
                    break;

                case "Berilium":
                    baseCostDecimal += 1m;
                    break;

                case "Dimandium":
                    baseCostDecimal += 100000m;
                    break;
            }

            CalculateTotalCost();
        }

        //Abstract method for Calculating Total Cost
        public virtual void CalculateTotalCost()
        {
            totalCostDecimal = baseCostDecimal;
        }

    }
}
