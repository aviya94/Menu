using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : IMenuOfItem
    {
        private const int k_StartNumber = 1;
        private readonly bool r_SubMenu;
        private readonly List<IMenuOfItem> r_ItemOfList = new List<IMenuOfItem>();
        private readonly string NotSucceedTryParse = "Choosing the wrong input,{0}Please select one of the following options again ";
        private readonly string InvalidValue = "Choosing the wrong input,The menu range is: 0 - {0}.{1} Please select one of the following options again: ";

        public string TitleOfMenu { get; set; }

        public MainMenu(string i_TitleMenu)
        {

            TitleOfMenu = i_TitleMenu;
            r_SubMenu = false;

        }

        internal MainMenu(string i_TitleMenu, bool i_SubMenu)
        {
            TitleOfMenu = i_TitleMenu;
            r_SubMenu = i_SubMenu;
        }

        public MainMenu AddNewMenuToList(string i_TitleMenu)
        {
            const bool v_SubMenu = true;

            MainMenu NewSubmenu = new MainMenu(i_TitleMenu, v_SubMenu);

            r_ItemOfList.Add(NewSubmenu);

            return NewSubmenu;
        }


        public MenuItem AddNewItem(string i_TitleMenu)
        {
            MenuItem InsertMenuItems = new MenuItem(i_TitleMenu);

            r_ItemOfList.Add(InsertMenuItems);

            return InsertMenuItems;
        }


        public void Show()
        {
            bool NotPressedZero = true;

            while (NotPressedZero == true)
            {
                int UserSelectionNumber;

                PrintMenuForScreen();

                UserSelectionNumber = UserSelection();
                
                if (UserSelectionNumber == 0)
                {
                    NotPressedZero = false;
                }

                else
                {
                    UserSelectionNumber -= 1;

                    r_ItemOfList[UserSelectionNumber].Show();
                }
            }
        }

        private int UserSelection()
        {

            string UserSelectionNumberInString;
            int UserChoiceInInt = -1;
            bool IsValueNotCorrect = true;

            Console.Write("Please enter a number of options: ");

            while (IsValueNotCorrect == true)
            {
                try
                {
                    UserSelectionNumberInString = Console.ReadLine();

                    if (int.TryParse(UserSelectionNumberInString, out UserChoiceInInt) == false)
                    {
                        throw new FormatException();
                        
                    }

                    else if (UserChoiceInInt < 0 || UserChoiceInInt > r_ItemOfList.Count)
                    {
                        throw new IndexOutOfRangeException();
                        
                    }

                    else
                    {

                        IsValueNotCorrect = false;

                    }
                }
                catch(FormatException)
                {
                    Console.Write(NotSucceedTryParse, Environment.NewLine);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.Write(InvalidValue, r_ItemOfList.Count, Environment.NewLine);
                }
            }

            return UserChoiceInInt;
        }


        private void PrintMenuForScreen()
        {
            int CounterOfItem = k_StartNumber;
            string PrintChoiceExitOrBack;

            Console.Clear();

            Console.WriteLine("{0}", TitleOfMenu);

            foreach (char Length in TitleOfMenu)
            {
                Console.Write("_");
            }

            Console.WriteLine("{0}", Environment.NewLine);

            foreach (IMenuOfItem ItemOfMenu in r_ItemOfList)
            {

                Console.WriteLine("{0}. {1}", CounterOfItem, ItemOfMenu.TitleOfMenu);
                CounterOfItem += 1;
            }
            
            PrintChoiceExitOrBack = ExitOrBack();

            Console.WriteLine("{0}{1}", PrintChoiceExitOrBack, Environment.NewLine);
        }


        private string ExitOrBack()
        {
            string PrintChoiceExitOrBack = "0. Exit";

            if (r_SubMenu == true)
            {

                PrintChoiceExitOrBack = "0. Back";

            }

            return PrintChoiceExitOrBack;
        }

    }
}
