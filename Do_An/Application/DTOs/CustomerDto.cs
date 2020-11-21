using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class CustomerDto
    {
        [Display(Name = "ID")]
        public int CustomerID { get; set; } 

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string CustomerName { get; set; }    

        [StringLength(10, MinimumLength = 9)]
        [Display(Name = "Phone number")]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")]
        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Address { get; set; }    
        
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [Required]
        public string Email { get; set; }

        [Range(0, 1000)]
        public int Point { get; set; }  

        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "Type")]
        [Required]
        public string CustomerType { get; set; }
    }
}