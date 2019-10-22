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
    class UI
    {

        //METHODS

        //OUTPUT WILL OUTPUT PASSED INFO OUT TO THE CONSOLE.  IF THE USER WANTS TO, THEY CAN PASS THROUGH
        //A SECOND ARGUMENT TO PRINT OUT INFO WITHOUT PRINTING A NEW LINE.  OTHERWISE A NEW LINE IS PASSED
        //BY DEFAULT.
        public void Output(string outPut, bool newLine = true)
        {
            if (newLine)
            {
                Console.WriteLine(outPut);
            }
            else
            {
                Console.Write(outPut);
            }
        }

        //THIS IS FOR INPUTTING.  IN CASE I EVER NEED TO CHANGE THE READLINE FOR SOMETHING ELSE.
        public string Input(string words = "")
        {
            if (words != string.Empty)
            {
                Output(words, false);
            }
            string input = Console.ReadLine();
            return input;
        }

        //CALLED TO CLOSE THE CONSOLE WINDOW AND KILL THE PROGRAM.
        public void Close()
        {
            Environment.Exit(0);
        }


        //THIS HOLDS THE LOOP THAT WILL RUN THE USER INTERFACE AND RETURN WHATEVER THE USER CHOOSES.
        public int Interface()
        {
            int choice;
            PrintMenu();
            try
            {

                choice = Int32.Parse(Input());

                if (choice >= 1 && choice <= 4) //CHECKS TO SEE IF THE CHOICE IS WITHIN THE SCOPE OF CHOICES.
                {
                    return choice;
                }
                else //IF CHOICE IS NOT 1 THROUGH 5, RECURSE THROUGH METHOD.
                {
                    Output(choice.ToString() + " is not an option, please choose another." + Environment.NewLine);
                    Interface();
                }
            }
            catch
            { //CATCHES IF THE INPUT IS NOT A NUMBER.
                Output("You must enter only the number you want." + Environment.NewLine);
                Interface();
            }
            return 0;

        }

        //THIS WILL PRINT THE MENU FOR THE USER.
        private void PrintMenu()
        {
            Output("Please Select an Option \n----------------" + Environment.NewLine);
            Output("1. Add Droid\n2. Print Droid List\n3. Search\n4. Exit" + Environment.NewLine);
            Output("> ", false);
        }

        public Droid GettingDroidType() {
            Output("\nFill in the following information to add a droid.\n");
            //VARS NEEDED FOR THIS METHOD
            string mat = Input("Material Type: "); //TYPE OF MATERIAL --ALL
            string col = Input("Color: "); //COLOR SELECTION --ALL
            string dId = Input("Droid ID (ex: \"A23\"): ").ToUpper(); //DROID ID --ALL
            int language; //NUMBER OF LANGUAGES --PROTOCOL
            bool tBox; //TOOLBOX --UTILITY
            bool compCon; //COMPUTER CONNECTION --UTILITY
            bool arm; //ARM -- UTILITY
            bool trash; //TRASH COMPACTOR --JANITOR
            bool vac; //VACUUM --JANITOR
            bool fire; //FIRE EXTINQUISHER -- ASTROMECH
            int ships; //NUMBER OF SHIPS -- ASTROMECH

            //THIS IS SO WHEN SOMEONE MAKES AN INVALID ENTRY, THEY CAN RESTART FROM THIS POINT RATHER THAN STARTING
            //BACK AT THE BEGINNING OF THE METHOD.
            while (true)
            {
                switch (Input("Droid Type: ").ToLower())
                {
                    case "protocol":
                        try
                        {
                            language = int.Parse(Input("Number of Languages: "));
                            return new ProtocolDroid(mat, col, dId, language);
                        }
                        catch
                        {
                            Output("Must be a number");
                            continue; //TO START OVER THE CASE STRUCTURE.
                        }
                    case "utility":
                        try
                        {
                            Output("Please answer with true or false.\n");
                            tBox = bool.Parse(Input("Toolbox?: "));
                            compCon = bool.Parse(Input("Computer Connection?: "));
                            arm = bool.Parse(Input("Arm?: "));
                            return new UtilityDroid(mat, col, dId, tBox, compCon, arm);
                        }
                        catch {
                            Output("Must be true or false.");
                            continue; //TO START OVER THE CASE STRUCTURE.
                        }
                    case "janitor":
                        try {
                            Output("\nPlease answer with true or false.");
                            tBox = bool.Parse(Input("Toolbox?: "));
                            compCon = bool.Parse(Input("Computer Connection?: "));
                            arm = bool.Parse(Input("Arm?: "));
                            trash = bool.Parse(Input("Trash Compactor?: "));
                            vac = bool.Parse(Input("Vacuum?: "));
                            return new JanitorDroid(mat, col, dId, tBox, compCon, arm, trash, vac);
                        }
                        catch
                        {
                            Output("Must be true or false.");
                            continue; //TO START OVER THE CASE STRUCTURE.
                        }
                    case "astromech":
                        try {
                            Output("\nPlease answer with true or false.");
                            tBox = bool.Parse(Input("Toolbox?: "));
                            compCon = bool.Parse(Input("Computer Connection?: "));
                            arm = bool.Parse(Input("Arm?: "));
                            fire = bool.Parse(Input("Fire Extinquisher?: "));
                            ships = int.Parse(Input("\nAnswer with a number.\nNumber of Ships?: "));
                            return new AstromechDroid(mat, col, dId, tBox, compCon, arm, fire, ships);
                        }
                        catch {
                            Output("Invalid Entry, try again.");
                            continue; //TO START OVER THE CASE STRUCTURE.
                        }
                }
            }
        }
    }
}
