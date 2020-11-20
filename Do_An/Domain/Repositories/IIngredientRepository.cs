using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        IEnumerable<string> GetTypes();
        IEnumerable<Ingredient> Filter(string sortOder,string ingredientType, string searchString, int pageIndex, int pageSize, out int count);
    }
}