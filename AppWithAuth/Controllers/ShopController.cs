using AppWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWithAuth.Controllers
{
    public class ShopController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        // GET: Shop
        public ActionResult Shop()
        {
            return View(db.Products.ToList());
        }
    }
}