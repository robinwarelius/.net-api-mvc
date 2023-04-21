using API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.DbContext.Configurations
{
    public class ShowcaseConfiguration : IEntityTypeConfiguration<ShowcaseEntity>
    {
        public void Configure(EntityTypeBuilder<ShowcaseEntity> builder)
        {
            builder.HasData(
                new ShowcaseEntity()
                {
                    ShowcaseId = Guid.NewGuid(),
                    Title = "GET UP TO 40% OFF",
                    Ingress = "Don't Miss This Opportunity",
                    DeliveryText = "Online Shopping free home delivery over $100",
                    ButtonText = "SHOP NOW",
                    ImageUrl = "images/showcase-img.png",
                    Date = DateTime.Now.Date
                }
                );
        }
    }
}
