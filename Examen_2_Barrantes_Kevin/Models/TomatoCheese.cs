using System.ComponentModel.DataAnnotations;

namespace Examen_2_Barrantes_Kevin.Models
{
    public class TomatoCheese
    {
        [Display(Name = "Salsa")]
        public bool sauce { get; set; }
        [Display(Name = "Queso")]
        public bool cheese { get; set; }
    }
}