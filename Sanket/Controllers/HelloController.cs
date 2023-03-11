using Microsoft.AspNetCore.Mvc;
using Sanket.Models;

namespace Sanket.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Sanket",
                Gender = "Male"
            };

            return View(student);

        }
    }
}
