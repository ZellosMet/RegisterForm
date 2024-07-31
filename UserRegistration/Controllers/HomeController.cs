using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserRegistration.Models;

namespace UserRegistration.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Действия для регистрации пользователя
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.IsUserConfirm()) return RedirectToAction("Index", "Home");                
                else return View(model);
            }
            else return View(model);
        }

        // Действие для отображения формы регистрации
        [HttpGet]
        public ActionResult Register()
        {
            RegisterModel model = new RegisterModel();
            return View(model);
        }        
    }
}
