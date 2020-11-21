using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class MappingProfile
    {

        /////////////////////////////////////// Ingredient //////////////////////////////////////////

        public static IngredientDto MappingDto(this Ingredient ingredient)
        {
            return new IngredientDto
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
                Supplier = ingredient.Supplier,
                Price = ingredient.Price,
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
                Price = ingredientDto.Price,
                Unit = ingredientDto.Unit,
                Type = ingredientDto.Type
            };
        }
        public static void MappingIngredient(this IngredientDto ingredientDto, Ingredient ingredient)
        {
            ingredient.Name = ingredientDto.Name;
            ingredient.Supplier = ingredientDto.Supplier;
            ingredient.Quantity = ingredientDto.Quantity;
            ingredient.Price = ingredientDto.Price;
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

        /////////////////////////////////////// Customer //////////////////////////////////////////
        public static CustomerDto MappingDto(this Customer customer)
        {
            return new CustomerDto
            {
                CustomerID = customer.Id,
                CustomerName = customer.CustomerName,
                PhoneNumber = customer.PhoneNumber,
                Address = customer.Address,
                Email = customer.Email,
                Point = customer.Point,
                CustomerType = customer.CustomerType
            };
        }

        public static Customer MappingCustomer(this CustomerDto customerDto)
        {
            return new Customer
            {
                Id = customerDto.CustomerID,
                CustomerName = customerDto.CustomerName,
                PhoneNumber = customerDto.PhoneNumber,
                Address = customerDto.Address,
                Email = customerDto.Email,
                Point = customerDto.Point,
                CustomerType = customerDto.CustomerType
            };
        }
        public static void MappingCustomer(this CustomerDto customerDto, Customer customer)
        {
            customer.CustomerName = customerDto.CustomerName;
            customer.PhoneNumber = customerDto.PhoneNumber;
            customer.Address = customerDto.Address;
            customer.Email = customerDto.Email;
            customer.Point = customerDto.Point;
            customer.CustomerType = customerDto.CustomerType;
        }

        public static IEnumerable<CustomerDto> MappingDtos(this IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                yield return customer.MappingDto();
            }
        }
    }
}