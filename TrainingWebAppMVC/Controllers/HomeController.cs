using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrainingWebAppMVC.Models;

namespace TrainingWebAppMVC.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Greet()
        {
            return View();
        }

        public IActionResult Sample(int num1=0,int num2=0)
        {
            int sum = num1 + num2;
            ViewBag.addition = sum;
            return View();
        }
        public IActionResult Emp() 
        {
            Employee employee = new Employee()
            {
                EmpId = 1,
                FirstName = "Himanshi",
                LastName = "Jain",
                Salary = 650000
            };

            ViewBag.emp = employee;

            return View();
        }

        public IActionResult EmployeeForm()
        {
            return View(new Employee());
        }

        public IActionResult DisplayEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                return View(employee);
            }
            else
            {
                return View("EmployeeForm");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}