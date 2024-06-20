using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tray.Data;
using System;
using System.Linq;

namespace Tray.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TrayContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TrayContext>>()))
        {
            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
               
                {
                    Category = "Wood",
                    
                    Colour = "White",
                    Price = 4,
                    Size = "Small",
                     Shape = "Square",
                     Rating = "5"
                },
                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 4,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },
                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 4,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },
                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 4,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },

                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 5,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },

                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 5,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },

                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 5,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },

                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 5,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },

                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 5,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                },

                new Product
                {
                    Category = "Wood",

                    Colour = "White",
                    Price = 5,
                    Size = "Small",
                    Shape = "Square",
                    Rating = "5"
                }
            );
            context.SaveChanges();
        }
    }
}