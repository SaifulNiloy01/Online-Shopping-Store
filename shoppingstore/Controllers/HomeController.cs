using shoppingstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingstore.Controllers
{
    public class HomeController : Controller
    {
        ShoppingStoreEntities StoreDB = new ShoppingStoreEntities();
        private List<Item> GetTopSellingItems(int count)
        {
            return StoreDB.Items.OrderByDescending(i => i.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
        public ActionResult Index()
        {
            var items = GetTopSellingItems(10);
            return View(items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "S.I.N Limited";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact with us...";

            return View();
        }
    }
}