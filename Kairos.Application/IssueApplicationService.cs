using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class IssueApplicationService : BaseApplicationService<Issue>, IIssueApplicationService
    {
        private readonly IIssueService _issueService;

        public IssueApplicationService(IIssueService issueService) : base(issueService)
        {
            _issueService = issueService;
        }
    }
}
