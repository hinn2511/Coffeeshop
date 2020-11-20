using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class MappingProfile
    {
        public static IngredientDto MappingDto(this Ingredient ingredient)
        {
            return new IngredientDto
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
                Supplier = ingredient.Supplier,
                PricePerUnit = ingredient.PricePerUnit,
                Quantity = ingredient.Quantity,
                Unit = ingredient.Unit,
                Type = ingredient.Type
            };
        }

        public static Ingredient MappingIngredient(this IngredientDto ingredientDto)
        {
            return new Ingredient
            {
                Id = ingredientDto.Id,
                Name = ingredientDto.Name,
                Supplier = ingredientDto.Supplier,
                Quantity = ingredientDto.Quantity,
                PricePerUnit = ingredientDto.PricePerUnit,
                Unit = ingredientDto.Unit,
                Type = ingredientDto.Type
            };
        }
        public static void MappingIngredient(this IngredientDto ingredientDto, Ingredient ingredient)
        {
            ingredient.Name = ingredientDto.Name;
            ingredient.Supplier = ingredientDto.Supplier;
            ingredient.Quantity = ingredientDto.Quantity;
            ingredient.PricePerUnit = ingredientDto.PricePerUnit;
            ingredient.Unit = ingredientDto.Unit;
            ingredient.Type = ingredientDto.Type;
        }

        public static IEnumerable<IngredientDto> MappingDtos(this IEnumerable<Ingredient> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                yield return ingredient.MappingDto();
            }
        }
    }
}