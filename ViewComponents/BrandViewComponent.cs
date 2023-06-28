using BTL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTL.ViewComponents
{
    public class BrandViewComponent : ViewComponent
    {
        private BTL_ASPNetCoreContext context;

        public BrandViewComponent(BTL_ASPNetCoreContext context) => this.context = context;

        public IViewComponentResult Invoke()
        {
            var brand = context.Brands.Where(b => b.Status == true).ToList();
            return View(brand);
        }
    }
}
