using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class TimesheetApplicationService : BaseApplicationService<Timesheet>, ITimesheetApplicationService
    {
        private readonly ITimesheetService _timesheetService;

        public TimesheetApplicationService(ITimesheetService timesheetService) : base(timesheetService)
        {
            _timesheetService = timesheetService;
        }
    }
}
