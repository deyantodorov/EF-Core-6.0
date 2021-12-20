using EfCore.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Data.SqlServer.Configurations.Entities
{
    public class LeagueSeedConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
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
