using System.ComponentModel.DataAnnotations;

namespace PO_EjercicioBurger2.Models
{
    public class Promo
    {
        [Required]
        public int PromoId { get; set; }
        public string? PromoName { get; set; }
        public string? Description { get; set; }
        public DateTime FechaPromo {  get; set; }
        
        public int BurgerId { get; set; }
        public Burger? Burger { get; set; }
        
    }
}
