using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestGridPaging.Controllers
{
    public class Employee
    {
        public string EmployeeId { get; set; }
    }
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> emp = new List<Controllers.Employee>();
            emp.Add(new Controllers.Employee() { EmployeeId = "1" });
            emp.Add(new Controllers.Employee() { EmployeeId = "2" });
            emp.Add(new Controllers.Employee() { EmployeeId = "3" });
            emp.Add(new Controllers.Employee() { EmployeeId = "4" });
            emp.Add(new Controllers.Employee() { EmployeeId = "5" });
            emp.Add(new Controllers.Employee() { EmployeeId = "6" });
            emp.Add(new Controllers.Employee() { EmployeeId = "7" });
            emp.Add(new Controllers.Employee() { EmployeeId = "8" });
            emp.Add(new Controllers.Employee() { EmployeeId = "9" });
            emp.Add(new Controllers.Employee() { EmployeeId = "10" });

            return View(emp);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
