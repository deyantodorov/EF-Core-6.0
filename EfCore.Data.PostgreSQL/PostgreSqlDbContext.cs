using EfCore.Domain;

using Microsoft.EntityFrameworkCore;

namespace EfCore.Data.PostgreSQL
{
    public class PostgreSqlDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Username=postgres;Password=secretpassword;Host=127.0.0.1;Port=5432;Database=FootballLeague;Pooling=true;");
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }
    }
}
