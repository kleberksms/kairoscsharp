using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;

namespace Kairos.Infra.Data.Repositories
{
    public class IssueRepository : BaseRepository<Issue>, IIssueRepository
    {
    }
}
