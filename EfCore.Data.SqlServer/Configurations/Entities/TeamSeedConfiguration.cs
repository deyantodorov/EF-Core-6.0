using EfCore.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Data.SqlServer.Configurations.Entities
{
    public class TeamSeedConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
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
