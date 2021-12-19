using EfCore.Domain.Common;

namespace EfCore.Domain
{
    public class Coach : BaseEntity
    {
        public string Name { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
