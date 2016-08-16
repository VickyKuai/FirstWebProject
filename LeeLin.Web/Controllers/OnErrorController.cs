using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeeLin.Web.Controllers
{
    public class OnErrorController : Controller
    {
        public ActionResult Error()
        {
            return View();
        }

    }
}
