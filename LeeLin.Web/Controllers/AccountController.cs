using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeeLin.Web.ViewModels;
using LeeLin.Utility;

namespace LeeLin.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public ActionResult Logon(LogonModel model ,string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            if (TempData["LogonModel"].IsNotNull())
            {
                model = TempData["LogonModel"] as LogonModel;
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LogonModel model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                return RedirectToLocal(ReturnUrl);
            }

            TempData["LogonModel"] = model;

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return RedirectToAction("Logon", "Account", new { returnUrl = ReturnUrl });
        }



        #region 帮助程序
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion
    }
}
