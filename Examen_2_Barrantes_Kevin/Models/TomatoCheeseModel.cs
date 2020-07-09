using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Examen_2_Barrantes_Kevin.Models
{
    public class TomatoCheeseModel
    {

        [Display(Name = "Salsa")]
        public bool sauce { get; set; }
        public int saucePrice { get; set; }
        [Display(Name = "Queso")]
        public bool cheese { get; set; }
        public int cheesePrice { get; set; }
        [Display(Name = "Orden")]
        public string generalOrder { get; set; }
        [Display(Name = "Precio")]
        public int generalPrice { get; set; }
    }
}