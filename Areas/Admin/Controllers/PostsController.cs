using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BTL.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PostsController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public PostsController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index()
        {
            var list = context.Posts.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Posts post)
        {
            context.Posts.Add(post);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Posts post = context.Posts.FirstOrDefault(p => p.PostId == id);
            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(Posts post)
        {
            context.Posts.Update(post);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var post = context.Posts.FirstOrDefault(p => p.PostId == id);
            if (post != null)
            {
                context.Posts.Remove(post);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}