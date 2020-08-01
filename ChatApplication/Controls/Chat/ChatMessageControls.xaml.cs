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
    /// Interaction logic for ChatMessageControls.xaml
    /// </summary>
    public partial class ChatMessageControls : UserControl
    {
        public ChatMessageControls()
        {
            InitializeComponent();
        }

        private void SendButton_OnClick(object i_Sender, RoutedEventArgs i_E)
        {
            ChatMessageListDesignModel.Instance.Send(MessageTextBox.Text);
        }
    }
}
