using System.Collections.Generic;

namespace EfCore.Domain
{
    public class Team : BaseEntity<int>
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public virtual League League { get; set; }

        public virtual Coach Coach { get; set; }

        public virtual List<Match> HomeMatches { get; set; }

        public virtual List<Match> AwayMatches { get; set; }
    }
}
