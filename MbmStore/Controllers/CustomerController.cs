using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> myCustomer = new List<Customer>();

        //GET: Customer
        public IActionResult Index()
        {

            // create a new Customer object
            Customer cust1  = new Customer("Denitsa", "Zhekova", "Godsbanen", "9000", "Aalborg C", Convert.ToDateTime("1997.07.22"));
            Customer cust2 = new Customer("Alexandru", "Paun", "Godsbanen", "9000", "Aalborg C", Convert.ToDateTime("1997.09.18"));
            Customer cust3 = new Customer("Catelyn", "Phillips", "Sondergade", "9000", "Aalborg", Convert.ToDateTime("1995.08.17"));


            // assign a viewbag property to the new Customer object
            ViewBag.Cust1 = cust1;
            ViewBag.Cust2 = cust2;
            ViewBag.Cust3 = cust3;

            cust1.addPhone("44561465");
            cust1.addPhone("44541465");
            cust2.addPhone("49561465");
            cust3.addPhone("44561785");

            // Use the method Add to add new elements to the list
            myCustomer.Add(cust1);
            myCustomer.Add(cust2);
            myCustomer.Add(cust3);

            ViewBag.Customers = myCustomer;

            return View();
        }
    }
}

