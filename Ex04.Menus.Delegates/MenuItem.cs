using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void SelectionDelegate();

    public class MenuItem : IMenuOfItem
    {
        public event SelectionDelegate ShowOff;

        public string TitleOfMenu { get; set; }

        protected internal MenuItem(string i_TitleMenu)
        {
            TitleOfMenu = i_TitleMenu;
        }

        protected virtual void OnShow()
        {

            if (ShowOff != null)
            {

                ShowOff.Invoke();
            }
        }

        public void Show()
        {
            Console.Clear();

            OnShow();
        }

    }
}
