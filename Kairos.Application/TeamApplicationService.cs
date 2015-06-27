using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class TeamApplicationService : BaseApplicationService<Team>, ITeamApplicationService
    {
        private readonly ITeamService _teamService;

        public TeamApplicationService(ITeamService teamService) : base(teamService)
        {
            _teamService = teamService;
        }
    }
}
