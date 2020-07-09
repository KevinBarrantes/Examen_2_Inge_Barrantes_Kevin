using System.ComponentModel.DataAnnotations;

namespace Examen_2_Barrantes_Kevin.Models
{
    public class AddressModel
    {
        [Display(Name = "Dirección")]
        public string Direction { get; set; }
        [Display(Name = "Precio")]
        public int generalPrice { get; set; }
        [Display(Name = "Orden")]
        public string generalOrder { get; set; }
    }
}