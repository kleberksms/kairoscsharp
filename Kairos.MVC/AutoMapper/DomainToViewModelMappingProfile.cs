using AutoMapper;
using Kairos.Domain.Entities;
using Kairos.MVC.ViewModels;

namespace Kairos.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CommentViewModel, Comment>();
            Mapper.CreateMap<IssueViewModel, Issue>();
            Mapper.CreateMap<MeasureViewModel, Measure>();
            Mapper.CreateMap<RankingViewModel, Ranking>();
            Mapper.CreateMap<SprintViewModel, Sprint>();
            Mapper.CreateMap<StatusViewModel, Status>();
            Mapper.CreateMap<TeamViewModel, Team>();
            Mapper.CreateMap<TicketViewModel, Ticket>();
            Mapper.CreateMap<TimesheetViewModel, Timesheet>();
        }

    }
}