using Microsoft.Extensions.Configuration;

namespace ChatApplication.Web.Server
{
    /// <summary>
    /// Representation of JWT section in the appSettings 
    /// </summary>
    public class JwtConfiguration
    {
        private IConfiguration m_Configuration;

        public JwtConfiguration(IConfiguration configuration)
        {
            m_Configuration = configuration;
        }
        public string Audiance => m_Configuration.GetSection("Jwt").GetSection("Audiance").Value;
        public string Issuer => m_Configuration.GetSection("Jwt").GetSection("Issuer").Value;
        public string SecurityKey => m_Configuration.GetSection("Jwt").GetSection("SecurityKey").Value;
    }
}
