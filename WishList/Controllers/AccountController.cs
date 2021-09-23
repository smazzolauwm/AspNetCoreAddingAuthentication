
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using WishList.Models;

namespace WishList.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // fields : data members 
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager) 
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
        }

        public static void Account()
        { 
            // this is empty 
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
