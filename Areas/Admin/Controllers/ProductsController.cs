using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace BTL.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public ProductsController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5;
            var list = context.Products.Include(p => p.Brand).Include(p => p.Category).Include(p => p.Material).OrderByDescending(p => p.ProductId).ToPagedList(page, limit);
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Products.Include(p => p.Brand).Include(p => p.Category).Include(p => p.Material).Where(p => p.NameProduct.Contains(Search)).OrderByDescending(p => p.ProductId).ToPagedList(page, limit);
            }
            return View(list);
        }

        public IActionResult Create()
        {
            var listCate = context.Categories.Where(c => c.ParentId.Equals("0") == false && c.Status == true).ToList();
            ViewBag.listCate = listCate;
            var listBrand = context.Brands.Where(b => b.Status == true).ToList();
            ViewBag.listBrand = listBrand;
            var listMaterial = context.Materials.Where(m => m.Status == true).ToList();
            ViewBag.listMaterial = listMaterial;
            var listColor = context.Colors.Where(c => c.Status == true).ToList();
            ViewBag.listColor = listColor;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Products product)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(product.ProductId))
            {
                ViewBag.Id = "Mã sản phẩm không được để trống";
                check = false;
            }

            var checkId = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (checkId != null)
            {
                ViewBag.CheckId = "Mã sản phẩm đã tồn tại";
                check = false;
            }

            if (string.IsNullOrEmpty(product.NameProduct))
            {
                ViewBag.Name = "Tên sản phẩm không được để trống";
                check = false;
            }

            var checkName = context.Products.FirstOrDefault(p => p.NameProduct == product.NameProduct);
            if (checkName != null)
            {
                ViewBag.CheckName = "Tên sản phẩm đã tồn tại";
                check = false;
            }

            if (product.Price <= 0)
            {
                ViewBag.Price = "Gía sản phẩm phải lớn hơn 0";
                check = false;
            }

            if(product.SalePrice > product.Price)
            {
                ViewBag.SalePrice = "Gía khuyến mãi phải lớn hơn giá sản phẩm";
                check = false;
            }

            if (string.IsNullOrEmpty(product.CategoryId))
            {
                ViewBag.Category = "Vui lòng chọn danh mục";
                check = false;
            }

            if (string.IsNullOrEmpty(product.BrandId))
            {
                ViewBag.Brand = "Vui lòng chọn nhãn hàng";
                check = false;
            }

            if (string.IsNullOrEmpty(product.MaterialId))
            {
                ViewBag.Material = "Vui lòng chọn chất liệu";
                check = false;
            }

            if (string.IsNullOrEmpty(product.Description))
            {
                ViewBag.Dess = "Vui lòng nhập mô tả sản phẩm";
                check = false;
            }

            product.Quantity = 10;
            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0 && files[0].Length > 0)
            {
                var file = files[0];
                var FileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\products", FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                    product.Image = FileName; // gán tên ảnh cho thuộc tinh Image
                }
            }
            else
            {
                ViewBag.Image = "Vui lòng chọn ảnh";
                check = false;
            }

            if (check)
            {
                context.Products.Add(product);
                context.SaveChanges();
                TempData["success"] = "Thêm mới thành công";
                return RedirectToAction("Index");
            }
            else
            {
                var listCate = context.Categories.Where(c => c.ParentId.Equals("0") == false && c.Status == true).ToList();
                ViewBag.listCate = listCate;
                var listBrand = context.Brands.Where(b => b.Status == true).ToList();
                ViewBag.listBrand = listBrand;
                var listMaterial = context.Materials.Where(m => m.Status == true).ToList();
                ViewBag.listMaterial = listMaterial;
                var listColor = context.Colors.Where(c => c.Status == true).ToList();
                ViewBag.listColor = listColor;
                return View();
            }
            
        }

        public IActionResult Edit(string id)
        {
            Products product = context.Products.FirstOrDefault(p => p.ProductId == id);
            var listCate = context.Categories.Where(c => c.ParentId.Equals("0") == false && c.Status == true).ToList();
            ViewBag.listCate = listCate;
            var listBrand = context.Brands.Where(b => b.Status == true).ToList();
            ViewBag.listBrand = listBrand;
            var listMaterial = context.Materials.Where(m => m.Status == true).ToList();
            ViewBag.listMaterial = listMaterial;
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Products product)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(product.NameProduct))
            {
                ViewBag.Name = "Tên sản phẩm không được để trống";
                check = false;
            }

            var checkName = context.Products.FirstOrDefault(p => p.NameProduct.Equals(product.NameProduct) && p.ProductId.Equals(product.ProductId) == false);
            if (checkName != null)
            {
                ViewBag.CheckName = "Tên sản phẩm đã tồn tại";
                check = false;
            }

            if (product.Price <= 0)
            {
                ViewBag.Price = "Gía sản phẩm phải lớn hơn 0";
                check = false;
            }

            if (product.SalePrice > product.Price)
            {
                ViewBag.SalePrice = "Gía khuyến mãi phải lớn hơn giá sản phẩm";
                check = false;
            }

            if (string.IsNullOrEmpty(product.CategoryId))
            {
                ViewBag.Category = "Vui lòng chọn danh mục";
                check = false;
            }

            if (string.IsNullOrEmpty(product.BrandId))
            {
                ViewBag.Brand = "Vui lòng chọn nhãn hàng";
                check = false;
            }

            if (string.IsNullOrEmpty(product.MaterialId))
            {
                ViewBag.Material = "Vui lòng chọn chất liệu";
                check = false;
            }

            if (string.IsNullOrEmpty(product.Description))
            {
                ViewBag.Dess = "Vui lòng nhập mô tả sản phẩm";
                check = false;
            }

            product.CreatedAt = product.CreatedAt;
            product.Quantity = product.Quantity;
            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0 && files[0].Length > 0)
            {
                var file = files[0];
                var FileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\products", FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                    product.Image = FileName;
                }
            }

            if (check)
            {
                context.Products.Update(product);
                context.SaveChanges();
                TempData["success"] = "Cập nhật thành công";
                return RedirectToAction("Index");
            }
            else
            {
                Products products = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                var listCate = context.Categories.Where(c => c.ParentId.Equals("0") == false && c.Status == true).ToList();
                ViewBag.listCate = listCate;
                var listBrand = context.Brands.Where(b => b.Status == true).ToList();
                ViewBag.listBrand = listBrand;
                var listMaterial = context.Materials.Where(m => m.Status == true).ToList();
                ViewBag.listMaterial = listMaterial;
                return View(products);
            }
            
        }

        public IActionResult Delete(string id)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
                TempData["success"] = "Xóa thành công";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}