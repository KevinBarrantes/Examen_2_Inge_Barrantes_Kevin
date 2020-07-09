using System.Collections.Generic;
using System.Web.Mvc;
using Examen_2_Barrantes_Kevin.Models;

namespace Examen_2_Barrantes_Kevin.Controllers
{
    public class DoughController : Controller
    {
        // GET: Dough
        public ActionResult Dough()
        {
            DoughModel smodel = new DoughModel();          
            smodel.SizeList = FillDropSize();
            smodel.DoughList = FillDropDough();
            smodel.price = 4000;
            return View(smodel);
        }

        [HttpPost]
        public ActionResult Dough(DoughModel smodel)
        {
            string order = "";
            switch (smodel.size)
            {
                case "0":
                    smodel.price = 4000;
                    order = "Pizza pequeña";
                    break;
                case "1":
                    smodel.price = 4500;
                    order = "Pizza mediana";
                    break;
                case "2":
                    smodel.price = 6000;
                    order = "Pizza grande";
                    break;
            }

            switch (smodel.size)
            {
                case "0":
                    smodel.price += 500;
                    order += " con borde clásico";
                    break;
                case "1":
                    smodel.price += 800;
                    order += " con borde relleno";
                    break;
            }

            return RedirectToAction("TomatoCheese", "TomatoCheese", new { smodel.price, order });
        }

        [HttpPost]
        public List<SelectListItem> FillDropSize()
        {
            List<SelectListItem> SizeList = new List<SelectListItem> {
            new SelectListItem { Text = "Pequeña", Value = "0" },
            new SelectListItem { Text = "Mediana", Value = "1" },
            new SelectListItem { Text = "Grande", Value = "2" },
            };
            return SizeList;
        }

        [HttpPost]
        public List<SelectListItem> FillDropDough()
        {
            List<SelectListItem> DoughList = new List<SelectListItem> {
            new SelectListItem { Text = "Clásica", Value = "0" },
            new SelectListItem { Text = "Borde Relleno", Value = "1" },
            };
            return DoughList;
        }


    }
}