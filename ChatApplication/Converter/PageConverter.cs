using System;
using System.Diagnostics;
using System.Globalization;

namespace ChatApplication
{
    public class PageConverter : BaseConverter<PageConverter>
    {
        public override object Convert(object i_Value, Type i_TargetType, object i_Parameter, CultureInfo i_Culture)
        {
            switch((eApplicationPage)i_Value)
            {
                case eApplicationPage.Login:
                    return new LoginPage();

                case eApplicationPage.Register:
                    return new RegisterPage();

                case eApplicationPage.Chat:
                    return new ChatPage();

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
