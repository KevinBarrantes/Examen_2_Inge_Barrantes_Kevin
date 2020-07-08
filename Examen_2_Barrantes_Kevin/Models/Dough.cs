using System.ComponentModel.DataAnnotations;

namespace Examen_2_Barrantes_Kevin.Models
{
    public class Dough
    {
        [Display(Name = "Tamaño")]
        public virtual string size { get; set; }
        [Display(Name = "Masa")]
        public virtual string dough { get; set; }
    }
}