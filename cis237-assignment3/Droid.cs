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
        protected string material;
        protected string color;
        protected decimal baseCost;
        protected decimal _totalCost;

        protected string _droidType = "Droid"; //THE TYPE OF DROID
        protected string _droidId; //THE ID FOR IDENTIFYING THE DROID

        //CONSTRUCTOR
        public Droid(string mat, string col, string dId) {
            this.material = mat;
            this.color = col;
            this.DroidID = dId;

            CalculateBaseCost();
        }


        //PROPERTIES
        public decimal TotalCost {
            get { return _totalCost; }
            set { _totalCost = value; }
        }
        
        public string DroidType { get { return _droidType; } }
        public string DroidID {
            get { return _droidId; }
            set { _droidId = value; }
        }



        //PUBLIC METHODS
        abstract public void CalculateTotalCost();

        public override string ToString()
        {
            return String.Format("ID: {0}\nType: {1}\nMaterial: {2}\nColor: {3}\nBase Cost: {4}\n",DroidID, DroidType, material, color, baseCost);
        }


        //PROTECTED METHODS

        /// <summary>
        /// CALCS THE BASE COST OF THE DROID BASED ON MATERIAL AND COST.
        /// </summary>
        protected void CalculateBaseCost() {
            int materialCost;
            int colorCost;
            switch (this.material) {
                case "steel":
                    materialCost = 10;
                    break;
                case "alum":
                    materialCost = 7;
                    break;
                case "wood":
                    materialCost = 5;
                    break;
                default:
                    materialCost = 3;
                    break;
            }

            switch (this.color) {
                case "black":
                    colorCost = 10;
                    break;
                case "blue":
                    colorCost = 8;
                    break;
                case "red":
                    colorCost = 6;
                    break;
                case "green":
                    colorCost = 4;
                    break;
                default:
                    colorCost = 2;
                    break;
            }

            baseCost = materialCost + colorCost;
        }
    }
}
