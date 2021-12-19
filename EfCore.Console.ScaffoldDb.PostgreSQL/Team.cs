using System;
using System.Collections.Generic;

namespace EfCore.Console.ScaffoldDb.PostgreSQL
{
    public partial class Team
    {
        public Team()
        {
            MatchAwayTeams = new HashSet<Match>();
            MatchHomeTeams = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int LeagueId { get; set; }

        public virtual League League { get; set; } = null!;
        public virtual Coach? Coach { get; set; }
        public virtual ICollection<Match> MatchAwayTeams { get; set; }
        public virtual ICollection<Match> MatchHomeTeams { get; set; }
    }
}
