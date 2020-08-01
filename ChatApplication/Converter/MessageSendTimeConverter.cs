using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class MessageSendTimeConverter : BaseConverter<MessageSendTimeConverter>
    {
        public override object Convert(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            var time = (DateTimeOffset)i_Value;

            // If this is today
            if (time.Date == DateTime.Now.Date)
            {
                return time.LocalDateTime.ToString("HH:mm");
            }

            //Otherwise...

            return time.Date.ToString("HH:mm MMM YYYY");
        }

        public override object ConvertBack(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            throw new NotImplementedException();
        }
    }
}
