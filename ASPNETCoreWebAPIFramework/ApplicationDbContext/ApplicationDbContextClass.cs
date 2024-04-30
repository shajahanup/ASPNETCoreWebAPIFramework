using ASPNETCoreWebAPIFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAPIFramework.ApplicationDbContext
{
    public class ApplicationDbContextClass : DbContext
    {

        public ApplicationDbContextClass(DbContextOptions<ApplicationDbContextClass> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasQueryFilter(item => !item.IsDeleted);
        }

        public DbSet<User> User {  get; set; }

    }
}
