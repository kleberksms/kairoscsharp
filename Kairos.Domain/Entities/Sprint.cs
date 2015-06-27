using System;

namespace Kairos.Domain.Entities
{
    public class Sprint
    {
        public int Id { get; set; }

        public int Interval { get; set; }

        public DateTime StartExpected { get; set; }

        public DateTime Finish { get; set; }

        //public virtual IEnumerable<Ticket> Tickets { get; set; }

        //public virtual IEnumerable<Comment> Comments { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

    }
}
