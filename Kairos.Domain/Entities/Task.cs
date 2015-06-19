using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
