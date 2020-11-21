using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<string> GetCustomerTypes();
        IEnumerable<Customer> CustomerFilter(string sortOder,string customerType, string searchString, int pageIndex, int pageSize, out int count);
    }
}