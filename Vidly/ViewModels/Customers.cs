using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using Vidly.Models;

namespace Vidly.ViewModels
{
    public class Customers
    {
        public List<Customer> CustomersList { get; set; }
    }
}