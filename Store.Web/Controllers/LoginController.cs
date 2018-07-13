using Store.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class LoginController  : Controller
    {
       private readonly ILoginService loginService;

    public LoginController(ILoginService loginService)
    {
        this.loginService = loginService;
    }

    // GET: Home
    public ActionResult Index(string category = null)
    {
            return View();
    }
  }
}