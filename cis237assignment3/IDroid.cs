using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    interface IDroid
    {
        //Items in this class must be implemented by the direct subclasses
        void CalculateTotalCost();

        decimal TotalCost { get; set; }
    }
}
