using System.Collections.Generic;

namespace EfCore.Domain
{
    public class League : BaseEntity
    {
        public string Name { get; set; }

        public List<Team> Teams { get; set; }
    }
}
