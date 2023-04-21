using API.DbContext.Db;
using API.Models.DTO.Contact;
using API.Models.Entities;

namespace API.Helpers.Repositories
{
    public class ContactRepository
    {
        private readonly ApplicationDbContext _db;

        public ContactRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task <bool> PostContactAsync(ContactAddRequestDTO request)
        {
            if (request == null)
            {
                return false;
            }

            ContactEntity contact = new ContactEntity()
            {
                ContactId = Guid.NewGuid(),
                FullName = request.Name,
                Email = request.Email,
                Comment = request.Comment,
            };

            await _db.Contacts.AddAsync(contact);
            await _db.SaveChangesAsync();  
            return true;

        }
               
    }
}
