using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class SprintApplicationService : BaseApplicationService<Sprint>, ISprintApplicationService
    {
        private readonly ISprintService _sprintService;

        public SprintApplicationService(ISprintService sprintService) : base(sprintService)
        {
            _sprintService = sprintService;
        }
    }
}
