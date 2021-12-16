using EfCore.Domain;

using Microsoft.EntityFrameworkCore;

namespace EfCore.Data.SqlServer
{
    public class SqlServerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433; Database=FootballLeague; User Id=sa; Password=P@ssword123;");
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }
    }
}
