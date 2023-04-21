using InlamningsUppgiftFixxo.Repositories;
using InlamningsUppgiftFixxo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InlamningsUppgiftFixxo.Controllers
{
    public class AccountController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AccountService _accountService;


        public AccountController(IHttpClientFactory httpClientFactory, AccountService accountService)
        {
            _httpClientFactory = httpClientFactory;
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel loginUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginUserViewModel);
            }

            bool result = await _accountService.LoginUserAsync(loginUserViewModel);

            if (!result)
            {
                ViewBag.Response = "Login Faild";
            }
            else
            {
                ViewBag.Response = "Login Successful";
            }

            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel registerUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerUserViewModel);
            }

            bool result = await _accountService.RegisterUserAsync(registerUserViewModel);
          
            return View();
        }

    }
}
