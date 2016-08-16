using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeeLin.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            //标记异常已处理，则不会再执行Application_Error
            filterContext.ExceptionHandled = true;
            filterContext.Result = new RedirectResult(Url.Action("Error", "OnError"));
        }


       
    }
}
