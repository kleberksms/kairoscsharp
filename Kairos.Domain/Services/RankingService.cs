using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Domain.Services
{
    public class RankingService : BaseService<Ranking>, IRankingService
    {
        private readonly IRankingRepository _rankingRepository;

        public RankingService(IRankingRepository rankingRepository) : base(rankingRepository)
        {
            _rankingRepository = rankingRepository;
        }
    }
}
