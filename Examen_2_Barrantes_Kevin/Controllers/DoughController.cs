using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            smodel.SizeList = FillDropDough();
            return View(smodel);
        }

        [HttpPost]
        public ActionResult Dough(DoughModel smodel)
        {
            //ModelState.Remove("SizeList");
            //if (ModelState.IsValid)
            //{                
                return RedirectToAction("Index", "Home", new { id = 99 });
            //}
            //else
            //{
            //    return View(smodel);
            //}
        }

        [HttpPost]
        public List<SelectListItem> FillDropDough()
        {
            List<SelectListItem> SizeList = new List<SelectListItem> {
            new SelectListItem { Text = "Pequeña", Value = "0" },
            new SelectListItem { Text = "Mediana", Value = "1" },
            new SelectListItem { Text = "Grande", Value = "2" },
            };
            return SizeList;
        }


    }
}