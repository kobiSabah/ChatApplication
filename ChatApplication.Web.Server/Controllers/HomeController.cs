using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ChatApplication.Web.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Default redirect page 
        /// </summary>
        /// <param name="context">The Database representation </param>
        /// <returns></returns>
        public IActionResult Index([FromServices] ApplicationDbContext context)
        {
            return View();
        }

        /// <summary>
        /// Page for Sign in new user 
        /// </summary>
        /// <param name="userManager">User manager object from the DI</param>
        /// <returns></returns>
        public async Task<IActionResult> CreateUser([FromServices] UserManager<ApplicationUser> userManager)
        {
            var user = new ApplicationUser()
            {
                UserName = "Kobis",
                Email = "Kobis@gmail.com"
            };

            var result = await userManager.CreateAsync(user, "k9430153");

            if (result.Succeeded)
                return Content("User was created");
            return Content("User was not created");
        }

        /// <summary>
        /// Private page after user was authorize 
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Private()
        {
            return Content($"Welcome to the private page {HttpContext.User.Identity.Name}");
        }

        /// <summary>
        /// Login page 
        /// </summary>
        /// <param name="returnUrl">Redirect page when login failed  </param>
        /// <param name="signInManager">User manager for validation </param>
        /// <returns></returns>
        public async Task<IActionResult> LoginAsync(string returnUrl, [FromServices] SignInManager<ApplicationUser> signInManager)
        {
            var result = await signInManager.PasswordSignInAsync("Kobis", "k9430153", true, true);

            if(result.Succeeded)
            {
                if(string.IsNullOrEmpty(returnUrl))
                {
                    return RedirectToAction(nameof(Index));
                }

                return Redirect(returnUrl);
            }

            return Content("Login Filed");
        }

        /// <summary>
        /// Log out the user from the system 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

            return Content("LogOut");
        }
    }
}
