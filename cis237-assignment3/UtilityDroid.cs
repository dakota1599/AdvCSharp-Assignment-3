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
    class UtilityDroid : Droid
    {
        //VARIABLES
        protected bool toolBox;
        protected bool computerConnection;
        protected bool arm;
       
        //CONSTRUCTOR
        public UtilityDroid(string mat, string col, string dId, bool tBox, bool compCon, bool arm) : base(mat, col, dId){
            this.toolBox = tBox;
            this.computerConnection = compCon;
            this.arm = arm;

            CalculateTotalCost(); //CALLS METHOD
            DroidType = "Utility"; //SETS DROID TYPE
        }


        //METHODS

        /// <summary>
        /// OVERRIDES TOSTRING() FROM DROID AND ADDS ON THE NECESSARY INFORMATION.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + string.Format("Total Cost: {0}\nArm: {1}\nTool Box: {2}\nComputer Connection: {3}\n",
                TotalCost, arm, toolBox, computerConnection);
        }

        /// <summary>
        /// SEES WHICH PARTS THE UTILITY DROID HAS THEN ADDS A PRICE TO THE TOTAL COST.
        /// </summary>
        public override void CalculateTotalCost()
        {
            int droidAttachmentCost = 0; //HOLDS COST OF ADDED DROID COMPONENTS

            if (toolBox)
                droidAttachmentCost += 10;
            if (computerConnection)
                droidAttachmentCost += 5;
            if (arm)
                droidAttachmentCost += 20;

            TotalCost = baseCost + droidAttachmentCost;
        }
    }
}
