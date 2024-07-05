using eshop.Application.Services;
using eshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService; // IoC 

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            /*
             * There are too many reasons that you need to change some feature;
             * 1. New product property
             * 2. Where should come products from (DB, API, EXCEL)
             * 3. How products comes (EF, ADO, HttpClient) // productService is responsible for this.
             */
            // var productService = new ProductService();
            var products = _productService.GetProductCardResponses();
            return View(products);
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
