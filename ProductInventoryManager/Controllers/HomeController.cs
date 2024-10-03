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

        public IActionResult AddProduct() { return View(); }
        public IActionResult Products() 
        {
            var products = _productDbContext.Products.ToList();

            return View(products);

        }

        public IActionResult AddProductForm(Product product)
        {
            if (product.Id == 0)
            {
                _productDbContext.Products.Add(product);
            }
            else
            {
                _productDbContext.Products.Update(product);
            }

            _productDbContext.SaveChanges();

            return RedirectToAction("Index");

        }


        public IActionResult ModifyProduct(int? id)
        {
            if (id > 0)
            {
                var productToModify = _productDbContext.Products.FirstOrDefault(p => p.Id == id);
                return View(productToModify);

            }
                _productDbContext.SaveChanges();
                return RedirectToAction("ModifyProduct");

        }

        public IActionResult RemoveProduct(int? id) 
        {
            var productToRemove = _productDbContext.Products.FirstOrDefault(p => p.Id == id);
            if (productToRemove != null)
            {
                _productDbContext.Products.Remove(productToRemove);
            }
            _productDbContext.SaveChanges() ;

            return RedirectToAction("Products");
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
