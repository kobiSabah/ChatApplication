using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ChatApplication.Annotations;

namespace ChatApplication
{
    public class WindowViewModel: BaseViewModel
    {

        private Window m_Window;
        public eApplicationPage CurrentPage {get; set; } = eApplicationPage.Login;


        public WindowViewModel(Window i_Window)
        {
            m_Window = i_Window;
        }

    }
}
