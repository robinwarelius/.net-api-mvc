using InlamningsUppgiftFixxo.ViewModels;
using Microsoft.Extensions.Configuration;

namespace InlamningsUppgiftFixxo.Repositories
{
    public class AccountService
    {
        public IHttpClientFactory _httpClientFactory { get; set; }
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public AccountService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public async Task<bool> LoginUserAsync(LoginUserViewModel loginModel)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            var result = await httpClient.PostAsJsonAsync("https://localhost:7160/api/Account/login", loginModel);
            var token = await result.Content.ReadAsStringAsync();
            
            _httpContextAccessor.HttpContext.Response.Cookies.Append("accessToken", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = DateTime.Now.AddDays(1)
            });

            if (!result.IsSuccessStatusCode)
            {
                return false;
            }

            return true;

        }

        public async Task<bool> RegisterUserAsync(RegisterUserViewModel registerModel)
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", _configuration.GetValue<string>("ApiKey"));
            var response = await httpClient.PostAsJsonAsync($"https://localhost:7160/api/Account/register", registerModel);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            return true;

        }
    }
}
