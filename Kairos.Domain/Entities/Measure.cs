using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Domain.Entities
{
    public class Measure
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public decimal Value { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

    }
}
