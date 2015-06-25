using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class MeasureApplicationService : BaseApplicationService<Measure>, IMeasureRepository
    {
        private readonly IMeasureService _measureService;

        public MeasureApplicationService(IMeasureService measureService) : base(measureService)
        {
            _measureService = measureService;
        }
    }
}
