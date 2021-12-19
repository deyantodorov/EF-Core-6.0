using System.Collections.Generic;

using EfCore.Domain.Common;

namespace EfCore.Domain
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }

        public int LeagueId { get; set; }

        public virtual League League { get; set; }

        public virtual List<Match> HomeMatches { get; set; }

        public virtual List<Match> AwayMatches { get; set; }
    }
}
