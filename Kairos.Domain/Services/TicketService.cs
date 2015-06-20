using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Domain.Services
{
    public class TicketService : BaseService<Ticket>, ITicketService
    {
        private ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository) : base(ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
    }
}
