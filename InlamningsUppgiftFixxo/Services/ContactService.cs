using InlamningsUppgiftFixxo.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace InlamningsUppgiftFixxo.Repositories
{
    public class ContactService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public ContactService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public async Task <bool> PostContactAsync(ContactViewModel contact)
        {
            if (contact == null)
            {
                return false;
            }

            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            var response = await httpClient.PostAsJsonAsync($"https://localhost:7160/api/Contacts/", contact);

            if(!response.IsSuccessStatusCode) 
            {
                return false;
            }

            return true;
        }
    }
}
