
using InlamningsUppgiftFixxo.Controllers;
using InlamningsUppgiftFixxo.Models;
using InlamningsUppgiftFixxo.ViewModels;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace InlamningsUppgiftFixxo.Repositories
{
    public class ProductService
    {
        
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductService(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET PRODUCT:S
        public async Task <CollectionModel> GetProductsAsync()
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            List<ProductModel>? response = await httpClient.GetFromJsonAsync<List<ProductModel>>("https://localhost:7160/api/Product");

            CollectionModel collection = new CollectionModel()
            {
                Title = "Products",
                CollectionItemModel = response
            };

            return collection;
        }

        // GET PRODUCT
        public async Task <CollectionModel> GetProductAsync (Guid? id)
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            ProductModel? response = await httpClient.GetFromJsonAsync<ProductModel>($"https://localhost:7160/api/Product/{id}");

            CollectionModel collection = new CollectionModel()
            {
                Title = "Detail View",
                CollectionItemModel = new List<ProductModel>
                {
                    response
                }
            };

            return collection;
        }

        //GET SORTED PRODUCTS
        public async Task<CollectionModel> GetSortedProductsAsync(string? category)
        {
            if (category == null)
            {
                return null;
            }

            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            List<ProductModel>? response = await httpClient.GetFromJsonAsync<List<ProductModel>>($"https://localhost:7160/api/Product/GetSortedProducts/{category}");

            if (response == null)
            {
                return null;
            }

            CollectionModel collection = new CollectionModel()
            {              
                CollectionItemModel = response
            };

            return collection;

        }

        // POST 
        public async Task <bool> PostProductAsync(ProductAddRequestViewModel addRequest)
        {
            if (addRequest == null)
            {
                return false!;
            }

            var httpClient = _httpClientFactory.CreateClient();
            var token = _httpContextAccessor.HttpContext.Request.Cookies["accessToken"];
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            var response = await httpClient.PostAsJsonAsync($"https://localhost:7160/api/Product/", addRequest);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            return true;         
        }

        // DELETE

        public async Task <bool> DeleteProductAsync(Guid? id)
        {
            if (id == null)
            {
                return false;
            }

            CollectionModel collection = await GetProductAsync(id);

            if(collection == null)
            {
                return false;
            }

            var httpClient = _httpClientFactory.CreateClient();
            var token = _httpContextAccessor.HttpContext.Request.Cookies["accessToken"];          
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));

            var response = await httpClient.DeleteAsync($"https://localhost:7160/api/Product/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            return true;


        }
    }
}
