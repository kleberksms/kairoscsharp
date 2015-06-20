using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Domain.Services
{
    public class MeasureService : BaseService<Measure>, IMeasureService
    {

        private readonly IMeasureRepository _measureRepository;

        public MeasureService(IMeasureRepository measureRepository) : base(measureRepository)
        {
            _measureRepository = measureRepository;
        }
    }
}
