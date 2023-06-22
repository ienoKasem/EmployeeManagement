using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using xceedTask.Models;
using xceedTask.ViewModel;

namespace xceedTask.Controllers
{
    [Authorize(Roles = "Admin,Mang")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserManager<ApplicationUser> _userManager { get; }
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;  
            _userManager =userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Create Role
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> New(RoleViewModel roleVM)
        {

            if (ModelState.IsValid)
            {
                //save in db
                IdentityRole roleModel = new IdentityRole();
                roleModel.Name = roleVM.RoleName;
           IdentityResult result=   await _roleManager.CreateAsync(roleModel);
                if (result.Succeeded)
                {
                    return RedirectToAction("ViewUsers","UserRoles");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }


            }
            return View(roleVM);
        }
        #endregion

        #region ListRoles
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;

            return View(roles);
        }
        #endregion

        #region Edit Role
        [HttpGet]
        public async Task<IActionResult> EditRole(string ID)
        {
            var role = await _roleManager.FindByIdAsync(ID);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id : {ID} can't be found.";
                return View("Notfound");
            }
            else
            {
                var model = new EditRoleViewModel()
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id : {model.RoleId} can't be found.";
                return View("Notfound");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View(model);
            }
        }
        #endregion

        #region Delete Role
        [HttpPost]
        public async Task<IActionResult> DeleteRole(string RoleId)
        {
            var role = await _roleManager.FindByIdAsync(RoleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id : {RoleId} can't be found.";
                return View("NotFound");
            }
            else
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Role");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }
                    return RedirectToAction("ListRoles");
                }
            }
        }
        #endregion

    }

}
