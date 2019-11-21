using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OsoloWebShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public decimal Price { get; set; }
        public List<Item> Products { get; set; }
    }
}
