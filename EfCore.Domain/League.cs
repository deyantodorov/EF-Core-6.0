using System.Collections.Generic;

namespace EfCore.Domain
{
    public class League : BaseEntity<int>
    {
        public string Name { get; set; }

        public List<Team> Teams { get; set; }
    }
}
