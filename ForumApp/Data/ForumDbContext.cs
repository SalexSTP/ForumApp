using ForumApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ForumApp.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext()
        {
        }

        public ForumDbContext(DbContextOptions<ForumDbContext> options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = config.GetConnectionString("DefaultConnection");

                optionsBuilder.UseSqlServer();
            }
        }
    }
}
