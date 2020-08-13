using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebClint.Models;

namespace WebClint.Controllers
{
    public class HomeController : Controller
    {
        private CustomerRepository _customer;
        public HomeController()
        {
            _customer = new CustomerRepository();
        }
        public IActionResult Index()
        {
            return View(_customer.GetAllPersen());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Persen persen)
        {
            var b=_customer.AddPersen(persen);

            return RedirectToAction("Index");
           
        }
    }
}
