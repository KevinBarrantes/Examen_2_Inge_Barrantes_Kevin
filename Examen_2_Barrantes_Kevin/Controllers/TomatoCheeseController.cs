using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen_2_Barrantes_Kevin.Controllers
{
    public class TomatoCheeseController : Controller
    {
        // GET: TomatoCheese
        public ActionResult TomatoCheese(int price, string order)
        {
            return View();
        }
    }
}