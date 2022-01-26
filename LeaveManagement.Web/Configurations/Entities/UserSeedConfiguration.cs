using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "31d27d23-41a5-4269-aerc-07d5e2a5d4b6",
                    Email = "captainamericanwhoknowty@gmail.com",
                    NormalizedEmail = "Haioliver993@gmail.com",
                    FirstName = "System-Oliver",
                    LastName = "Make Admin",
                    PasswordHash = hasher.HashPassword(null, "$$password")
                },
                new Employee
                {
                    Id = "c2bf25e7-5e59-431d-b1ty-a7a4dd3cae8d",
                    Email = "captainamericanwhoknow12iutjytj@gmail.com",
                    NormalizedEmail = "captainamericanwhoknow12@gmail.com",
                    FirstName = "captainamericanwhoknow12@gmail.com",
                    LastName = "captainamericanwhoknow12@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "$$passsword")
                }
                );
        }
    }
}