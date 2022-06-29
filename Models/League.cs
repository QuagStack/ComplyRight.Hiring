using System;
using System.Collections.Generic;

namespace ComplyRight.Hiring
{
    public partial class League
    {
        public League()
        {
            Divisions = new HashSet<Division>();
            Teams = new HashSet<Team>();
        }

        public Guid LeagueId { get; set; }
        public string? Name { get; set; }
        public Guid? SportId { get; set; }

        public virtual Sport? Sport { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
