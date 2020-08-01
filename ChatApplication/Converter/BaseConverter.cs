using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace ChatApplication
{
    public abstract class BaseConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        private static T s_Converter = null;

        public override object ProvideValue(IServiceProvider i_ServiceProvider)
        {
            return s_Converter ?? (s_Converter = new T());
        }

        public abstract object Convert(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture);

        public abstract object ConvertBack(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture);
    }
}
