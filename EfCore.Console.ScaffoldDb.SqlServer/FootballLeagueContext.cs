using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EfCore.Console.ScaffoldDb.SqlServer
{
    public partial class FootballLeagueContext : DbContext
    {
        public FootballLeagueContext()
        {
        }

        public FootballLeagueContext(DbContextOptions<FootballLeagueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<League> Leagues { get; set; } = null!;
        public virtual DbSet<Match> Matches { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=127.0.0.1,1433; Database=FootballLeague; User Id=sa; Password=P@ssword123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>(entity =>
            {
                entity.HasIndex(e => e.AwayTeamId, "IX_Matches_AwayTeamId");

                entity.HasIndex(e => e.HomeTeamId, "IX_Matches_HomeTeamId");

                entity.HasOne(d => d.AwayTeam)
                    .WithMany(p => p.MatchAwayTeams)
                    .HasForeignKey(d => d.AwayTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.HomeTeam)
                    .WithMany(p => p.MatchHomeTeams)
                    .HasForeignKey(d => d.HomeTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasIndex(e => e.LeagueId, "IX_Teams_LeagueId");

                entity.HasOne(d => d.League)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.LeagueId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
