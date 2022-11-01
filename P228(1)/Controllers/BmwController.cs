using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P228_1_.Models;

namespace P228_1_.Controllers
{
    public class BmwController : Controller
    {
        public IActionResult Index()
        {
            Car car = new Car
            {
                Name = "F30",
                price = 75000
            };

            return View(car);
        }
    }
}
