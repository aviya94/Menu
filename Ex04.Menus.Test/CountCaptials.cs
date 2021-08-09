using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class CountCaptials : Interfaces.IRunningItem
    {
        public void ExerciseItemOperation()

        {
            int CountOfCapitalLetters;
            string UserSelectionNumberInString;
            string Sentence;
            String MessageToScreen = @"
Count Of Capital Letters in English is : {0}

Press:
0. Back";

            PrintTitel();

            Console.WriteLine("Please enter a sentence");

            Sentence = Console.ReadLine();

            CountOfCapitalLetters = CheckNumberOfCapitalLetters(Sentence);

            Console.WriteLine(MessageToScreen, CountOfCapitalLetters);


            UserSelectionNumberInString = Console.ReadLine();

            while (Equals(UserSelectionNumberInString, "0") == false)
            {
                Console.WriteLine("Invalid input,For back you need press 0 ...");
                UserSelectionNumberInString = Console.ReadLine();
            }

        }

        private void PrintTitel()
        {
            string CountCaptials = "Count Captials";
            Console.WriteLine(CountCaptials);

            foreach (char Captials in CountCaptials)
            {
                Console.Write("_");
            }

            Console.WriteLine("{0}", Environment.NewLine);
        }

        private int CheckNumberOfCapitalLetters(string Sentence)
        {

            int CountOfCapitalLetters = 0;

            foreach (char IsBigCapital in Sentence)
            {

                if (char.IsUpper(IsBigCapital) == true)
                {
                    CountOfCapitalLetters++;
                }

            }

            return CountOfCapitalLetters;

        }

    }
}

