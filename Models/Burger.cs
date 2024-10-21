using System.ComponentModel.DataAnnotations;

namespace PO_EjercicioBurger2.Models
{
    public class Burger
    {
        public int BurgerId { get; set; }
        [Required]
        public string? BurgerName { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.1, 50.00)]
        public decimal Price { get; set; }
        public decimal PriceCeiling { get; set; }
        public List<Promo>? PromoName { get; set; }
        
    }
}
