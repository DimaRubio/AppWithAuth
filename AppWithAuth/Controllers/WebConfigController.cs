using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;

namespace AppWithAuth.Controllers
{
    public class WebConfigController : Controller
    {
        // GET: WebConfig
        public ActionResult Index()
        {
            //this.Header.Title = WebConfigurationManager.AppSettings["websiteName"];
            //txtHeader.Text = Header.Title;
            //txt1.Text = WebConfigurationManager.AppSettings["welcomeMessage"];
            ViewBag.ClientValidation = WebConfigurationManager.AppSettings["ClientValidationEnabled"];
            return View();
        }
    }
}