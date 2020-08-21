using System.Threading.Tasks;
using System.Windows.Input;
using Ninject;

namespace ChatApplication.Core
{
    public class LoginViewModel : BaseViewModel
    {
        #region Command
        public ICommand LoginCommand { get; set; }
        public ICommand OpenRegisterCommand { get; set; }

        #endregion

        #region Constructor
        public LoginViewModel()
        {
            LoginCommand = new RelayParameterizedCommand(async (i_Parameter) => await ChatPageAsync(i_Parameter));
            OpenRegisterCommand = new RelayCommand(async () => await RegisterPageAsync());
        }

        #endregion

        #region Command method

        /*
             TODO:: 1. Change to PasswordBox and use SecureString.
             TODO:: 2. Using dependance for switching between the pages.
         */
        private async Task ChatPageAsync(object i_Parameter)
        {
            if(i_Parameter != null)
            {
                if (i_Parameter is object[] parameter)
                {
                    IoC.Kernel.Get<ApplicationViewModel>().CurrentPage = eApplicationPage.Chat;
                }
            }

        }

        private async Task RegisterPageAsync()
        {
            IoC.Kernel.Get<ApplicationViewModel>().CurrentPage = eApplicationPage.Register;
            await Task.Delay(10);

        }
        #endregion

    }
}
