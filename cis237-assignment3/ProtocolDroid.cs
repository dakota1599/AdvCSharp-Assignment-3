using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class ProtocolDroid : Droid
    {
        //VARIABLES
        private int numberLanguages;
        private const int COST_PER_LANGUAGE = 10;


        //CONSTRUCTORS
        public ProtocolDroid(string mat, string col, string dId, int numLang) : base(mat, col, dId) {
            this.numberLanguages = numLang;
            CalculateTotalCost(); //CALLS METHOD
            DroidType = "Protocol"; //SETS DROID TYPE
        }

        //METHODS

        /// <summary>
        /// ADDS THE TOTAL COST TO THE END OF THE TOSTRING METHOD IN THE PARENT CLASS.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + String.Format("Total Cost: {0}\n", TotalCost);
        }

        /// <summary>
        /// CALCULATES THE COST FOR ALL THE LANGUAGES THEN ADDS THAT WITH THE BASE COST INTO THE TOTALCOST VARIABLE.
        /// </summary>
        public override void CalculateTotalCost()
        {
            decimal languageCost = this.numberLanguages * COST_PER_LANGUAGE;

            TotalCost = baseCost + languageCost;
        }
    }
}
