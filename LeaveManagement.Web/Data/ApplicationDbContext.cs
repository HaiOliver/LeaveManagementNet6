using LeaveManagement.Web.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Data
{

// ! point to Employee entity
public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        // ! add role for user
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // add role
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            // add user
            builder.ApplyConfiguration(new UserSeedConfiguration());
            //// add user
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        // add Employees table  -> DB

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}