using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P228_1_.Models;

namespace P228_1_.Controllers
{
    public class MercedesController : Controller
    {
        public IActionResult Index()
        {
            Car car = new Car
            {
                Name = "SLS AMG",
                price = 791000
            };

            return View(car);
        }
    }
}
