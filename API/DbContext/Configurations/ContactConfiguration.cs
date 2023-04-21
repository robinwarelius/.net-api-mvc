using API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.DbContext.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<ContactEntity>
    {
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            builder.HasData(

                new ContactEntity()
                {
                    ContactId = Guid.NewGuid(),
                    FullName = "Jajja Stahl Warelius",
                    Email = "jajja@example.com",
                    Comment = "Hello Comment Here"
                },
                new ContactEntity()
                {
                    ContactId = Guid.NewGuid(),
                    FullName = "Viktor Warelius",
                    Email = "viktor@example.com",
                    Comment = "WASSUP comment"
                }

                );
        }
    }
}
