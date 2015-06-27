using System;

namespace Kairos.Domain.Entities
{
    public class Timesheet
    {
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TaskId { get; set; }

        public int TicketId { get; set; }

        public virtual Issue Issue { get; set; }

        public virtual Ticket Ticket { get; set; }

        public int Breaks { get; set; }

        public int SumIntervalTime { get; set; }

    }
}
