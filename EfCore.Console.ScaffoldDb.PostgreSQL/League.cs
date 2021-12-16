﻿using System;
using System.Collections.Generic;

namespace EfCore.Console.ScaffoldDb.PostgreSQL
{
    public partial class League
    {
        public League()
        {
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Team> Teams { get; set; }
    }
}
