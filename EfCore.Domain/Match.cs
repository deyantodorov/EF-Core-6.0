using System;

namespace EfCore.Domain
{
    public class Match : BaseEntity<int>
    {
        public int HomeTeamId { get; set; }

        public virtual Team HomeTeam { get; set; }

        public int AwayTeamId { get; set; }

        public virtual Team AwayTeam { get; set; }

        public DateTime Date { get; set; }
    }
}
