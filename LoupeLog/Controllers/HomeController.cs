using Gibraltar.Agent;
using LoupeLog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoupeLog.Controllers
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

            _logger.LogInformation("Hom invokwee");
            try
            {
                int number = 0;
                int.Parse("ss");

            }
            catch (Exception ex)
            {
                _logger.LogError("Duzgun parse olunmadi");
                _logger.LogInformation($"{ex.Message}");
            }

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
