using InlamningsUppgiftFixxo.Helpers;
using InlamningsUppgiftFixxo.Models;
using InlamningsUppgiftFixxo.Repositories;
using InlamningsUppgiftFixxo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace InlamningsUppgiftFixxo.Controllers
{
    public class AdminController : Controller
    {
        private readonly ProductService _productService;
        private IHttpContextAccessor _httpContextAccessor { get; set; }

        public AdminController(ProductService productService, IHttpContextAccessor httpContextAccessor)
        {
            _productService = productService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> AdminIndex()
        {
            var token = _httpContextAccessor.HttpContext?.Request.Cookies["accessToken"];
            bool result = DecodeJwtToken.GetUserRole(token);

            if (!result)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();                  
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProduct()
        {
            CollectionModel response = await _productService.GetProductsAsync();
            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProductAdmin(Guid? id)
        {
            bool response = await _productService.DeleteProductAsync(id);
            return RedirectToAction("DeleteProduct", "Admin");
        }


        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductAddRequestViewModel productAddRequestViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(productAddRequestViewModel);
            }

            bool response = await _productService.PostProductAsync(productAddRequestViewModel);

            if (!response)
            {
                return View(productAddRequestViewModel);
            }

            return RedirectToAction("AddProduct", "Admin");
        }

    }
}
