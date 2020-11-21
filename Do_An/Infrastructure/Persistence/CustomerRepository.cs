using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Persistence
{
    public class CustomerRepository : EFRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CoffeeContext context) : base(context)
        {
        }

        public IEnumerable<string> GetCustomerTypes()
        {
            return context.Customers
                            .OrderBy(m => m.CustomerType)
                            .Select(m => m.CustomerType)
                            .Distinct();
        }

        public IEnumerable<Customer> CustomerFilter(string sortOrder, string customerType, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(customerType))
            {
                query = query.Where(m => m.CustomerType == customerType);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.CustomerName.Contains(searchString));
            }

            SortCustomers(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        private static void SortCustomers(string sortOrder, ref IQueryable<Customer> query)
        {
            switch (sortOrder)
            {
                case "customerName_desc":
                    query = query.OrderByDescending(m => m.CustomerName);
                    break;
                case "customerName":
                    query = query.OrderBy(m => m.CustomerName);
                    break;
                case "phoneNumber_desc":
                    query = query.OrderByDescending(m => m.PhoneNumber);
                    break;
                case "phoneNumber":
                    query = query.OrderBy(m => m.PhoneNumber);
                    break;
                case "address_desc":
                    query = query.OrderByDescending(m => m.Address);
                    break;
                case "address":
                    query = query.OrderBy(m => m.Address);
                    break;
                case "email_desc":
                    query = query.OrderByDescending(m => m.Email);
                    break;
                case "email":
                    query = query.OrderBy(m => m.Email);
                    break;
                case "point_desc":
                    query = query.OrderByDescending(m => m.Point);
                    break;
                case "point":
                    query = query.OrderBy(m => m.Point);
                    break;    
                case "customerType_desc":
                    query = query.OrderByDescending(m => m.CustomerName);
                    break;
                case "customerType":
                    query = query.OrderBy(m => m.CustomerType);
                    break;
            }
        }
    }
}