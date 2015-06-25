using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class StatusApplicationService : BaseApplicationService<Status>, IStatusRepository
    {
        private readonly IStatusService _statusService;

        public StatusApplicationService(IStatusService statusService) : base(statusService)
        {
            _statusService = statusService;
        }
    }
}
