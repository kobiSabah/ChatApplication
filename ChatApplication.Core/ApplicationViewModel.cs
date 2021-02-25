
namespace ChatApplication.Core
{
    public class ApplicationViewModel : BaseViewModel
    {
        public eApplicationPage CurrentPage { get; set; } = eApplicationPage.Login;
        public string Token { get; set; }
    }
}
