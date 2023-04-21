using InlamningsUppgiftFixxo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace InlamningsUppgiftFixxo.Repositories
{
    public class ShowcaseService
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
       

        public ShowcaseService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public async Task<ShowcaseModel> GetShowcaseAsync()
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            var showcase = await httpClient.GetFromJsonAsync<ShowcaseModel>($"https://localhost:7160/api/Showcase");
            return showcase;
        }
    }
}

