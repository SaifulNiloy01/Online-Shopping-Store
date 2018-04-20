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
        public string Details(int id)
        {
            string message = "store details" + id;
            return message;
        }
    }
}