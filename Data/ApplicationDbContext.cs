using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reservator.Models;

namespace Reservator.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
      public DbSet<Reservation> Reservations { get; set; }
      public DbSet<Place> Places { get; set; }
      public DbSet<Restaurant> Restaurants { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}