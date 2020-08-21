using System.Windows;
using ChatApplication.Core;

namespace ChatApplication
{
    public class WindowViewModel: BaseViewModel
    {
        #region Private members

        private Window m_Window;
        #endregion

        #region Constructor

        public WindowViewModel(Window i_Window)
        {
            m_Window = i_Window;
        }

        #endregion
    }
}
