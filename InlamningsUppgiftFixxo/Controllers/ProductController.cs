

using InlamningsUppgiftFixxo.Models;
using InlamningsUppgiftFixxo.Repositories;
using InlamningsUppgiftFixxo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace InlamningsUppgiftFixxo.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductService _productRepository;

        public ProductController(ProductService productRepository)
        {
            _productRepository = productRepository;
        }

        // GET PRODUCTS
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            CollectionModel response = await _productRepository.GetProductsAsync();
            return View(response);
        }

       
        //GET PRODUCT
       [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(Guid? id)
        {
            CollectionModel response = await _productRepository.GetProductAsync(id);
            return View(response);
        }


        // GET SORTED PRODUCTS
        [HttpGet]
        public async Task<IActionResult> GetSortedProducts(string? category)
        {
            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            CollectionModel collection = await _productRepository.GetSortedProductsAsync(category);

            if (collection == null)
            {
                return RedirectToAction("Index", "Home");
            }
          
            ViewBag.Category = category;    
            
            return View(collection);
        }
                  
    }
}
