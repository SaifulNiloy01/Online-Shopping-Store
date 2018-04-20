using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shoppingstore.Models;
namespace shoppingstore.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "hello world from index";
        }
        public string Browse(string category)
        {
            string message = HttpUtility.HtmlEncode(" showing category" + category);
            return message;
        }
        public ActionResult Details(int id)
        {
            var Item = new Item { Title = "item" + id };
            return View(Item);
        }
    }
}