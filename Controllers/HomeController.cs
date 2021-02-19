using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidatingFormSubmission.Models;

namespace ValidatingFormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("results")]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                return View("Results", newUser);
            }
            return View("Index");
        }
        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
