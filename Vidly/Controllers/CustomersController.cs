using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
             new Customer{Name = "John Smith", Id = 0},
             new Customer{Name = "Mary Williams", Id = 1}
        };

        // GET: Customers
        public ActionResult Index()
        {
           
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            if (id >= 0 && id < customers.Count)
                return View(customers[id]);
            else
                return HttpNotFound();
        }
    }
}