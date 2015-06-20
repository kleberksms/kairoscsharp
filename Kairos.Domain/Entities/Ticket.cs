using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public int ParentId { get; set; }

        public int Priority { get; set; }

        public int MeasureId { get; set; }

        public int StatusId { get; set; }

        public virtual Measure Measure { get; set; }

        public virtual IEnumerable<Ticket> Children { get; set; }

        public virtual IEnumerable<Task> Tasks { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }

        public bool IsClosed { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

    }
}
