using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class ShowTime : Interfaces.IRunningItem
    {
        public void ExerciseItemOperation()
        {

            string UserSelectionNumberInString;
            String MessageToScreen = @"
It's time now: {0}

Press:
0. Back ";

            PrintTitel();

            Console.WriteLine(MessageToScreen, DateTime.Now.ToShortTimeString());

            UserSelectionNumberInString = Console.ReadLine();

            while (Equals(UserSelectionNumberInString, "0") == false)
            {
                Console.WriteLine("Invalid input,For back you need press 0 ...");
                UserSelectionNumberInString = Console.ReadLine();
            }

        }

        private void PrintTitel()
        {
            string CountCaptials = "Show Time";

            Console.WriteLine(CountCaptials);

            foreach (char Captials in CountCaptials)
            {
                Console.Write("_");
            }

            Console.WriteLine("{0}", Environment.NewLine);

        }

    }
}
