﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWithAuth.Controllers
{
    public class PolygonController : Controller
    {
        // GET: Polygon
        [Authorize(Roles = "admin")]
        public ActionResult Polygon()
        {
            return View();
        }
    }
}