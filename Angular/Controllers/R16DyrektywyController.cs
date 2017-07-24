using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular.Controllers
{
    public class R16DyrektywyController : Controller
    {
        // GET: R16Dyrektywy
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DwaZakresyISzablon()
        {
            return View();
        }
        public ActionResult NapisywanieZakresu()//i wspódzielenie
        {
            return View();
        }
        public ActionResult ZakresZMetodą()
        {
            return View();
        }
    }
}