using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class RankingApplicationService : BaseApplicationService<Ranking>, IRankingApplicationService
    {
        private readonly IRankingService _rankingService;

        public RankingApplicationService(IRankingService rankingService) : base(rankingService)
        {
            _rankingService = rankingService;
        }
    }
}
