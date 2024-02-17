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
                    Name = "Angular Speedster Board 2000",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Angular Board 3000",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/sb-ang2.png",
                    Brand = "Angular",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Board Speed Rush 3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/sb-core1.png",
                    Brand = "NetCore",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Net Core Super Board",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/sb-core2.png",
                    Brand = "NetCore",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "React Board Super Whizzy Fast",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "data:image/jpeg;base64,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",
                    Brand = "React",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Typescript Entry Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/sb-ts1.png",
                    Brand = "TypeScript",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Blue Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/hat-core1.png",
                    Brand = "NetCore",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green React Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/hat-react1.png",
                    Brand = "React",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple React Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/hat-react2.png",
                    Brand = "React",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Code Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/glove-code1.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Code Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/glove-code2.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple React Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/glove-react1.png",
                    Brand = "React",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green React Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/glove-react2.png",
                    Brand = "React",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Redis Red Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/boot-redis1.png",
                    Brand = "Redis",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Red Boots",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/boot-core2.png",
                    Brand = "Redis",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Core Purple Boots",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/boot-core1.png",
                    Brand = "NetCore",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Purple Boots",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/boot-ang2.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Angular Blue Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/boot-ang1.png",
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