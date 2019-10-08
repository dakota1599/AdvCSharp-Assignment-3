using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    abstract class Droid : IDroid
    {
        //VARIABLES
        protected string _material;
        protected string _color;
        protected const decimal BASE_COST = 20m;
        protected decimal _totalCost;

        //CONSTRUCTOR
        public Droid(string _mat, string _col) {

        }


        //PROPERTIES
        abstract public decimal TotalCost { get; set; }


        //METHODS
        abstract public void CalculateTotalCost();
    }
}
