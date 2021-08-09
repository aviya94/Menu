using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces

{
    internal class LastItemInMenu : IMenuItem
    {
        private readonly IRunningItem r_SelectedItem;

        public LastItemInMenu(string i_TitleMenu, IRunningItem i_Selection)
        {
            TitleOfMenu = i_TitleMenu;

            r_SelectedItem = i_Selection;
        }

        public string TitleOfMenu { get; set; }

        public void Show()
        {

            Console.Clear();

            r_SelectedItem.ExerciseItemOperation();
        }
    }
}