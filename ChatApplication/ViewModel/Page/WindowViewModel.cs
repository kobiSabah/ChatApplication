using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatApplication
{
    public class WindowViewModel
    {
        private Window m_Window;
        public eApplicationPage CurrentPage { get; set; } = eApplicationPage.Chat;

        public WindowViewModel(Window i_Window)
        {
            m_Window = i_Window;
        }
    }
}
