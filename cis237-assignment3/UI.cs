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
        public string Input()
        {
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

                if (choice >= 1 && choice <= 5) //CHECKS TO SEE IF THE CHOICE IS WITHIN THE SCOPE OF CHOICES.
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
            Output("1. Load Beverage List\n2. Print Beverage List\n3. Search by ID\n4. Add Beverage\n5. Exit\n" + Environment.NewLine);
            Output("> ", false);
        }
    }
}
