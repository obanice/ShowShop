using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShowShop.Models;

namespace ShowShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ProductController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Add()
        {
            return View();
        }
        
    }
}
