using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeeSharpers.Models;

namespace SeeSharpers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Viewing> Viewings { get; set; }

        public DbSet<ViewingSeat> ViewingSeats { get; set; }

        public DbSet<Theatre> Theatres { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
        }
    }


}