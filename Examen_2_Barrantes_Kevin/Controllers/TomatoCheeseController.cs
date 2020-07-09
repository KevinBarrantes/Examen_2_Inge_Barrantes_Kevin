using Examen_2_Barrantes_Kevin.Models;
using System.Web.Mvc;

namespace Examen_2_Barrantes_Kevin.Controllers
{
    public class TomatoCheeseController : Controller
    {
        // GET: TomatoCheese
        public ActionResult TomatoCheese(int price, string order)
        {
            TomatoCheeseModel smodel = new TomatoCheeseModel();
            smodel.generalPrice = price;
            smodel.generalOrder = order;
            return View(smodel);
        }

        [HttpPost]
        public ActionResult TomatoCheese(TomatoCheeseModel smodel)
        {
            if (smodel.sauce == true)
            {
                smodel.generalPrice += 1000;
                smodel.generalOrder += ", salsa de tomate";
            }

            if (smodel.cheese == true)
            {
                smodel.generalPrice += 400;
                smodel.generalOrder += ", con queso";
            }
            TempData["price"] = (smodel.generalPrice).ToString();
            TempData["order"] = smodel.generalOrder;

            return RedirectToAction("Ingredients", "Ingredients");
        }

        public int NewPrice(bool sauce, bool cheese)
        {
            int newPrice = 0;
            if(sauce == true)
            {
                newPrice += 1000;
            }
            
            if(cheese == true)
            {
                newPrice += 400;                
            }

            return newPrice;
        }

        //public string NewOrder(bool sauce, bool cheese)
        //{
        //    string newString = "";
        //    if (sauce == true)
        //    {
        //        newString += 1000;
        //    }

        //    if (cheese == true)
        //    {
        //        newPrice += 400;
        //    }

        //    if (smodel.sauce == true)
        //    {
        //        smodel.generalPrice += 1000;
        //        smodel.generalOrder += ", salsa de tomate";
        //    }

        //    if (smodel.cheese == true)
        //    {
        //        smodel.generalPrice += 400;
        //        smodel.generalOrder += ", con queso";
        //    }

        //    return smodel;
        //}
    }
}