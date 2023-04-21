using API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.DbContext.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.HasData(

                new CategoryEntity()
                {
                    CategoryId = Guid.Parse("97C46E14-E748-4582-AE15-60CC95BDF6B0"),
                    CategoryName = "Featured",
                },
                new CategoryEntity()
                {
                    CategoryId = Guid.Parse("E9506723-CC8E-42A8-94B2-C3B168FE1CAE"),
                    CategoryName = "Popular",
                },
                new CategoryEntity()
                {
                    CategoryId = Guid.Parse("B670C668-DBAE-4A24-B73E-20FF0868A41A"),
                    CategoryName = "New",
                }

                );


            
        }
    }
}
