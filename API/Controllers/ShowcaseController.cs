using API.Filters;
using API.Helpers.Repositories;
using API.Models.DTO.Showcase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]

    public class ShowcaseController : ControllerBase
    {
        private readonly ShowcaseRepository _showcaseRepository;

        public ShowcaseController(ShowcaseRepository showcaseRepository)
        {
            _showcaseRepository = showcaseRepository;
        }

        [HttpGet]
        public async Task <ActionResult<ShowcaseResponseDTO>> GetShowcase()
        {
            ShowcaseResponseDTO response = await _showcaseRepository.GetShowcaseAsync();
            return Ok(response);
        }
    }
}
