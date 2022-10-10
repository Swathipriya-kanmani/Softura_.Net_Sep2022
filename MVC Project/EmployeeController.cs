using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SingleEmployeeInfo()
        {
            EmployeeDetails emp = EmployeeDetails.GetSingleEmployeeInfo();
            return View(emp);
        }

        public IActionResult AllEmployeeInfo()
        {
            List<EmployeeDetails> LiEmploy = EmployeeDetails.GetAllEmployeeInfo();

            return View(LiEmploy);
        }

        public IActionResult Insert()
        {

            return View(Insert);
        }


    }

    

}
