using System.ComponentModel.DataAnnotations;

namespace Examen_2_Barrantes_Kevin.Models
{
    public class AdressModel
    {
        [Display(Name = "Provincia")]
        public string Province { get; set; }

        [Display(Name = "Cantón")]
        public string canton { get; set; }
        [Display(Name = "Distrito")]
        public string District { get; set; }
    }
}