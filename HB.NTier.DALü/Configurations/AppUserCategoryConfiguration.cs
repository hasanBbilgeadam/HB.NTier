using HB.NTier.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HB.NTier.DAL.Configurations
{
    public class AppUserCategoryConfiguration : IEntityTypeConfiguration<AppUserCategory>
    {
        public void Configure(EntityTypeBuilder<AppUserCategory> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x=>x.AppUserCategoryName).IsRequired();    

        }
    }
}
