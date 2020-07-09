using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Examen_2_Barrantes_Kevin.Models
{
    public class DoughModel
    {
        [Required]
        [Display(Name = "Tamaño")]
        public string size { get; set; }
        [Required]
        [Display(Name = "Masa")]
        public string dough { get; set; }
        public List<SelectListItem> SizeList { get; set; }
        public List<SelectListItem> DoughList { get; set; }
        [Display(Name = "Precio:")]
        public int price { get; set; }
    }
}