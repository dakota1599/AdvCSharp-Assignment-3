/*
 DAKOTA SHAPIRO
 CIS 237 T/TH 3:30-5:45
 LAST MODIFIED: 10/13/19
 */

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

        protected string _droidId; //THE ID FOR IDENTIFYING THE DROID

        protected string _droidType = "Droid"; //THE TYPE OF DROID


        //CONSTRUCTOR
        public Droid(string mat, string col, string dId) {
            this.material = mat;
            this.color = col;
            this.DroidID = dId;

            CalculateBaseCost(); //CALL METHOD
        }


        //PROPERTIES
        public decimal TotalCost {
            get { return _totalCost; }
            set { _totalCost = value; }
        }
        
        //ID FOR SEARCHING FOR DROIDS.
        public string DroidID {
            get { return _droidId; }
            set { _droidId = value; }
        }

        //THIS ALLOWS FOR CHILD CLASSES TO SET THEIR OWN DROID TYPES.
        protected string DroidType {
            get { return _droidType; }
            set { _droidType = value; }
        }



        //PUBLIC METHODS
        abstract public void CalculateTotalCost();

        public override string ToString()
        {
            return String.Format("ID: {0}\nType: {4}\nMaterial: {1}\nColor: {2}\nBase Cost: {3}\n",DroidID, material, color, baseCost, DroidType);
        }


        //PROTECTED METHODS

        /// <summary>
        /// CALCS THE BASE COST OF THE DROID BASED ON MATERIAL AND COST.
        /// </summary>
        protected void CalculateBaseCost() {
            int materialCost;
            int colorCost;
            //CASE STRUCTURE FOR CALCULATING PRICE OF MATERIAL.
            switch (this.material.ToLower()) {
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

            //CASE STRUCTURE FOR CALCULATING PRICE OF COLOR.
            switch (this.color.ToLower()) {
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

            //ADDS TO BASE COST.
            baseCost = materialCost + colorCost;
        }
    }
}
