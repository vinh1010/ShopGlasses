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
    public class CategoriesController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public CategoriesController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5;
            var list = context.Categories.OrderBy(c => c.CategoryId).ToPagedList(page, limit);
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Categories.Where(c => c.NameCategory.Contains(Search)).OrderBy(c => c.CategoryId).ToPagedList(page, limit);
            }
            return View(list);
        }

        public IActionResult Create()
        {
            var listCate = context.Categories.Where(c => c.ParentId == "0").ToList();
            return View(listCate);
        }

        [HttpPost]
        public IActionResult Create(Categories categories)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(categories.CategoryId))
            {
                ViewBag.Id = "Mã danh mục không được để trống";
                check = false;
            }

            var checkId = context.Categories.FirstOrDefault(p => p.CategoryId == categories.CategoryId);
            if (checkId != null)
            {
                ViewBag.CheckId = "Mã danh mục đã tồn tại";
                check = false;
            }

            if (string.IsNullOrEmpty(categories.NameCategory))
            {
                ViewBag.Name = "Tên danh mục không được để trống";
                check = false;
            }

            var checkName = context.Categories.FirstOrDefault(p => p.NameCategory == categories.NameCategory);
            if (checkName != null)
            {
                ViewBag.CheckName = "Mã danh mục đã tồn tại";
                check = false;
            }

            if (check)
            {
                context.Categories.Add(categories);
                context.SaveChanges();
                TempData["success"] = "Thêm mới thành công";
                return RedirectToAction("Index");
            }
            else
            {
                var listCate = context.Categories.Where(c => c.ParentId == "0").ToList();
                return View(listCate);
            }
        }

        public IActionResult Edit(string id)
        {
            var listCate = context.Categories.Where(c => c.ParentId == "0").ToList();
            Categories category = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            ViewBag.listCate = listCate;
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Categories categories)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(categories.NameCategory))
            {
                ViewBag.Name = "Tên danh mục không được để trống";
                check = false;
            }

            var checkName = context.Categories.FirstOrDefault(c => c.NameCategory.Equals(categories.NameCategory) && c.CategoryId.Equals(categories.CategoryId) == false);
            if (checkName != null)
            {
                ViewBag.CheckName = "Tên danh mục đã tồn tại";
                check = false;
            }

            if (check)
            {
                context.Categories.Update(categories);
                context.SaveChanges();
                TempData["success"] = "Cập nhật thành công";
                return RedirectToAction("Index");
            }
            else
            {
                var listCate = context.Categories.Where(c => c.ParentId == "0").ToList();
                Categories category = context.Categories.FirstOrDefault(c => c.CategoryId == categories.CategoryId);
                ViewBag.listCate = listCate;
                return View(category);
            }  
        }

        public IActionResult Delete(string id)
        {
            var checkCate = context.Categories.FirstOrDefault(c => c.CategoryId == id && c.ParentId.Equals("0"));
            var checkPro = context.Products.FirstOrDefault(p => p.CategoryId == id);
            if(checkCate != null || checkPro != null)
            {
                TempData["eror"] = "Danh mục tồn tại sản phẩm hoặc là danh mục cha không thể xóa!";
                return RedirectToAction("Index");
            }
            var cate = context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (cate != null)
            {
                context.Categories.Remove(cate);
                context.SaveChanges();
                TempData["success"] = "Xóa thành công";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}