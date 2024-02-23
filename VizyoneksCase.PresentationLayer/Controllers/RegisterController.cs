using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VizyoneksCase.DtoLayer.Dtos.AppUserDto;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid) { 
            
                AppUser appUser=new AppUser()
                {
                    UserName = appUserRegisterDto.UserName,
                    Name = appUserRegisterDto.Name, 
                    Email = appUserRegisterDto.Email,
                    Surname=appUserRegisterDto.SurnName,
                    City="aaa",
                    ImageUrl=1


                };

                var result=await _userManager.CreateAsync(appUser,appUserRegisterDto.Password);
                if(result.Succeeded)
                {

                    return RedirectToAction("Index", "Login");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }
            
            }

            return View();
        }
    }
}
