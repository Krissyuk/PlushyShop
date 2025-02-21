using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlushyShop.Domain
{
    class Product
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public string CreatorId { get; set; }
        [ForeignKey("CreatorId")]
        public string Category { get; set; }
        public string Info { get; set; }
        public string Town { get; set; }
        public double Price { get; set; }
        public double DeliveryPrice { get; set; }
    }
}
