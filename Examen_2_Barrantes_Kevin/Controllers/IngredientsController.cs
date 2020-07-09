using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_2_Barrantes_Kevin.Models;

namespace Examen_2_Barrantes_Kevin.Controllers
{
    public class IngredientsController : Controller
    {
        // GET: Ingredients
        public ActionResult Ingredients()
        {
            IngredientsModel smodel = new IngredientsModel();
            smodel.generalPrice = int.Parse(TempData["price"].ToString());
            smodel.generalOrder = TempData["order"].ToString();
            return View();
        }
    }
}