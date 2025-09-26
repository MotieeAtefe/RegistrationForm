using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            ViewData["Message"] = "سلام به سایت مهلا خوش آمدین";
            ViewBag.CurrentTime=DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            return View();
        }


        [HttpGet]
        public IActionResult Result()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users user)
        {
            if (ModelState.IsValid)
            {
                TempData["massage"] = "ثبت نام موفقیت‌آمیز بود!";
                return  RedirectToAction("Result");
            }
            else
            {
                TempData["massage"] = "لطفا اطلاعات را کامل وارد نمایید!";
                return RedirectToAction("Result");
            }
      
        }
    }
}
