using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace DemoStart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ILog log = LogManager.GetLogger("serverlogger");
            log.Info("Info Message generated on server");

            return View();
        }
    }
}
