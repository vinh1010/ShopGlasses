using BTL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTL.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private BTL_ASPNetCoreContext context;

        public CartViewComponent(BTL_ASPNetCoreContext context) => this.context = context;

        private List<Cart> carts = new List<Cart>();

        public IViewComponentResult Invoke()
        {
            var cartInSession = HttpContext.Session.GetString("My-cart");
            if (cartInSession != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            return View(carts);
        }
    }
}
