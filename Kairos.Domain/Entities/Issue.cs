using System;
using System.Collections.Generic;

namespace Kairos.Domain.Entities
{
    public class Issue
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public int? TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
