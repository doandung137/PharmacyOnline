using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmacyOnline.Areas.Admin.Controllers
{
    public class DashboadController : Controller
    {
        // GET: Admin/Dashboad
        public ActionResult Index()
        {
            return View();
        }
    }
}