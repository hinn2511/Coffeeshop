using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;

namespace Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IEnumerable<CustomerDto> GetCustomers(string sortOrder, string customerType, string searchString, int pageIndex, int pageSize, out int count)
        {
            var customers = customerRepository.CustomerFilter(sortOrder, customerType, searchString, pageIndex, pageSize, out count);

            return customers.MappingDtos();
        }

        public CustomerDto GetCustomer(int customerId)
        {
            var customer = customerRepository.GetBy(customerId);

            return customer.MappingDto();
        }

        public IEnumerable<string> GetTypes()
        {
            return customerRepository.GetCustomerTypes();
        }

        public void CreateCustomer(CustomerDto customerDto)
        {
            var customer = customerDto.MappingCustomer();
            customerRepository.Add(customer);
        }

        public void UpdateCustomer(CustomerDto customerDto)
        {
            var customer = customerRepository.GetBy(customerDto.CustomerID);

            customerDto.MappingCustomer(customer);

            customerRepository.Update(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = customerRepository.GetBy(customerId);

            customerRepository.Delete(customer);
        }
    }
}