using EfCore.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Data.SqlServer.Configurations.Entities
{
    public class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.HasData(
                new Coach
                {
                    Id = 20,
                    Name = "Ivan Ivanov",
                    TeamId = 20
                },
                new Coach
                {
                    Id = 21,
                    Name = "Petar Petrov",
                    TeamId = 21
                },
                new Coach
                {
                    Id = 22,
                    Name = "Georgi Georgiev",
                    TeamId = 22
                });

            builder.Property(m => m.Name).HasMaxLength(80);
            builder.HasIndex(m => new { m.Name, m.TeamId }).IsUnique();
        }
    }
}
