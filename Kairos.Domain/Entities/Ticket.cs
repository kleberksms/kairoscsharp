using System;
using System.Collections.Generic;

namespace Kairos.Domain.Entities
{
    public class Ticket
    {
        public Ticket()
        {
            SetDefaultValuesOnCreate();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? AuthorId { get; set; }

        public int? PriorityId { get; set; }

        public virtual Priority Priority { get; set; }

        public int? MeasureId { get; set; }

        public virtual Measure Measure { get; set; }

        public int? StatusId { get; set; }

        public virtual Status Status { get; set; }

        public int? ParentId { get; set; }

        public Ticket Parent { get; set; }

        public virtual IEnumerable<Issue> Issues { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }

        public bool IsClosed { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        private void SetDefaultValuesOnCreate()
        {

            if (!Id.Equals(0)) return;
            IsActive = true;
            IsClosed = false;
        }

        public bool IsMyTicket(Ticket ticket)
        {
            return true;
        }

    }
}
