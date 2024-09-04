using Microsoft.EntityFrameworkCore;
using Qinshift.Movies.DomainModels;

namespace Qinshift.Movies.DataAccess
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PopulateDb.Seed(modelBuilder); 
        }
    }
}
