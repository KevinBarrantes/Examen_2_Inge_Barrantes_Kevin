using System.ComponentModel.DataAnnotations;

namespace Examen_2_Barrantes_Kevin.Models
{
    public class IngredientsModel
    {
        public bool pepperoni { get; set; }
        [Display(Name = "Cantidad")]
        public string pepperoniQuantity { get; set; }
        [Display(Name = "Jamón")]
        public bool ham { get; set; }
        [Display(Name = "Cantidad")]
        public string hamQuantity { get; set; }
        [Display(Name = "Carne Molidad")]
        public bool groundBeef { get; set; }
        [Display(Name = "Cantidad")]        
        public string groundBeefQuantity { get; set; }
        public bool salami { get; set; }
        [Display(Name = "Cantidad")]       
        public string salamiQuantity { get; set; }
        [Display(Name = "Tocino")]
        public bool bacon { get; set; }
        [Display(Name = "Cantidad")]        
        public string baconQuantity { get; set; }
        [Display(Name = "Chile Dulce")]
        public bool redPeppers { get; set; }
        [Display(Name = "Cantidad")]        
        public string redPeppersQuantity { get; set; }
        [Display(Name = "Piña")]
        public bool pineapple { get; set; }
        [Display(Name = "Cantidad")]
        public string pineappleQuantity { get; set; }
        [Display(Name = "Cebolla Morada")]
        public bool purpleOnion { get; set; }
        [Display(Name = "Cantidad")]
        public string purpleOnionQuantity { get; set; }
    }
}