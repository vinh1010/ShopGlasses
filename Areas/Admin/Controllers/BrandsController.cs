using System;
using System.Collections.Generic;
using System.IO;
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
    public class BrandsController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public BrandsController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5;
            var list = context.Brands.OrderBy(b => b.BrandId).ToPagedList(page, limit);
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Brands.Where(b => b.NameBrand.Contains(Search)).OrderBy(b => b.BrandId).ToPagedList(page, limit);
            }
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Brands brands)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0 && files[0].Length > 0)
            {
                var file = files[0];
                var FileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\brands", FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                    brands.Image = FileName; // gán tên ảnh cho thuộc tinh Image
                }
            }
            context.Brands.Add(brands);
            context.SaveChanges();
            TempData["success"] = "Thêm mới thành công";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            Brands brand = context.Brands.FirstOrDefault(b => b.BrandId == id);
            return View(brand);
        }

        [HttpPost]
        public IActionResult Edit(Brands brands)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0 && files[0].Length > 0)
            {
                var file = files[0];
                var FileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\brands", FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                    brands.Image = FileName;
                }
            }

            context.Brands.Update(brands);
            context.SaveChanges();
            TempData["success"] = "Cập nhật thành công";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var checkProduct = context.Products.FirstOrDefault(p => p.BrandId == id);
            if (checkProduct != null)
            {
                TempData["eror"] = "Nhãn hàng tồn tại sản phẩm không thể xóa!";
                return RedirectToAction("Index");
            }
            else { 
                var brand = context.Brands.FirstOrDefault(b => b.BrandId == id);
                if (brand != null)
                {
                    context.Brands.Remove(brand);
                    context.SaveChanges();
                    TempData["success"] = "Xóa thành công";
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
        }
    }
}