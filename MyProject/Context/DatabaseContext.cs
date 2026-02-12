using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject.Model;

namespace MyProject.Context
{
    public class DatabaseContext : IdentityDbContext<Account>
    {
        private IWebHostEnvironment _environment;
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IWebHostEnvironment environment) : base(options)
        {
            _environment = environment;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            // store database in the folder structure for deployment
            var folder = Path.Combine(_environment.WebRootPath, "database");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            optionbuilder.UseSqlite($"Data Source={folder}/pokemon_blazor.db");
        }
    }
}
