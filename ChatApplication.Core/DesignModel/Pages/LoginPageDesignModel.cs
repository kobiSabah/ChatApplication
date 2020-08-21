
namespace ChatApplication.Core
{
    public class LoginPageDesignModel : LoginViewModel
    {
        private static LoginPageDesignModel s_Instance = null;

        public static LoginPageDesignModel Instance => s_Instance ?? (s_Instance = new LoginPageDesignModel());
    }
}
