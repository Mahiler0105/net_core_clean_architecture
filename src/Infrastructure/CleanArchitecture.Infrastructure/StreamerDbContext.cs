using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
// using src/Core;

namespace CleanArchitecture.Infrastructure
{
    public class StreamerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;user id=postgres;password=leriet;database=postgres")
            .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
            .EnableSensitiveDataLogging();
        }

        public DbSet<Class1>? Streamers { get; set; }
        public DbSet<Video>? Videos { get; set; }
    }
}