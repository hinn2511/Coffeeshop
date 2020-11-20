using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Persistence
{
    public class IngredientRepository : EFRepository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(IngredientContext context) : base(context)
        {
        }

        public IEnumerable<string> GetTypes()
        {
            return context.Ingredients
                            .OrderBy(m => m.Type)
                            .Select(m => m.Type)
                            .Distinct();
        }

        public IEnumerable<Ingredient> Filter(string sortOrder, string ingredientType, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.Ingredients.AsQueryable();

            if (!string.IsNullOrEmpty(ingredientType))
            {
                query = query.Where(m => m.Type == ingredientType);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.Name.Contains(searchString));
            }

            SortIngredients(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        private static void SortIngredients(string sortOrder, ref IQueryable<Ingredient> query)
        {
            switch (sortOrder)
            {
                case "name_desc":
                    query = query.OrderByDescending(m => m.Name);
                    break;
                case "name":
                    query = query.OrderBy(m => m.Name);
                    break;
                case "supplier_desc":
                    query = query.OrderByDescending(m => m.Supplier);
                    break;
                case "supplier":
                    query = query.OrderBy(m => m.Supplier);
                    break;
                case "pricePerUnit_desc":
                    query = query.OrderByDescending(m => m.PricePerUnit);
                    break;
                case "pricePerUnit":
                    query = query.OrderBy(m => m.PricePerUnit);
                    break;
                case "unit_desc":
                    query = query.OrderByDescending(m => m.Unit);
                    break;
                case "unit":
                    query = query.OrderBy(m => m.Unit);
                    break;
                case "quantity_desc":
                    query = query.OrderByDescending(m => m.Quantity);
                    break;
                case "quantity":
                    query = query.OrderBy(m => m.Quantity);
                    break;    
                case "type_desc":
                    query = query.OrderByDescending(m => m.Type);
                    break;
                case "type":
                    query = query.OrderBy(m => m.Type);
                    break;
            }
        }
    }
}