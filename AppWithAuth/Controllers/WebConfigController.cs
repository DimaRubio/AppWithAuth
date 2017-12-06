using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Configuration;

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
            ViewBag.clientValidation = WebConfigurationManager.AppSettings["ClientValidationEnabled"];
            //WebConfigurationManager.AppSettings["CustomValue"].V
            //config.AppSettings.Settings["Password"].Value = "something";
            ViewBag.customValue = WebConfigurationManager.AppSettings["CustomValue"];

            var configuration = WebConfigurationManager.OpenWebConfiguration("~");
            var appSettingsSection = (AppSettingsSection)configuration.GetSection("appSettings");

            


            return View();
        }
    }
}