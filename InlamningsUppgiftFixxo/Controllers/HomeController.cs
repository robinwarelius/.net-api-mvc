using InlamningsUppgiftFixxo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using InlamningsUppgiftFixxo.ViewModels;
using InlamningsUppgiftFixxo.Repositories;

namespace InlamningsUppgiftFixxo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;           
        private readonly ShowcaseService _showcaseService;

        public HomeController(ProductService productService, ShowcaseService showcaseService)
        {
            _productService = productService;
            _showcaseService = showcaseService;
        }

        public async Task <IActionResult> Index()
        {
            CollectionModel featuredProducts = await _productService.GetSortedProductsAsync("featured");
            featuredProducts.Title = "Featured Products";
            CollectionModel newProducts = await _productService.GetSortedProductsAsync("new");
            newProducts.Title = "New Products";
            CollectionModel popularProducts = await _productService.GetSortedProductsAsync("popular");
            popularProducts.Title = "Popular Products";

            ShowcaseModel showcase = await _showcaseService.GetShowcaseAsync();      
            IndexViewModel viewModel = new IndexViewModel()
            {
                ShowcaseModel = showcase,
                CollectionModel = new List<CollectionModel>() 
                {                   
                    featuredProducts,
                    newProducts,
                    popularProducts
                }
            };
                                                                            
            return View(viewModel);

        }
    }
}
