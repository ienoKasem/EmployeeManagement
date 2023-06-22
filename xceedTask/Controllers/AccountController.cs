using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using xceedTask.Models;
using xceedTask.ViewModel;

namespace xceedTask.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AccountController(UserManager<ApplicationUser> _userManger,SignInManager<ApplicationUser> _signInManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManger;
            signInManager = _signInManager;
            this.roleManager = _roleManager;
        }

        public UserManager<ApplicationUser> UserManger { get; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout() {
            signInManager.SignOutAsync();
            return RedirectToAction("Login");
        
        }

        #region login
        public IActionResult Login() {

            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Login(LoginViewModel userVM) {

            if (ModelState.IsValid)
            {

                ApplicationUser userModel = await userManager.FindByNameAsync(userVM.UserName);
                //check db or not
                if (userModel != null)
                {
                    // found username   
                   await signInManager.PasswordSignInAsync(userModel,userVM.Password,userVM.RememberMe,false);
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            else
            {
                ModelState.AddModelError("", "User Name or Password Wrong");
            }
            return View(userVM);
        }
        #endregion

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel userViewModel)
        {
            if (ModelState.IsValid==true) {
                //save Db
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName= userViewModel.UserName;
                userModel.PasswordHash = userViewModel.Password;
                userModel.RoleId= roleManager.Roles.FirstOrDefault(r => r.Name == "User").Id;
                IdentityResult result=await userManager.CreateAsync(userModel,userViewModel.Password);

                if (result.Succeeded)
                {
         
                    // create cookie
                   await signInManager.SignInAsync(userModel,false);
                    return RedirectToAction("Index", "Dashboard");
                    
                }
                else 
                {
                    //send to view
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    
                }

            }
            return View(userViewModel);
        }
    }
}
