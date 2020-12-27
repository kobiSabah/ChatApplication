using ChatApplication.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Web.Server.Controllers
{
    public class ApiController : Controller
    {
        private readonly UserManager<ApplicationUser> m_UserManager;
        private readonly IConfiguration m_Configuration;
        private readonly IServiceProvider m_ServiceProvider;

        public ApiController(
            UserManager<ApplicationUser> userManager,
            IConfiguration configuration,
            IServiceProvider serviceProvider)
        {
            m_UserManager = userManager;
            m_Configuration = configuration;
            m_ServiceProvider = serviceProvider;
        }
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The user login  
        /// </summary>
        /// <returns></returns>
        [Route("api/login")]
        public async Task<ApiResponse<LogInResultDataModel>> Login([FromBody] LoginCredentialsData loginCredentialsData)
        {
            var result = new ApiResponse<LogInResultDataModel>();
            string errorMessage = "Incorrect username or password";

            // Invalid username
            if (string.IsNullOrWhiteSpace(loginCredentialsData?.UserName))
            {
                result.ErrorMessage = errorMessage;
                return result;
            }

            var user = await m_UserManager.FindByNameAsync(loginCredentialsData.UserName);

            var username = "Kobisabah";

            // Invalid password 
            if (!await m_UserManager.CheckPasswordAsync(user, loginCredentialsData.Password))
            {
                result.ErrorMessage = errorMessage;
                return result;
            }


            var claims = new[]
            {
                // Unique access token  
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                new Claim(ClaimsIdentity.DefaultNameClaimType, username)
            };

            var conig = m_ServiceProvider.GetService(typeof(JwtConfiguration)) as JwtConfiguration;

            var secureKey = Encoding.UTF8.GetBytes(conig.SecurityKey);
            var key = new SymmetricSecurityKey(secureKey);
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var audiance = conig.Audiance;
            var issuer = conig.Issuer;

            var token = new JwtSecurityToken(
                audience: audiance,
                issuer: issuer,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: signingCredentials
                );

            var jsonToken = new JwtSecurityTokenHandler().WriteToken(token);

            result.Context = new LogInResultDataModel()
            {
                AccessToken = jsonToken,
                UserName = username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };


            return result;
        }
    }
}
