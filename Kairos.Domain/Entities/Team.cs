using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Domain.Entities
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Devera ter uma lista de users tipo time scrum - composta pelo PO, SM e TD

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
