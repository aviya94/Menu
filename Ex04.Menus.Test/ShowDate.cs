using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class ShowDate : Interfaces.IRunningItem
    {
        public void ExerciseItemOperation()
        {
            string UserSelectionNumberInString;
            String MessageToScreen = @"
The date today is: {0}

Press:
0. Back ";

            PrintTitel();

            Console.WriteLine(MessageToScreen, DateTime.Now.ToShortDateString());

            UserSelectionNumberInString = Console.ReadLine();

            while (Equals(UserSelectionNumberInString, "0") == false)
            {
                Console.WriteLine("Invalid input,For back you need press 0 ...");
                UserSelectionNumberInString = Console.ReadLine();
            }

        }
        private void PrintTitel()
        {
            string CountCaptials = "Show Date";
            Console.WriteLine(CountCaptials);
            foreach (char Captials in CountCaptials)
            {
                Console.Write("_");
            }
            Console.WriteLine("{0}", Environment.NewLine);
        }
    }
}




