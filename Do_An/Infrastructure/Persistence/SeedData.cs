using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class SeedData
    {
        public static void Initialize(IngredientContext Ingcontext)
        {
            Ingcontext.Database.EnsureCreated();

            if (Ingcontext.Ingredients.Any()) return;

            Ingcontext.Ingredients.AddRange(new List<Ingredient>{
                new Ingredient {
                    Name = "Coffee Powder",
                    Supplier = "Trung Nguyen Co",
                    PricePerUnit = 50000,
                    Quantity = 5,
                    Unit = "KG",
                    Type = "Coffee"
                    
                },
                new Ingredient {
                    Name = "Milk",
                    Supplier = "Vinamilk Co",
                    PricePerUnit = 120000,
                    Quantity = 5,
                    Unit = "L",
                    Type = "Milk"
                },
                new Ingredient {
                    Name = "Condensed milk",
                    Supplier = "Vinamilk Co",
                    PricePerUnit = 150000,
                    Quantity = 10,
                    Unit = "L",
                    Type = "Milk"
                },
                new Ingredient {
                    Name = "Oolong tea",
                    Supplier = "Phuc Long Co",
                    PricePerUnit = 80000,
                    Quantity = 4,
                    Unit = "KG",
                    Type = "Tea"
                },
                new Ingredient {
                    Name = "Oranges",
                    Supplier = "Viet Fruit Co",
                    PricePerUnit = 18000,
                    Quantity = 10,
                    Unit = "KG",
                    Type = "Fruit"
                },
                new Ingredient {
                    Name = "Strawberry",
                    Supplier = "Viet Fruit Co",
                    PricePerUnit = 60000,
                    Quantity = 15,
                    Unit = "KG",
                    Type = "Fruit"
                }
            });

            Ingcontext.SaveChanges();
        }
    

        
    }
}
