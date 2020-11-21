using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Entities.Helpers;
using Domain.Repositories;
using CFSM.ViewModels;
using Application.Interfaces;
using Application.DTOs;

namespace CFSM.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index(string sortOrder, string customerType, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var customers = customerService.GetCustomers(sortOrder, customerType, searchString, pageIndex, pageSize, out count );
            var types = customerService.GetTypes();

            var indexVM = new CustomerViewModel()
            {
                Customers = new PaginatedList<CustomerDto>(customers, count, pageIndex, pageSize),
                Types = new SelectList(types),
                CustomerType = customerType,
                SearchString = searchString,
                SortOrder = sortOrder
            };

            return View(indexVM);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(CustomerDto customer)
        {
            if (ModelState.IsValid)
            {
                customerService.CreateCustomer(customer);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var customer = customerService.GetCustomer(id);

            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(CustomerDto customer)
        {
            if (ModelState.IsValid)
            {
                customerService.UpdateCustomer(customer);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            var customer = customerService.GetCustomer(id);

            return View(customer);
        }

        public IActionResult Delete(int id)
        {
            var customer = customerService.GetCustomer(id);

            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(int id, bool notUsed)
        {
            customerService.DeleteCustomer(id);

            return RedirectToAction("Index");
        }
    }
}