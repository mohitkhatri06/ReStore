using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Angular Speedstar Board 2000",
                    Description = 
                    "Lorem ipusm dolar sir amet, consectetuer adicoing the yello the bease.",
                    Price = 2000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Speedstar Board 2000",
                    Description = 
                    "Lorem ipusm dolar sir amet, consectetuer adicoing the yello the bease.",
                    Price = 2000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Speedstar Board 2000",
                    Description = 
                    "Lorem ipusm dolar sir amet, consectetuer adicoing the yello the bease.",
                    Price = 2000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Speedstar Board 2000",
                    Description = 
                    "Lorem ipusm dolar sir amet, consectetuer adicoing the yello the bease.",
                    Price = 2000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            
            context.SaveChanges();
        }
    }
}