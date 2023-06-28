using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BTL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace BTL.Controllers
{
    public class HomeController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public HomeController(BTL_ASPNetCoreContext context) => this.context = context;

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
            var listProduct = context.Products.Where(p => p.Status == true).ToList();
            var listProSale = context.Products.Where(p => p.Status == true && p.SalePrice > 0).ToList();
            ViewBag.ListProSale = listProSale;
            return View(listProduct);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Post(int id)
        {
            var post = context.Posts.FirstOrDefault(p => p.PostId == id);
            return View(post);
        }

        public IActionResult ProductCate(string id)
        {
            var listCate = context.Categories;
            var listProduct = context.Products.ToList();
            var list = context.Products.Join(context.Categories,
                    p => p.CategoryId,
                    c => c.CategoryId,
                    (p, c) => new
                    {
                       Parent = c.ParentId
                    }
                ).Where(p => p.Parent.Equals(id)).ToList();
            return View(listProduct);
        }

        public IActionResult WithList(string id)
        {
            int idAccount = (int) HttpContext.Session.GetInt32("idAccount");
            WishLists wishList = new WishLists();
            wishList.ProductId = id;
            wishList.AccountId = idAccount;
            context.WishLists.Add(wishList);
            context.SaveChanges();

            var pro = context.Products.ToList();
            return View(pro);
        }
    }
}
