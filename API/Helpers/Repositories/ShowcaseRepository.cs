using API.DbContext.Db;
using API.Models.DTO.Showcase;
using API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Helpers.Repositories
{
    public class ShowcaseRepository
    {
        private readonly ApplicationDbContext _db;

        public ShowcaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task <ShowcaseResponseDTO> GetShowcaseAsync()
        {
            ShowcaseEntity showcase = await _db.Showcases.OrderByDescending(s => s.Date).FirstAsync();
            if (showcase == null)
            {
                return null!;
            }

            ShowcaseResponseDTO response = showcase.ToShowcase();
            return response;
        }
    }
}
