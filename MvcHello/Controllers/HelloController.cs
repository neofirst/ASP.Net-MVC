using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHello.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Hello
        /// <summary>
        /// https://localhost:44341/Hello/Index
        /// </summary>
        /// <returns></returns>
        public string Index()
        {
            return "<em>안녕하세요. MVC 프로젝트!!!!</em>";
        }
    }
}