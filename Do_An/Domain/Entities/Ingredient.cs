using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Ingredient : EntityBase, IAggregateRoot
    {
        
        public string Name { get; set; }
        
        public string Supplier { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; } = 0;

        public string Unit { get; set; }
        
        public string Type { get; set; }
    }
}