using BTL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTL.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private BTL_ASPNetCoreContext context;

        public CategoryViewComponent(BTL_ASPNetCoreContext context) => this.context = context;

        public IViewComponentResult Invoke()
        {
            var category = context.Categories.Where(c => c.ParentId.Equals("C111")).ToList();
            var listCate2 = context.Categories.Where(c => c.ParentId.Equals("C222")).ToList();
            ViewBag.listCate2 = listCate2;
            var listCate3 = context.Categories.Where(c => c.ParentId.Equals("C333")).ToList();
            ViewBag.listCate3 = listCate3;
            return View(category);
        }
    }
}
