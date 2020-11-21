using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class SeedData
    {
        public static void Initialize(CoffeeContext Cofcontext)
        {
            Cofcontext.Database.EnsureCreated();

            if (Cofcontext.Ingredients.Any()) return;

            Cofcontext.Ingredients.AddRange(new List<Ingredient>{
                new Ingredient {
                    Name = "Coffee Powder",
                    Supplier = "Trung Nguyen Co",
                    Price = 50000,
                    Quantity = 5,
                    Unit = "KG",
                    Type = "Coffee"
                    
                },
                new Ingredient {
                    Name = "Milk",
                    Supplier = "Vinamilk Co",
                    Price = 120000,
                    Quantity = 5,
                    Unit = "L",
                    Type = "Milk"
                },
                new Ingredient {
                    Name = "Condensed milk",
                    Supplier = "Vinamilk Co",
                    Price = 150000,
                    Quantity = 10,
                    Unit = "L",
                    Type = "Milk"
                },
                new Ingredient {
                    Name = "Oolong tea",
                    Supplier = "Phuc Long Co",
                    Price = 80000,
                    Quantity = 4,
                    Unit = "KG",
                    Type = "Tea"
                },
                new Ingredient {
                    Name = "Oranges",
                    Supplier = "Viet Fruit Co",
                    Price = 18000,
                    Quantity = 10,
                    Unit = "KG",
                    Type = "Fruit"
                },
                new Ingredient {
                    Name = "Strawberry",
                    Supplier = "Viet Fruit Co",
                    Price = 60000,
                    Quantity = 15,
                    Unit = "KG",
                    Type = "Fruit"
                }
            });

            if (Cofcontext.Customers.Any()) return;

            Cofcontext.Customers.AddRange(new List<Customer>{
                new Customer {
                    CustomerName = "Max",
                    PhoneNumber = "0907564381",
                    Address = "27 An Duong Vuong",
                    Email = "max27@gmail.com",
                    Point = 100,
                    CustomerType = "1"
                    
                },
                new Customer {
                    CustomerName = "Clara",
                    PhoneNumber = "0905684381",
                    Address = "38 Nguyen Trai",
                    Email = "clara38@gmail.com",
                    Point = 0,
                    CustomerType = "0"
                },
                new Customer {
                    CustomerName = "Brian",
                    PhoneNumber = "0907571381",
                    Address = "675 Ly Thai To",
                    Email = "brian675@gmail.com",
                    Point = 200,
                    CustomerType = "1"
                }
            });

            Cofcontext.SaveChanges();
        }
    

        
    }
}
