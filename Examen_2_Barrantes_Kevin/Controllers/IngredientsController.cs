using System.Collections.Generic;
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
            smodel.QuantityList = FillQuantity();
            return View(smodel);
        }
        [HttpPost]
        public ActionResult Ingredients(IngredientsModel smodel)
        {
            smodel.generalPrice += NewPrice(smodel);
            smodel.generalOrder += NewOrder(smodel);
            TempData["price"] = (smodel.generalPrice).ToString();
            TempData["order"] = smodel.generalOrder;
            return RedirectToAction("Address", "Address");
        }

        public List<SelectListItem> FillQuantity()
        {
            List<SelectListItem> SizeList = new List<SelectListItem> {
            new SelectListItem { Text = "Poco", Value = "0" },
            new SelectListItem { Text = "Medio", Value = "1" },
            new SelectListItem { Text = "Mucho", Value = "2" },
            };
            return SizeList;
        }

        public int NewPrice(IngredientsModel smodel)
        {
            int newPrice = 0;
            if(smodel.pepperoni == true)
            {
                switch (smodel.pepperoniQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }

            if (smodel.ham == true)
            {
                switch (smodel.hamQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }

            if (smodel.groundBeef == true)
            {
                switch (smodel.groundBeefQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }

            if (smodel.salami == true)
            {
                switch (smodel.salamiQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }

            if (smodel.bacon == true)
            {
                switch (smodel.baconQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }

            if (smodel.redPeppers == true)
            {
                switch (smodel.redPeppersQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }

            if (smodel.pineapple == true)
            {
                switch (smodel.pineappleQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }
            if (smodel.purpleOnion == true)
            {
                switch (smodel.purpleOnionQuantity)
                {
                    case "0":
                        newPrice += 400;
                        break;

                    case "1":
                        newPrice += 450;
                        break;

                    case "2":
                        newPrice += 800;
                        break;
                }
            }
            return newPrice;
        }

        public string NewOrder(IngredientsModel smodel)
        {
            string newOrder = "";
            if (smodel.pepperoni == true)
            {
                switch (smodel.pepperoniQuantity)
                {
                    case "0":
                        newOrder += ", poco pepperoni";
                        break;

                    case "1":
                        newOrder += ", pepperoni medio";
                        break;

                    case "2":
                        newOrder += ", mucho pepperoni";
                        break;
                }
            }

            if (smodel.ham == true)
            {
                switch (smodel.hamQuantity)
                {
                    case "0":
                        newOrder += ", poco jamón";
                        break;

                    case "1":
                        newOrder += ", jamón medio";
                        break;

                    case "2":
                        newOrder += ", mucho jamón";
                        break;
                }
            }

            if (smodel.groundBeef == true)
            {
                switch (smodel.groundBeefQuantity)
                {
                    case "0":
                        newOrder += ", poca carne molida";
                        break;

                    case "1":
                        newOrder += ", carne molida media";
                        break;

                    case "2":
                        newOrder += ", mucha carne molida";
                        break;
                }
            }

            if (smodel.salami == true)
            {
                switch (smodel.salamiQuantity)
                {
                    case "0":
                        newOrder += ", poco salami";
                        break;

                    case "1":
                        newOrder += ", salami medio";
                        break;

                    case "2":
                        newOrder += ", mucho salami";
                        break;
                }
            }

            if (smodel.bacon == true)
            {
                switch (smodel.baconQuantity)
                {
                    case "0":
                        newOrder += ", poco tocino";
                        break;

                    case "1":
                        newOrder += ", tocino medio";
                        break;

                    case "2":
                        newOrder += ", mucho tocino";
                        break;
                }
            }

            if (smodel.redPeppers == true)
            {
                switch (smodel.redPeppersQuantity)
                {
                    case "0":
                        newOrder += ", poco chile dulce";
                        break;

                    case "1":
                        newOrder += ", chile dulce medio";
                        break;

                    case "2":
                        newOrder += ", mucho chile dulce";
                        break;
                }
            }

            if (smodel.pineapple == true)
            {
                switch (smodel.pineappleQuantity)
                {
                    case "0":
                        newOrder += ", poca piña";
                        break;

                    case "1":
                        newOrder += ", piña media";
                        break;

                    case "2":
                        newOrder += ", mucha piña";
                        break;
                }
            }
            if (smodel.purpleOnion == true)
            {
                switch (smodel.purpleOnionQuantity)
                {
                    case "0":
                        newOrder += ", poca cebolla";
                        break;

                    case "1":
                        newOrder += ", cebolla media";
                        break;

                    case "2":
                        newOrder += ", mucha cebolla";
                        break;
                }
            }
            return newOrder;
        }

    }
}