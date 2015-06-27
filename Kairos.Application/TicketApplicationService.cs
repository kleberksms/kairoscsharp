using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class TicketApplicationService : BaseApplicationService<Ticket>, ITicketApplicationService
    {
        private readonly ITicketService _ticketService;

        public TicketApplicationService(ITicketService ticketService) : base(ticketService)
        {
            _ticketService = ticketService;
        }
    }
}
