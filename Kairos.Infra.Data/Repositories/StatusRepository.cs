using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;

namespace Kairos.Infra.Data.Repositories
{
    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
    }
}
