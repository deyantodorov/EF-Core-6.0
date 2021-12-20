using System;
using System.Threading.Tasks;

using EfCore.Domain.Contracts;

using Microsoft.EntityFrameworkCore;

namespace EfCore.Data.PostgreSQL
{
    public abstract class AuditablePostgreSqlDbContext : DbContext
    {
        public async Task<int> SaveChangesAsync(string username)
        {
            foreach (var entry in ChangeTracker.Entries<IAuditable>())
            {
                entry.Entity.Updated = DateTime.UtcNow;
                entry.Entity.UpdatedBy = username;

                if (entry.State != EntityState.Added)
                {
                    continue;
                }

                entry.Entity.Created = DateTime.UtcNow;
                entry.Entity.CreatedBy = username;
                entry.Entity.Uuid = Guid.NewGuid();
            }

            return await base.SaveChangesAsync();
        }
    }
}
