using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    internal interface IMenuOfItem
    {
        string TitleOfMenu { get; set; }

        void Show();
    }
}
