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
    public class MaterialsController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public MaterialsController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5;
            var list = context.Materials.OrderBy(m => m.MaterialId).ToPagedList(page, limit);
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Materials.Where(m => m.NameMaterial.Contains(Search)).OrderBy(m => m.MaterialId).ToPagedList(page, limit);
            }
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Materials material)
        {
            context.Materials.Add(material);
            context.SaveChanges();
            TempData["success"] = "Thêm mới thành công";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string id)
        {
            Materials material = context.Materials.FirstOrDefault(m => m.MaterialId == id);
            return View(material);
        }

        [HttpPost]
        public IActionResult Edit(Materials material)
        {
            context.Materials.Update(material);
            context.SaveChanges();
            TempData["success"] = "Cập nhật thành công";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var checkPro = context.Products.FirstOrDefault(p => p.MaterialId == id);
            if(checkPro != null)
            {
                TempData["eror"] = "Chất liệu tồn tại sản phẩm không thể xóa!";
                return RedirectToAction("Index");
            }
            else { 
                var material = context.Materials.FirstOrDefault(m => m.MaterialId == id);
                if (material != null)
                {
                    context.Materials.Remove(material);
                    context.SaveChanges();
                    TempData["success"] = "Xóa thành công";
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
        }
    }
}