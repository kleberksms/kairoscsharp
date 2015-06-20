using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Domain.Services
{
    public class SprintService : BaseService<Sprint>, ISprintService
    {
        private readonly ISprintRepository _sprintRepository;

        public SprintService(ISprintRepository sprintRepository) : base(sprintRepository)
        {
            _sprintRepository = sprintRepository;
        }
    }
}
