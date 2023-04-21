using API.Filters;
using API.Helpers;
using API.Models.DTO.Account;
using API.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser(RegisterUserRequestDTO registerUserRequestDTO)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList());
                return BadRequest(errorMessage);
            }

            ApplicationUser applicationUser = registerUserRequestDTO;

            // Finns användaren?
            if (await _userManager.Users.AnyAsync(user => user.Email == registerUserRequestDTO.Email))
            {
                return Conflict();
            }

            // Skapa användare
            IdentityResult result = await _userManager.CreateAsync(applicationUser, registerUserRequestDTO.Password);

            // Ge användare roll
            if (result.Succeeded)
            {
                var adminAmount = await _userManager.GetUsersInRoleAsync("Admin");

                if (adminAmount.Count == 0)
                {
                    await _userManager.AddToRoleAsync(applicationUser, "Admin");
                }
                else
                {
                    await _userManager.AddToRoleAsync(applicationUser, "ProductManager");
                }
              
                return NoContent();

            }

            return BadRequest();
        }


        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginUser(LoginUserRequestDTO loginUserRequestDTO)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList());
                return BadRequest(errorMessage);
            }

            var applicationUser = await _userManager.Users.FirstOrDefaultAsync(temp => temp.Email == loginUserRequestDTO.Email);

            if (applicationUser != null) 
            {
                var result = await _signInManager.CheckPasswordSignInAsync(applicationUser, loginUserRequestDTO.Password, false);

                if (result.Succeeded)
                {
                    var role = await _userManager.GetRolesAsync(applicationUser);
                    var claimsIdentity = new ClaimsIdentity(new Claim[]
                    {
                    new Claim("id", applicationUser.Id.ToString()),
                    new Claim(ClaimTypes.Name, applicationUser.Email!),
                    new Claim(ClaimTypes.Role, role[0])
                    });

                    return TokenCreator.Generate(claimsIdentity, DateTime.Now.AddHours(1));
                }
            }
                
            return BadRequest();
        }

    }
}



