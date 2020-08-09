using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;

namespace ChatApplication
{
    class LoginViewModel : BaseViewModel
    {
        public ICommand OpenLoginCommand { get; set; }
        public ICommand OpenRegisterCommand { get; set; }

        public LoginViewModel()
        {
            OpenLoginCommand = new RelayCommand(async () => await ChatPageAsync());
            OpenRegisterCommand = new RelayCommand( async () => await RegisterPageAsync());
        }

        private async Task ChatPageAsync()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = eApplicationPage.Chat;

            await Task.Delay(10);
        }

        private async Task RegisterPageAsync()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = eApplicationPage.Register;

            await Task.Delay(10);

        }

    }
}
