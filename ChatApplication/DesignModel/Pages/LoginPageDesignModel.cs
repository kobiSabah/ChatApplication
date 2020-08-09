using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    class LoginPageDesignModel : LoginViewModel
    {
        private static LoginPageDesignModel s_Instance = null;

        public static LoginPageDesignModel Instance => s_Instance ?? (s_Instance = new LoginPageDesignModel());
    }
}
