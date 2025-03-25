using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity2.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}