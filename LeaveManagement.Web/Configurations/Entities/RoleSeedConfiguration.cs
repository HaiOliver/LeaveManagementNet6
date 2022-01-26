using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ca85b558-1975-90d9-bb79-9ea5a406587c",
                    Name = "OliverAdministrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "c0bf25e7-5e59-431d-b1f1-a7a4dd3cae8d",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }
    }
}