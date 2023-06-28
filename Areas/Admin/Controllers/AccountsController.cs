using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTL.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public AccountsController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                ViewBag.Erorr = "Vui lòng nhập email và mật khẩu!";
                return View();
            }
            else
            {
                var data = context.Accounts.SingleOrDefault(a => a.Email == email && a.Password == password && a.RoleId == 1 && a.Status == true);
                if (data != null)
                {
                    var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, email) }, "BTL_ASPSecurityScheme");
                    var principal = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync("BTL_ASPSecurityScheme", principal);
                    HttpContext.Session.SetString("useradmin", data.UserName);
                    return Redirect("/Admin/Home/Index");
                }
                else
                {
                    ViewBag.Erorr = "Đăng nhập thất bại!";
                    return View();
                }
            }
        }

        public IActionResult Logout()
        {
            var logout = HttpContext.SignOutAsync("BTL_ASPSecurityScheme");
            HttpContext.Session.Remove("useradmin");
            return RedirectToAction("Login");
        }
    }
}