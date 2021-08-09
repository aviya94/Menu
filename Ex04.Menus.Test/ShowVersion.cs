using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class ShowVersion : Interfaces.IRunningItem
    {

        public void ExerciseItemOperation()

        {

            string UserSelectionNumberInString;
            String MessageToScreen = @"
Version: 20.2.4.30620 

Press:
0. Back ";

            PrintTitel();

            Console.WriteLine(MessageToScreen);

            UserSelectionNumberInString = Console.ReadLine();

            while (Equals(UserSelectionNumberInString, "0") == false)
            {

                Console.WriteLine("Invalid input,For back you need press 0 ...");

                UserSelectionNumberInString = Console.ReadLine();

            }

        }

        private void PrintTitel()
        {
            string CountCaptials = "Show Version";

            Console.WriteLine(CountCaptials);

            foreach (char Captials in CountCaptials)
            {
                Console.Write("_");
            }

            Console.WriteLine("{0}", Environment.NewLine);

        }

    }
}
