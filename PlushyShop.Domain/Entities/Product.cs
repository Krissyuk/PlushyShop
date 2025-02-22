using System.ComponentModel.DataAnnotations.Schema;

namespace PlushyShop.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string User { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public string Category { get; set; }
        public string Info { get; set; }
        public string Town { get; set; }
        public double Price { get; set; }
        public double DeliveryPrice { get; set; }
    }
}
