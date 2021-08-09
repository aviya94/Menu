using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class InterfaceMenu
    {
        private Interfaces.MainMenu m_MainMenu;

        public InterfaceMenu()
        {

            MainMenu = new Interfaces.MainMenu("Welcome to the main menu - Interfaces");
            Interfaces.IAddToMenu VersionAndDigitsMenu = MainMenu.AddNewMenuToList("Version and Digits ");
            VersionAndDigitsMenu.AddNewItem("Count Captials", new CountCaptials());
            VersionAndDigitsMenu.AddNewItem("Show Version", new ShowVersion());
            Interfaces.IAddToMenu timeAndDateMenu = MainMenu.AddNewMenuToList("Show Data/Time");
            timeAndDateMenu.AddNewItem("Show Time", new ShowTime());
            timeAndDateMenu.AddNewItem("Show Date", new ShowDate());

            MainMenu.Show();
        }

        public Interfaces.MainMenu MainMenu
        {

            get { return m_MainMenu; }
            set { m_MainMenu = value; }

        }
    }
}
