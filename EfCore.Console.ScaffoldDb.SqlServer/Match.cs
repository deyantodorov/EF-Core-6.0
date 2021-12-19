using System;
using System.Collections.Generic;

namespace EfCore.Console.ScaffoldDb.SqlServer
{
    public partial class Match
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime Date { get; set; }

        public virtual Team AwayTeam { get; set; } = null!;
        public virtual Team HomeTeam { get; set; } = null!;
    }
}
