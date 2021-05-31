using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            //var customers = new List<Customer>
            //{
            //    new Customer { Id = 1, Name = "John"},
            //    new Customer { Id = 2, Name = "Jim"},
            //    new Customer { Id = 3, Name = "Jack"},
            //    new Customer { Id = 4, Name = "Tam"},
            //    new Customer { Id = 5, Name = "Jimmy"},
            //    new Customer { Id = 6, Name = "Dross"}
            //};

            var viewModel = new RandomMovieViewModel
            {            
                Customers = GetCustomers()
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                HttpNotFound();

            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John"},
                new Customer { Id = 2, Name = "Jim"},
                new Customer { Id = 3, Name = "Jack"},
                new Customer { Id = 4, Name = "Tam"},
                new Customer { Id = 5, Name = "Jimmy"},
                new Customer { Id = 6, Name = "Dross"}
            };
        }
    }
}