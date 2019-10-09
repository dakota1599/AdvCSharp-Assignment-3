using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class AstromechDroid : UtilityDroid
    {
        //VARIABLES
        protected bool fireExtinquisher;
        protected int numberShips;
        protected const int COST_PER_SHIP = 20;

        //CONSTRUCTORS
        public AstromechDroid(string mat, string col, string dId, bool tBox, bool compCon, bool arm, bool fire, int ships) :
            base(mat, col, dId, tBox, compCon, arm)
        {
            this.fireExtinquisher = fire;
            this.numberShips = ships;
        }

        //METHODS

        /// <summary>
        /// OVERRIDES TOSTRING() FROM DROID AND ADDS ON THE NECESSARY INFORMATION.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + string.Format("Fire Ext: {0}\nNum of Ships: {1}\n",fireExtinquisher,numberShips);
        }


        /// <summary>
        /// CALCULATES THE ASTROMECH DROID COMPONENTS THEN ADDS THEM TO THE TOTAL COST OF THE DROID.
        /// </summary>
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost(); //ADDS THE UTILITY DROID COSTS BEFORE ADDING ON THE ASTROMECH DROID COSTS.

            int droidAttachmentCost = 0; //HOLDS COST OF ADDED DROID COMPONENTS

            if (fireExtinquisher)
                droidAttachmentCost += 10;

            //MULTIPLIES OUT THE TOTAL COST OF SHIPS
            droidAttachmentCost += numberShips * COST_PER_SHIP;

            TotalCost += droidAttachmentCost;
        }

    }
}
