using System;
using System.Collections.Generic;

namespace EfCore.Console.ScaffoldDb.PostgreSQL
{
    public partial class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? TeamId { get; set; }

        public virtual Team? Team { get; set; }
    }
}
