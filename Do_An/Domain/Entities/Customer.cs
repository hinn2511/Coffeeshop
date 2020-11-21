using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Customer : EntityBase,IAggregateRoot
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }
        public int Point { get; set; }
        public string CustomerType { get; set; } 


    }
}