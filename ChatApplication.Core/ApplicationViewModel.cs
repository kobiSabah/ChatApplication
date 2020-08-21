
namespace ChatApplication.Core
{
    public class ApplicationViewModel : BaseViewModel
    {
        public eApplicationPage CurrentPage { get; set; } = eApplicationPage.Login;
    }
}
