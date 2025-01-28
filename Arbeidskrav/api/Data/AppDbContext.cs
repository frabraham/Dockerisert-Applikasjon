using Microsoft.EntityFrameworkCore;

namespace Arbeidskrav.api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Message> Messages { get; set; } // Tabellnavn
    }

    public class Message
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
