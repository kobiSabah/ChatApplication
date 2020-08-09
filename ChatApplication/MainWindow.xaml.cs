using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);
        }

        private void ExitButton_OnClick(object i_Sender, RoutedEventArgs i_E)
        {
            Close();
        }

        private void MinimizeButton_OnClick(object i_Sender, RoutedEventArgs i_E)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_OnClick(object i_Sender, RoutedEventArgs i_E)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void OnMouseDownDragWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
