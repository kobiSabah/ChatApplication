using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Helper
{
    class ApiHelper
    {
        public HttpClient ApiClient { get; set; }

        public ApiHelper()
        {
            InitialzeClient();
        }

        public void InitialzeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://localhost:64354");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<UserAuthenticationRepsone> Authenticate(string email, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("grant_type", "password"),
            new KeyValuePair<string, string>("email", email),
            new KeyValuePair<string, string>("password", password)
        });

            using (var responeMessage = await ApiClient.PostAsync("/api/v1/identity/login", data))
            {
                if(responeMessage.IsSuccessStatusCode)
                {
                    var result = await responeMessage.Content.ReadAsAsync<UserAuthenticationRepsone>();
                    return result;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        
    }
}
