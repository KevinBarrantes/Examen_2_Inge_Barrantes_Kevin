using Examen_2_Barrantes_Kevin.Models;
using System.Web.Mvc;

namespace Examen_2_Barrantes_Kevin.Controllers
{
    public class FinalController : Controller
    {
        // GET: Final
        public ActionResult Final()
        {
            FinalModel smodel = new FinalModel();
            smodel.generalPrice = int.Parse(TempData["price"].ToString());
            smodel.generalOrder = TempData["order"].ToString();
            smodel.Direction = TempData["Address"].ToString();
            return View(smodel);
        }
    }
}