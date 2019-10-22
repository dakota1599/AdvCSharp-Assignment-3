using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class DroidCollection
    {
        //VARIABLES
        private Droid[] droidArray = new Droid[100];
        private UI ui = new UI();

        //CONSTRUCTORS
        public DroidCollection() {
            //MAYBE I'LL PUT SOMETHING HERE, MAYBE I WON'T.  ONLY TIME WILL TELL.
        }

        //METHODS

        /// <summary>
        /// ADDS THE NEW DROID TO AN EMPTY SPOT IN THE ARRAY.
        /// </summary>
        public void Add() {
            for (int i = 0; i < droidArray.Length; i++) {
                if (droidArray[i] == null) {
                    //CALLS THE UI METHOD THAT GETS ALL THAT INFORMATION FROM THE USER AND RETURNS A
                    //DETERMINED DROID TYPE.
                    droidArray[i] = ui.GettingDroidType();
                    i = droidArray.Length;
                }
            }
        }

        //PRINTS OUT THE ARRAY.
        public void PrintArray() {
            //CHANGES THE COLOR OF THE ARRAY LIST HEADER
            Console.ForegroundColor = ConsoleColor.Yellow;
            ui.Output("List of Droids\n-------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;


            for (int i = 0; i < droidArray.Length; i++) {
                if (droidArray[i] != null)
                {
                    ui.Output(droidArray[i].ToString());
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            ui.Output("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //USES INDEXOF TO SEARCH FOR THE INDEX OF A DROID ID.  THEN RETURNS THAT INDEX NUMBER TO BE PROCESSED AND DISPLAYED.
        public int Search(string droid)
        {
            string[] arrayIDs = new string[droidArray.Length];
            int searchPos;

            for (int i = 0; i < droidArray.Length; i++)
            {
                if (droidArray[i] != null) //IF THE CURRENT INDEX ISN'T NULL, GO AHEAD AND DO OPERATION.  ELSE, EXIT LOOP.
                {
                    arrayIDs[i] = droidArray[i].DroidID;
                }
                else
                {
                    i = droidArray.Length;
                }
            }

            searchPos = Array.IndexOf(arrayIDs, droid);

            return searchPos;

        }

        public Droid GetDroid(int loc) {
            return droidArray[loc];
        }
    }
}
