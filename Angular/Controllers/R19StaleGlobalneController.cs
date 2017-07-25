using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular.Controllers
{
    public class R19StaleGlobalneController : Controller
    {
        // GET: R19StaleGlobalne
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult JLite()
        {
            return View();
        }

        //obsuga czasu 
        public ActionResult Interval()
        {
            return View();
        }
        public ActionResult Scrol()
        {
            return View();
        }
        /// <summary>
        /// zwróć uwagę na to że usługa oblicza wartość wyrażenia
        /// </summary>
        /// <returns></returns>
        public ActionResult Parse()
        {
            return View();
        }
    }
}