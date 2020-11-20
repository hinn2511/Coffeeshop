using System;
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class IngredientDto
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Supplier { get; set; }           

        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:#,#.00}")]
        public decimal PricePerUnit { get; set; }

        [Range(0, 1000)]
        public int Quantity { get; set; } 

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(10, MinimumLength = 1)]
        [Required]
        public string Unit { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(30, MinimumLength = 1)]
        [Required]
        public string Type { get; set; }
    }
}