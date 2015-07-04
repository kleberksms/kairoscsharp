using AutoMapper;
using Kairos.Domain.Entities;
using Kairos.MVC.ViewModels;

namespace Kairos.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Comment, CommentViewModel>();
            Mapper.CreateMap<Issue, IssueViewModel>();
            Mapper.CreateMap<Measure, MeasureViewModel>();
            Mapper.CreateMap<Priority, PriorityViewModel>();
            Mapper.CreateMap<Ranking, RankingViewModel>();
            Mapper.CreateMap<Sprint, SprintViewModel>();
            Mapper.CreateMap<Status, StatusViewModel>();
            Mapper.CreateMap<Team, TeamViewModel>();
            Mapper.CreateMap<Ticket, TicketViewModel>();
            Mapper.CreateMap<Timesheet, TimesheetViewModel>();
        }
    }
}