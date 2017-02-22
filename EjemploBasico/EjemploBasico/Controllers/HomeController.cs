using EjemploBasico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploBasico.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rspv()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Rspv(PacienteModel response)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(response);
                return View("Gracias", response);
            } else
            {
                return View();
            }
        }

        [ChildActionOnly]
        public ActionResult Attendees()
        {
            return View(Repository.Resultado.Where(x => x.FueAtendido == true));
        }
    }
}