using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsoloWebShop.Models
{
    public class ProductList
    {
        private List<Product> _productList;

        public ProductList()
        {
            _productList = new List<Product>() {
            new Product() { ProductNumber = "P1", Name = "Long Yellow Jacket", Img = "1.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P2", Name = "Itchy Blue Shirt", Img = "2.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P3", Name = "Hype Basket", Img = "3.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P4", Name = "Blue Striped Shirt", Img = "4.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P5", Name = "Mustard and Flowers", Img = "5.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P6", Name = "Tini Tiny Swimsuit", Img = "6.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P7", Name = "Long Banana skirt", Img = "7.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P8", Name = "Abstract skirt art", Img = "8.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P9", Name = "Santa Swimsuit", Img = "9.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P10", Name = "Tomas Dileva", Img = "10.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P11", Name = "Kill Bill Body", Img = "11.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P12", Name = "Black Handbag", Img = "12.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P13", Name = "Miss Hippie", Img = "13.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P14", Name = "Easter Clutch", Img = "14.jpg", Price = 39.90m },
            new Product() { ProductNumber = "P15", Name = "Havannaonana", Img = "15.jpg", Price = 39.90m }};
        }

        public List<Product> GetAllProducts()
        {
            return _productList;
        }

        public Product GetProduct(string id)
        {
            return _productList.Single(p => p.ProductNumber.Equals(id));
        }
        
    }
}
