using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular.Controllers
{
    public class Rozdzial11Controller : Controller
    {
        // GET: Rozdzial11
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DwaKontrolery()
        {
            return View();
        }

      //nieopprawne
        public ActionResult DziewdziczenieKontrolerow()
        {
            return View();
        }
        public ActionResult DziewdziczenieKontrolerowPoprawne()
        {
            return View();
        }
        public ActionResult This()
        {
            return View();
        }
    }
}