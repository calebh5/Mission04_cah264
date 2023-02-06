using Microsoft.AspNetCore.Mvc;
using Mission04_cah264.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Where my navigation works
namespace Mission04_cah264.Controllers
{
    public class HomeController : Controller
    {
        //how to get to the home page
        public IActionResult Index()
        {
            return View();
        }

        //how to get to the gradecalculator
        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        //how to get to the calculated grade page
        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();
        }
    }
}
