using System.Collections.Generic;
using System.Web.Mvc;
using Examen_2_Barrantes_Kevin.Models;

namespace Examen_2_Barrantes_Kevin.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Address()
        {
            AddressModel smodel = new AddressModel();
            smodel.generalPrice = int.Parse(TempData["price"].ToString());
            smodel.generalOrder = TempData["order"].ToString();
            return View(smodel);
        }

        [HttpPost]
        public ActionResult Address(AddressModel smodel)
        {
            TempData["price"] = smodel.generalPrice.ToString();
            TempData["order"] = smodel.generalOrder.ToString();
            TempData["Address"] = smodel.Direction.ToString();
            return RedirectToAction("Final", "Final");
        }
    }
}