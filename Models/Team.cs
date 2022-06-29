using System;
using System.Collections.Generic;

namespace ComplyRight.Hiring
{
    public partial class Team
    {
        public Guid TeamId { get; set; }
        public string Name { get; set; } = null!;
        public string? City { get; set; }
        public string? State { get; set; }
        public Guid? DivisionId { get; set; }
        public Guid LeagueId { get; set; }

        public virtual Division? Division { get; set; }
        public virtual League League { get; set; } = null!;
    }
}
