using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class DelegateMenu
    {
        private Delegates.MainMenu m_timeAndDateMenu;
        private Delegates.MainMenu m_VersionAndDigitsMenu;
        private Delegates.MainMenu m_MainMenu;

        public DelegateMenu()
        {
      
            MainMenu = new Delegates.MainMenu("Welcome to the main menu - Delegate ");
            VersionAndDigitsMenu = MainMenu.AddNewMenuToList("Version and Digits ");
            VersionAndDigitsMenu.AddNewItem("Count Captials").ShowOff += new CountCaptials().ExerciseItemOperation;
            VersionAndDigitsMenu.AddNewItem("Show Version").ShowOff += new ShowVersion().ExerciseItemOperation;
            timeAndDateMenu = MainMenu.AddNewMenuToList("Show Data/Time");
            timeAndDateMenu.AddNewItem("Show Time").ShowOff += new ShowTime().ExerciseItemOperation;
            timeAndDateMenu.AddNewItem("Show Date").ShowOff += new ShowDate().ExerciseItemOperation;

            MainMenu.Show();
        }

        public Delegates.MainMenu timeAndDateMenu
        {

            get { return m_timeAndDateMenu; }
            set { m_timeAndDateMenu = value; }

        }
        public Delegates.MainMenu VersionAndDigitsMenu
        {

            get { return m_VersionAndDigitsMenu; }
            set { m_VersionAndDigitsMenu = value; }

        }
        public Delegates.MainMenu MainMenu
        {

            get { return m_MainMenu; }
            set { m_MainMenu = value; }

        }
    }
}
