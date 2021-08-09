using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IAddToMenu : IMenuItem
    {

        IAddToMenu AddNewMenuToList(string i_TitleMenu);

        void AddNewItem(string i_TitleMenu, IRunningItem i_Selection);

    }
}
