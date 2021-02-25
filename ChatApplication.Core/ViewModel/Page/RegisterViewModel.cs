using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ChatApplication.Core.ApiDataModel;
using Newtonsoft.Json;
using Ninject;

namespace ChatApplication.Core.ViewModel.Page
{
    public class RegisterViewModel : BaseViewModel
    {
        #region Command
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor
        public RegisterViewModel()
        {
            RegisterCommand = new RelayParameterizedCommand(async (i_Parameters) => await RegisterAsync(i_Parameters));
        }

        #endregion

        #region Command method}

        private async Task RegisterAsync(object i_Parameters)
        {
            if (i_Parameters != null)
            {
                if (i_Parameters is object[] parameters)
                {
                    UserRegisterationRespone user = new UserRegisterationRespone
                    {
                        FirstName = parameters[0].ToString(),
                        LastName = parameters[1].ToString(),
                        Username = parameters[2].ToString(),
                        Email = parameters[3].ToString(),
                        Password = parameters[4].ToString()
                    };
                    // Verify password
                    if (user.Password.Equals(parameters[5].ToString()))
                    {
                        HttpClient client = new HttpClient();
                        StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                        using (var respone = await client.PostAsync("https://localhost:44333/api/v1/identity/register", content))
                        {
                            if (respone.IsSuccessStatusCode)
                            {
                                IoC.Kernel.Get<ApplicationViewModel>().CurrentPage = eApplicationPage.Login;
                                await Task.Delay(10);
                            }
                        }
                    }

                }
            }
            #endregion
        }
    }
}
