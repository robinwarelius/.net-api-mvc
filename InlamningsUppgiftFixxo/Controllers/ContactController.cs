using InlamningsUppgiftFixxo.Repositories;
using InlamningsUppgiftFixxo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InlamningsUppgiftFixxo.Controllers
{
    public class ContactController : Controller
    {
        

        private readonly ContactService _contactService;

        public ContactController(ContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task <IActionResult> Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Contact(ContactViewModel registerContactViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerContactViewModel);
                
            }

            bool response = await _contactService.PostContactAsync(registerContactViewModel);

            if (!response)
            {
                return View(registerContactViewModel);
                
            }

            ViewBag.Register = "Registration Succeded";
         
            return View();
        }
    }
}
