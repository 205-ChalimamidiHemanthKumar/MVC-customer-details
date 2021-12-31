using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1234, FirstName = "Hemanth", LastName = "Kumar" });
            employees.Add(new Employee() { ID = 123, FirstName = "Surya", LastName = "c" });
            employees.Add(new Employee() { ID = 123, FirstName = "Rohit", LastName = "c" });

            ViewData["employees"] = employees;

            return View();
        }
    }
}
