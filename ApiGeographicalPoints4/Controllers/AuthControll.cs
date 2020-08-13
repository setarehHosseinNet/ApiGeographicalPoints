using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Accounting.DataLayer2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiGeographicalPoints4.Controllers
{
    public class AuthControll : Controller
    {
        private IHttpClientFactory _client;
        public AuthControll()
        {

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Persen persen)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(Login);
            //}
            return View();
        }

       
    }
}
