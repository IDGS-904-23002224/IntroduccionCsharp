using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET: Multiplicacion
        public ActionResult Calcular(Multiplicacion m)
        {
            m.Calcular();

            return View(m);
        }
    }
}