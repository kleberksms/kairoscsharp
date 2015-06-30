using System;

namespace Kairos.Domain.Entities
{
    public class Comment
    {
        public int  Id { get; set; }

        public string Text { get; set; }

        public int? AuthorId { get; set; }

        public int? SolverId { get; set; }

        public int? TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }

        public int? IssueId { get; set; }

        public virtual Issue Issue { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }
    }
}
