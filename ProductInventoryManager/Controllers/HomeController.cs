using Microsoft.AspNetCore.Mvc;
using ProductInventoryManager.Models;
using System.Diagnostics;

namespace ProductInventoryManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ProductsDbContext _productDbContext;

        public HomeController(ILogger<HomeController> logger, ProductsDbContext dbContext)
        {
            _logger = logger;
            _productDbContext = dbContext;
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
    }
}
