using System;
using System.Collections.Generic;

namespace ComplyRight.Hiring
{
    public partial class Division
    {
        public Division()
        {
            Teams = new HashSet<Team>();
        }

        public Guid DivisionId { get; set; }
        public string? Name { get; set; }
        public Guid? LeagueId { get; set; }

        public virtual League? League { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
