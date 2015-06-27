using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class PriorityApplicationService : BaseApplicationService<Priority>, IPriorityApplicationService
    {
        private readonly IPriorityService _priorityService;

        public PriorityApplicationService(IPriorityService priorityService)
            : base(priorityService)
        {
            _priorityService = priorityService;
        }
    }
}
