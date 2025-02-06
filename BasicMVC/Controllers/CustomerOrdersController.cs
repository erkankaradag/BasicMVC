using BasicMVC.Models; // Modellerin bulunduğu namespace
using BasicMVC.ViewModels; // ViewModel'in bulunduğu namespace
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Mehmet",
                Email = "ahmet.mehmet@ahmetmehmet.com"
            };

            var orders = new List<Order>
            {
                new Order { Id = 101, ProductName = "Laptop", Price = 15000, Quantity = 1 },
                new Order { Id = 102, ProductName = "Mouse", Price = 500, Quantity = 2 },
                new Order { Id = 103, ProductName = "Klavye", Price = 1000, Quantity = 1 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };
            return View(viewModel);
        }
    }
}
