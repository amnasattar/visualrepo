using Microsoft.AspNetCore.Mvc;
using Passing_model_data.Models;
using System.Diagnostics;

namespace Passing_model_data.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Ali",
                Email = "ali@email.com",
                Designation = "Managers",
                Salary = 150000
            };
            var empl = new List<Employee> {

              new  Employee { Id = 1 , Name = "Ali" , Email = "ali@email.com" , Designation = "Manager" , Salary = 50000},
              new  Employee { Id = 2 , Name = "Yasir" , Email = "yasir@email.com" , Designation = "Asst Manager" , Salary = 40000},
              new  Employee { Id = 3 , Name = "Asif" , Email = "asif@email.com" , Designation = "HR" , Salary = 45000}

            };

            ViewData["empData"] = emp;
            ViewData["empListData"] = empl;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}