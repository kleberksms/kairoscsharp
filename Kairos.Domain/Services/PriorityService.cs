using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Domain.Services
{
    public class PriorityService : BaseService<Priority>, IPriorityService
    {
        private readonly IPriorityRepository _priorityRepository;

        public PriorityService(IPriorityRepository priorityRepository)
            : base(priorityRepository)
        {
            _priorityRepository = priorityRepository;
        }
    }
}
