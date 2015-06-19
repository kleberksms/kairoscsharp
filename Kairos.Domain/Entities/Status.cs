using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Domain.Entities
{
    public class Status
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
