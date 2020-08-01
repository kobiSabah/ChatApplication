using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatApplication
{
    class MessageSenderAlignmentConverter : BaseConverter<MessageSenderAlignmentConverter>
    {
        public override object Convert(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            var sendByMe = (bool)i_Value;

            return sendByMe ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public override object ConvertBack(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            throw new NotImplementedException();
        }
    }
}
