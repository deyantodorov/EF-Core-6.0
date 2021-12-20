using System;

using EfCore.Domain.Contracts;

namespace EfCore.Domain
{
    public abstract class BaseEntity<T> : IAuditable
    {
        public T Id { get; set; }

        public DateTime Created { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? Updated { get; set; }

        public string? UpdatedBy { get; set; }

        public Guid Uuid { get; set; }
    }
}
