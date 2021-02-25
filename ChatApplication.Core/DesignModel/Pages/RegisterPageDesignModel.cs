
using ChatApplication.Core.ViewModel.Page;

namespace ChatApplication.Core
{
    public class RegisterPageDesignModel : RegisterViewModel
    {
        private static RegisterPageDesignModel s_Instance = null;

        public static RegisterPageDesignModel Instance => s_Instance ?? (s_Instance = new RegisterPageDesignModel());
    }
}
