using System.Windows;
using System.Windows.Controls;
using ChatApplication.Core;

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
