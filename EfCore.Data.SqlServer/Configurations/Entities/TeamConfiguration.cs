using EfCore.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Data.SqlServer.Configurations.Entities
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasMany(m => m.HomeMatches)
                .WithOne(m => m.HomeTeam)
                .HasForeignKey(m => m.HomeTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(m => m.AwayMatches)
                .WithOne(m => m.AwayTeam)
                .HasForeignKey(m => m.AwayTeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.Name).HasMaxLength(80);
            builder.HasIndex(m => m.Name).IsUnique();

            builder.HasData(
                new Team
                {
                    Id = 20,
                    Name = "Ivan Team",
                    LeagueId = 20
                },
                new Team
                {
                    Id = 21,
                    Name = "Petar Team",
                    LeagueId = 21
                },
                new Team
                {
                    Id = 22,
                    Name = "Georgi Team",
                    LeagueId = 22
                });
        }
    }
}
