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
    class JanitorDroid : UtilityDroid
    {
        //VARIABLES
        protected bool trashCompactor;
        protected bool vacuum;

        //CONSTRUCTOR
        public JanitorDroid(string mat, string col, string dId, bool tBox, bool compCon, bool arm, bool tComp, bool vac) :
            base(mat, col, dId, tBox, compCon, arm)
        {
            this.trashCompactor = tComp;
            this.vacuum = vac;

            CalculateTotalCost(); //CALLS METHOD
            DroidType = "Janitor"; //SETS DROID TYPE
        }

        //METHODS


        /// <summary>
        /// OVERRIDES TOSTRING() FROM DROID AND ADDS ON THE NECESSARY INFORMATION.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + string.Format("Trash: {0}\nVacuum: {1}\n", trashCompactor,vacuum);
        }


        /// <summary>
        /// CALCULATES THE JANITOR DROID COMPONENTS THEN ADDS THEM TO THE TOTAL COST OF THE DROID.
        /// </summary>
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost(); //ADDS THE UTILITY DROID COSTS BEFORE ADDING ON THE JANITOR DROID COSTS.

            int droidAttachmentCost = 0; //HOLDS COST OF ADDED DROID COMPONENTS

            if (trashCompactor)
                droidAttachmentCost += 20;
            if (vacuum)
                droidAttachmentCost += 15;

            TotalCost += droidAttachmentCost;
        }
    }
}
