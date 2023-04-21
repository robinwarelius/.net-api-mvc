using API.Filters;
using API.Helpers.Repositories;
using API.Models.DTO.Contact;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class ContactsController : ControllerBase
    {
        private readonly ContactRepository _contactRepository;

        public ContactsController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpPost]
        public async Task <ActionResult<bool>> PostContactAsync(ContactAddRequestDTO requestDTO)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = string.Join(" | ", ModelState.Values.SelectMany(temp => temp.Errors).Select(e => e.ErrorMessage).ToList());
                return Problem(errorMessage);
            }

            bool response = await _contactRepository.PostContactAsync(requestDTO);

            if (!response)
            {
                return NotFound();
            }

            return Ok(response);

        }

    }
}
