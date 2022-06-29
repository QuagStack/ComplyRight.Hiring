using System;
using System.Collections.Generic;

namespace ComplyRight.Hiring
{
    public partial class Sport
    {
        public Sport()
        {
            Leagues = new HashSet<League>();
        }

        public Guid SportId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<League> Leagues { get; set; }
    }
}
