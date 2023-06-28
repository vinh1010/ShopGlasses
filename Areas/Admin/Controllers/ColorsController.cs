using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BTL.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ColorsController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public ColorsController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5;
            var list = context.Colors.OrderBy(c => c.ColorId).ToPagedList(page, limit);
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Colors.Where(c => c.NameColor.Contains(Search)).OrderBy(c => c.ColorId).ToPagedList(page, limit);
            }
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Colors colors)
        {
            context.Colors.Add(colors);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            Colors color = context.Colors.FirstOrDefault(c => c.ColorId == id);
            return View(color);
        }

        [HttpPost]
        public IActionResult Edit(Colors colors)
        {
            context.Colors.Update(colors);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var color = context.Colors.FirstOrDefault(c => c.ColorId == id);
            if (color != null)
            {
                context.Colors.Remove(color);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}