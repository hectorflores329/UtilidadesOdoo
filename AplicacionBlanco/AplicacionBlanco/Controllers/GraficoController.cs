﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionBlanco.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prueba(string id, string id2)
        {
            ViewBag.URL = id;
            ViewBag.grafico = id2;
            return View();
        }

        public ActionResult Luis1()
        {
            return View();
        }

        public ActionResult Luis2()
        {
            return View();
        }

        public ActionResult Grafico(string id)
        {
            ViewBag.URL = id;
            return View();
        }

        public ActionResult Grafico2(string id)
        {
            ViewBag.URL = id;

            return View ();
        }
        public ActionResult PopUPClent(string id = "test.csv", string id2 = "grafico")
        {
            ViewBag.URL = id;
            ViewBag.grafico = id2;
            return View();
        }

        public ActionResult Grafico3(string id)
        {
            ViewBag.URL = id;

            return View();
        }

        public ActionResult Grafico4(string id)
        {
            ViewBag.URL = id;

            return View();
        }

        public ActionResult Grafico5(string id)
        {
            ViewBag.URL = id;

            return View();
        }
        public ActionResult Grafico6(string id)
        {
            ViewBag.URL = id;

            return View();
        }
        public ActionResult Hector(string id = "Geo1.csv")
        {
            ViewBag.URL = id;
            return View();
        }

        public ActionResult Hector2(string id = "Geo1.csv")
        {
            ViewBag.URL = id;
            return View();
        }

        public ActionResult mapa(string id = "Geo_CL_provinces_.csv")
        {
            ViewBag.URL = id;
            return View();
        }


    }
}