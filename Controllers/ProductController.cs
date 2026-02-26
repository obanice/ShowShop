using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShopQueue.Models;

namespace ShopQueue.Controllers
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
