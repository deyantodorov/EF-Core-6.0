using EfCore.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Data.SqlServer.Configurations.Entities
{
    public class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.Property(m => m.Name).HasMaxLength(80);
            builder.HasIndex(m => m.Name).IsUnique();

            builder.HasData(
                new League
                {
                    Id = 20,
                    Name = "Ivan League"
                },
                new League
                {
                    Id = 21,
                    Name = "Petar League"
                },
                new League
                {
                    Id = 22,
                    Name = "Georgi League"
                });
        }
    }
}
