using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTL.Controllers
{
    public class LoginController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public LoginController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if(string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                ViewBag.Erorr = "Vui lòng nhập email và mật khẩu !";
                return View();
            }
            else
            {
                var data = context.Accounts.SingleOrDefault(a => a.Email == email && a.Password == password && a.Status == true);
                if(data != null)
                {
                    HttpContext.Session.SetString("username", data.UserName);
                    HttpContext.Session.SetString("email", data.Email);
                    HttpContext.Session.SetInt32("idAccount", data.AccountId);
                    return Redirect("~/Home/Index");
                }
                else
                {
                    ViewBag.Erorr = "Đăng nhập thất bại !";
                    return View();
                }
            }
            
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Accounts account, string cfpass)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(account.UserName))
            {
                ViewBag.Name = "Tên không được để trống";
                check = false;
            }

            if (string.IsNullOrEmpty(account.Password))
            {
                ViewBag.Pass = "Mật khẩu không được để trống";
                check = false;
            }

            if (string.IsNullOrEmpty(account.Email))
            {
                ViewBag.Email = "Email không được để trống";
                check = false;
            }

            if (string.IsNullOrEmpty(cfpass))
            {
                ViewBag.Cfpass = "Xác nhận mật mã không được để trống";
                check = false;
            }

            var checkEmail = context.Accounts.FirstOrDefault(a => a.Email.Equals(account.Email));
            if (checkEmail != null)
            {
                ViewBag.CheckEmail = "Email đã được đăng ký";
                check = false;
            }

            if(string.IsNullOrEmpty(cfpass) == false && string.IsNullOrEmpty(account.Password) == false)
            {
                if (account.Password.Equals(cfpass) == false)
                {
                    ViewBag.CfpassErr = "Xác nhận mật mã không chính xác";
                    check = false;
                }
            }
            account.Status = true;
            account.RoleId = 2;
            if (check)
            {
                context.Accounts.Add(account);
                context.SaveChanges();
                TempData["success"] = "Đăng ký tài khoản thành công";
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("email");
            HttpContext.Session.Remove("idAccount");
            return Redirect("~/Home/Index");
        }
    }
}