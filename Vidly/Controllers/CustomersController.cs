using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer { ID = 1, Name = "Yash" });
            customers.Add(new Customer { ID = 2, Name = "Paras" });

            var customerList = new Customers()
            {
                CustomersList = customers
            };


            return View(customerList);
        }
    }
}