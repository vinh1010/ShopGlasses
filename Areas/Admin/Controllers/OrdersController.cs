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
    public class OrdersController : Controller
    {
        private BTL_ASPNetCoreContext context;

        public OrdersController(BTL_ASPNetCoreContext context) => this.context = context;

        public IActionResult Index(string Search, int page = 1)
        {
            int limit = 5;
            var list = context.Orders.OrderBy(o => o.OrderId).ToPagedList(page, limit);
            if (!string.IsNullOrEmpty(Search))
            {
                list = context.Orders.Where(o => o.Email.Contains(Search)).OrderBy(o => o.OrderId).ToPagedList(page, limit);
            }
            return View(list);
        }
    }
}