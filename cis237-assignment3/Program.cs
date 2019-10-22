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
    class Program
    {
        static void Main(string[] args)
        {
            //UI VARIABLE FOR CONTROLLING ALL THNGS RELATED TO THE USER INTERFACE.
            UI ui = new UI();
            //DROID COLLECTION TO WRAP THE DROID ARRAY.
            DroidCollection droidArray = new DroidCollection();
            //BOOL USED FOR ESCAPING THE LOOP THAT KEEPS THE USER INTERFACE RUNNING.
            bool escapeBool = false;


            //LOOP THAT KEEPS THE INTERFACE RUNNING.
            while (!escapeBool) {
                //CASE STRUCTURE FOR DETERMINING TURNING USER INPUT INTO ACTION.
                switch (ui.Interface()) {
                    case 1:
                        droidArray.Add(); //ADDS TO THE DROID ARRAY.
                        break;
                    case 2:
                        droidArray.PrintArray(); //PRINTS OUT THE DROID ARRAY.
                        break;
                    case 3:
                        //SEARCHES FOR THE ID INPUTTED BY THE USER.
                        int location = droidArray.Search(ui.Input("Enter droid ID: ").ToUpper());
                        if (location != -1) //IF THE INDEX LOCATION OF THE ID IS NOT -1 (NOT FOUND) THEN THE PROGRAM OUTPUTS THE DROID.
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            ui.Output(Environment.NewLine + droidArray.GetDroid(location).ToString());
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else { //IF ID IS NOT FOUND, SIMPLE MESSAGE IS DISPLAYED.
                            Console.ForegroundColor = ConsoleColor.Red;
                            ui.Output("\nDroid Not Found.\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;
                    case 4:
                        escapeBool = true; //SETS ESCAPE VARIABLE TO TRUE SO THE LOOP WILL STOP RUNNING.
                        break;

                }
                
            }

            //AUTOMATICALLY CLOSES THE CONSOLE WINDOW JUST IN CASE IT DOESN'T ON ITS OWN.
            ui.Close();

        }
    }
}
