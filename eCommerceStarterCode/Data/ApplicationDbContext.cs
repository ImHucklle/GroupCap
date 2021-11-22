using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        //public ApplicationDbContext()
        //{

        //}

        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
        //public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<Books> Books { get; set; }

        //public DbSet<Role> Role { get; set; }
        //public DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShoppingCart>()
                .HasKey(sc => new { sc.UserId, sc.BookId });

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}
