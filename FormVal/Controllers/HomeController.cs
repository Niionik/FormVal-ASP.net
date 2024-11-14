using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FormVal.Models;

namespace FormVal.Controllers
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

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Data data)
        {
            if(ModelState.IsValid) 
            {
                return View("Result", data);
            }
            else return View();
        }

        public IActionResult Result(Data data )
        {
            return View(data);
        }

        [HttpGet]
        public IActionResult RegistrationForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrationForm(Registration data)
        {
            if (ModelState.IsValid)
            {
                return View("RegistrationResult", data);
            }
            else return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
