using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApplication.Core;
using Ninject;

namespace ChatApplication
{
    public class IoCConverter : BaseConverter<IoCConverter>
    {
        public override object Convert(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            switch((string)i_Parameter)
            {
                case nameof(ApplicationViewModel):
                    return IoC.Kernel.Get<ApplicationViewModel>();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            throw new NotImplementedException();
        }
    }
}
