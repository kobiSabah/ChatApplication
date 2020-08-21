using ChatApplication.Core;
using Ninject;

namespace ChatApplication
{
    public class ViewModelLocator
    {
        #region Singleton

        private static ViewModelLocator s_Locator = null;

        public static ViewModelLocator Instance => s_Locator ?? (s_Locator = new ViewModelLocator());

        #endregion

        public static ApplicationViewModel ApplicationViewModel => IoC.Kernel.Get<ApplicationViewModel>();
    }
}
