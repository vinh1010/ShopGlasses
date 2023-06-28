using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace BTL.Controllers
{
    public class ProductController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public ProductController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(string id)
        {
            var product = context.Products.Include(p => p.Material).Include(p => p.Brand).Include(p => p.Category).FirstOrDefault(p => p.ProductId == id);
            var proRalate = context.Products.Where(p => p.CategoryId == product.CategoryId 
            && p.ProductId.Equals(product.ProductId) == false && p.Status == true).ToList();
            ViewBag.Relate = proRalate;
            return View(product);
        }

        public IActionResult ProductByCate(string id, string Search, int page = 1)
        {
            int limit = 6;
            var lists = context.Products.Where(p => p.Status == true).OrderBy(p => p.ProductId).ToPagedList(page, limit);
            if(id == null)
            {
                if (!string.IsNullOrEmpty(Search))
                {
                    lists = context.Products.Where(p => p.Status == true && p.NameProduct.Contains(Search)).OrderBy(p => p.ProductId).ToPagedList(page, limit);
                }
                ViewBag.NameCate = "Tất cả sản phẩm";
            }
            else
            {
                lists = context.Products.Include(p => p.Category).Where(p => p.CategoryId == id && p.Status == true).OrderBy(p => p.ProductId).ToPagedList(page, limit);
                ViewBag.NameCate = lists.FirstOrDefault(p => p.CategoryId == id).Category.NameCategory;
                if (!string.IsNullOrEmpty(Search))
                {
                    lists = context.Products.Include(p => p.Category).Where(p => p.CategoryId == id && p.Status == true && p.NameProduct.Contains(Search)).OrderBy(p => p.ProductId).ToPagedList(page, limit);
                    ViewBag.NameCate = context.Products.Include(p => p.Category).FirstOrDefault(p => p.CategoryId == id).Category.NameCategory;
                }
            }

            var listCate1 = context.Categories.Where(c => c.ParentId.Equals("C111")).ToList();
            ViewBag.listCate1 = listCate1;
            var listCate2 = context.Categories.Where(c => c.ParentId.Equals("C222")).ToList();
            ViewBag.listCate2 = listCate2;
            var listCate3 = context.Categories.Where(c => c.ParentId.Equals("C333")).ToList();
            ViewBag.listCate3 = listCate3;

            var listBrand = context.Brands.ToList();
            ViewBag.brand = listBrand;
            var listMaterial = context.Materials.ToList();
            ViewBag.material = listMaterial;

            return View(lists);
        }

        public IActionResult ProductByBrand(string id, string Search, int page = 1)
        {
            int limit = 6;
            var lists = context.Products.Include(p => p.Brand).Where(p => p.BrandId == id && p.Status == true).OrderBy(p => p.ProductId).ToPagedList(page, limit);
            ViewBag.NameBrand = lists.FirstOrDefault(p => p.BrandId == id).Brand.NameBrand;
            if (!string.IsNullOrEmpty(Search))
            {
                lists = context.Products.Include(p => p.Brand).Where(p => p.BrandId == id && p.Status == true && p.NameProduct.Contains(Search)).OrderBy(p => p.ProductId).ToPagedList(page, limit);
                ViewBag.NameBrand = context.Products.Include(p => p.Brand).FirstOrDefault(p => p.BrandId == id).Brand.NameBrand;
            }

            var listCate1 = context.Categories.Where(c => c.ParentId.Equals("C111")).ToList();
            ViewBag.listCate1 = listCate1;
            var listCate2 = context.Categories.Where(c => c.ParentId.Equals("C222")).ToList();
            ViewBag.listCate2 = listCate2;
            var listCate3 = context.Categories.Where(c => c.ParentId.Equals("C333")).ToList();
            ViewBag.listCate3 = listCate3;

            var listBrand = context.Brands.ToList();
            ViewBag.brand = listBrand;

            var listMaterial = context.Materials.ToList();
            ViewBag.material = listMaterial;

            return View(lists);
        }

        public IActionResult ProductByMaterial(string id, string Search, int page = 1)
        {
            int limit = 6;
            var lists = context.Products.Include(p => p.Material).Where(p => p.MaterialId == id && p.Status == true).OrderBy(p => p.ProductId).ToPagedList(page, limit);
            ViewBag.NameMaterial = lists.FirstOrDefault(p => p.MaterialId == id).Material.NameMaterial;
            if (!string.IsNullOrEmpty(Search))
            {
                lists = context.Products.Include(p => p.Brand).Where(p => p.MaterialId == id && p.Status == true && p.NameProduct.Contains(Search)).OrderBy(p => p.ProductId).ToPagedList(page, limit);
                ViewBag.NameMaterial = context.Products.Include(p => p.Material).FirstOrDefault(p => p.MaterialId == id).Material.NameMaterial;
            }

            var listCate1 = context.Categories.Where(c => c.ParentId.Equals("C111")).ToList();
            ViewBag.listCate1 = listCate1;
            var listCate2 = context.Categories.Where(c => c.ParentId.Equals("C222")).ToList();
            ViewBag.listCate2 = listCate2;
            var listCate3 = context.Categories.Where(c => c.ParentId.Equals("C333")).ToList();
            ViewBag.listCate3 = listCate3;

            var listBrand = context.Brands.ToList();
            ViewBag.brand = listBrand;

            var listMaterial = context.Materials.ToList();
            ViewBag.material = listMaterial;

            return View(lists);
        }
    }
}