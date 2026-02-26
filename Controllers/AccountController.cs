using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShopQueue.Domain.Models.RequestModel;
using ShopQueue.Logic.IServices;
using ShopQueue.Models;

namespace ShopQueue.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IAccountService _accountService;

        public AccountController(ILogger<HomeController> logger, IAccountService accountService)
        {
            _accountService = accountService;
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }


        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgetPassword(ForgetPasswordRequest request)
        {
            var result = _accountService.ValidateAndSendResetLink(request);
            return View();
        }
    }
}
