using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatApplication
{
    class IsSelectedVisibleConverter : BaseConverter<IsSelectedVisibleConverter>
    {
        public override object Convert(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            return (bool)i_Value ? Visibility.Visible : Visibility.Hidden;
        }

        public override object ConvertBack(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            throw new NotImplementedException();
        }
    }
}
