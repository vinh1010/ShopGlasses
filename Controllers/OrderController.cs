using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace BTL.Controllers
{
    public class OrderController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public OrderController(BTL_ASPNetCoreContext context) => this.context = context;

        private List<Cart> carts = new List<Cart>();

        public IActionResult Index()
        {
            var cartInSession = HttpContext.Session.GetString("My-cart");
            if (cartInSession != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            ViewBag.Cart = carts;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Orders order)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(order.NameCustomer))
            {
                TempData["NameCustomer"] = "Tên không được để trống";
                check = false;
            }

            if (string.IsNullOrEmpty(order.Email))
            {
                TempData["Email"] = "Email không được để trống";
                check = false;
            }

            if (string.IsNullOrEmpty(order.Phone))
            {
                TempData["Phone"] = "Số điện thoại không được để trống";
                check = false;
            }

            if (string.IsNullOrEmpty(order.Adress))
            {
                TempData["Adress"] = "Địa chỉ không được để trống";
                check = false;
            }

            if (string.IsNullOrEmpty(order.Note))
            {
                TempData["Note"] = "Ghi chú không được để trống";
                check = false;
            }

            if (check)
            {
                order.Status = 1;
                context.Orders.Add(order);
                context.SaveChanges();
                HttpContext.Session.Remove("My-cart");
                return RedirectToAction("ThankOrder", "Order");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult ThankOrder()
        {
            return View();
        }
    }
}