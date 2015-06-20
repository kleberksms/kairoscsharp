using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Domain.Services
{
    public class TimesheetService : BaseService<Timesheet>, ITimesheetService
    {
        private readonly ITimesheetRepository _timesheetRepository;

        public TimesheetService(ITimesheetRepository timesheetRepository) : base(timesheetRepository)
        {
            _timesheetRepository = timesheetRepository;
        }
    }
}
