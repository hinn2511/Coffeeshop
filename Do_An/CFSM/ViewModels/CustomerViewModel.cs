using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Entities.Helpers;
using Application.DTOs;

namespace CFSM.ViewModels
{
    public class CustomerViewModel
    {
        public PaginatedList<CustomerDto> Customers { get; set; }
        public SelectList Types { get; set; }
        public string CustomerType { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }

    }
}