using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatApplication
{
    class SendByMeBubbleColorConverter : BaseConverter<SendByMeBubbleColorConverter>
    {
        private string m_SenderColor = "#78909C";
        private string m_ReceiveMessageColor = "#263238";
        public override object Convert(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            return (bool)i_Value ? m_SenderColor : m_ReceiveMessageColor;
        }

        public override object ConvertBack(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            throw new NotImplementedException();
        }
    }
}
