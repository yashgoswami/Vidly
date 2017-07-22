using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); 
        }

        // GET: Customers
        public ActionResult Index()
        {
            // Include method used to include related tables.
            var customerList = _context.Customers.Include(m => m.MembershipType).ToList();
            //var customers = new List<Customer>();
            //customers.Add(new Customer { ID = 1, Name = "Yash" });
            //customers.Add(new Customer { ID = 2, Name = "Paras" });

            //var customerList = new Customers()
            //{
            //    CustomersList = customers
            //};


            var CustomersViewModel = new Customers
            {
                CustomersList = customerList
            };

            return View(CustomersViewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomer
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        // Ensure it is called only by post. 
        // Based on argument MVC will assign posted data to customer object
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(m => m.ID == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}