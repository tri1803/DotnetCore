using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Demo.Dto;
using Demo.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Demo.Web.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IUserService _userService;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        /// <summary>
        /// Login httpget
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {            
            return View();
        }
        
        /// <summary>
        /// Login httppost
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userDto)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Login(userDto);
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);

                    return Redirect("/Admin/Index");
                }                                
            }

            return View(userDto);
        }
        
        /// <summary>
        /// Login 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/User/Login");
        }
        
        /// <summary>
        /// Create Account
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                _userService.CreateUser(userDto);
                return Redirect("/User/Login");
            }

            return View(userDto);
        }
    }
}