using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OsoloWebShop.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
