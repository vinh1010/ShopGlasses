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
    public class CartController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public CartController(BTL_ASPNetCoreContext context) => this.context = context;

        private List<Cart> carts = new List<Cart>();

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-cart");
            if (cartInSession != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            base.OnActionExecuting(context);
        }

        public IActionResult Index()
        {
            return View(carts);
        }

        public IActionResult Add(string id, int quantity)
        {
            quantity = quantity == 0 ? 1 : quantity;
            if(carts.Any(c => c.IdProduct == id))
            {
                
                carts.Where(c => c.IdProduct == id).First().Quantity += quantity;
            }
            else
            {
                var pro = context.Products.Find(id);
                float price =(float) pro.Price;
                if(pro.SalePrice > 0)
                {
                    price = (float)pro.SalePrice;
                }
                var Item = new Cart() { IdProduct = pro.ProductId, NameProduct = pro.NameProduct, Image = pro.Image, Quantity = quantity, Price = price };
                carts.Add(Item);
            }

            HttpContext.Session.SetString("My-cart", JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Delete(string id)
        {
            if(carts.Any(c => c.IdProduct == id))
            {
                Cart item = carts.Where(c => c.IdProduct == id).First();
                carts.Remove(item);
                HttpContext.Session.SetString("My-cart", JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Update(string id, int quantity)
        {
            if (carts.Any(c => c.IdProduct == id)) 
            {
                if(quantity <= 0)
                {
                    quantity = 1;
                }
                carts.Where(c => c.IdProduct == id).First().Quantity = quantity;
                HttpContext.Session.SetString("My-cart", JsonConvert.SerializeObject(carts));
            }
            return RedirectToAction("Index", "Cart");

        }
    }
}