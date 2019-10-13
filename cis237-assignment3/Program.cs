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
            UI ui = new UI();
            DroidCollection droidArray = new DroidCollection();
            bool escapeBool = false;

            while (!escapeBool) {
                switch (ui.Interface()) {
                    case 1:
                        droidArray.Add();
                        break;
                    case 2:
                        droidArray.PrintArray();
                        break;
                    case 3:
                        escapeBool = true;
                        break;

                }
                
            }

            ui.Close();

        }
    }
}
