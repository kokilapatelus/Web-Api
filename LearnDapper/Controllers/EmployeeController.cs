using Microsoft.AspNetCore.Mvc;

namespace LearnDapper.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
