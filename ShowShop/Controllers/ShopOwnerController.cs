using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShopQueue.Models;

namespace ShopQueue.Controllers
{
    public class ShopOwnerController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ShopOwnerController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
    }
}
