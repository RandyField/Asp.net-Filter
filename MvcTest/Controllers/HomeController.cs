using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTest.Models;
namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

      
        public ActionResult Index()
        {

            return View();
        }
        [AuthorizeFilter]
        public ActionResult test()
        {
            return Content("有权访问");
        }
    }
}
