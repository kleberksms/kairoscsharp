using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Domain.Services
{
    public class IssueService : BaseService<Issue>, IIssueService
    {
        private readonly IIssueRepository _issueRepository;

        public IssueService(IIssueRepository issueRepository) : base(issueRepository)
        {
            _issueRepository = issueRepository;
        }
    }
}
