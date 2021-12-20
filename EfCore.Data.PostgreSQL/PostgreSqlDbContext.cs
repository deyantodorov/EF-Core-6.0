using System;

using EfCore.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfCore.Data.PostgreSQL
{
    public class PostgreSqlDbContext : AuditablePostgreSqlDbContext
    {
        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Coach> Coaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Username=postgres;Password=secretpassword;Host=127.0.0.1;Port=5432;Database=FootballLeague;Pooling=true;")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasMany(m => m.HomeMatches)
                .WithOne(m => m.HomeTeam)
                .HasForeignKey(m => m.HomeTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>()
                .HasMany(m => m.AwayMatches)
                .WithOne(m => m.AwayTeam)
                .HasForeignKey(m => m.AwayTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>().Property(m => m.Name).HasMaxLength(80);
            modelBuilder.Entity<Team>().HasIndex(m => m.Name).IsUnique();

            modelBuilder.Entity<League>().Property(m => m.Name).HasMaxLength(80);
            modelBuilder.Entity<League>().HasIndex(m => m.Name).IsUnique();

            modelBuilder.Entity<Coach>().Property(m => m.Name).HasMaxLength(80);
            modelBuilder.Entity<Coach>().HasIndex(m => new { m.Name, m.TeamId }).IsUnique();

            modelBuilder.Entity<TeamsCoachesLeaguesView>().HasNoKey().ToView(nameof(TeamsCoachesLeaguesView));
        }
    }
}
