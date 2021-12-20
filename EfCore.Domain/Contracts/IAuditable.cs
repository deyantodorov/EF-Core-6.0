using System;

namespace EfCore.Domain.Contracts
{
    public interface IAuditable
    {
        DateTime Created { get; set; }

        string? CreatedBy { get; set; }

        DateTime? Updated { get; set; }

        string? UpdatedBy { get; set; }

        Guid Uuid { get; set; }
    }
}
