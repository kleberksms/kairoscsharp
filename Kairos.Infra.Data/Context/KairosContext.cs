using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Domain.Entities;

namespace Kairos.Infra.Data.Context
{
    public class KairosContext : DbContext
    {
        public KairosContext() : base("kairos"){}

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Measure> Measures { get; set; }

        public DbSet<Ranking> Rankings { get; set; }

        public DbSet<Sprint> Sprints { get; set; }

        public DbSet<Status> Status { get; set; }

        //public DbSet<Task> Tasks { get; set; }        

        public DbSet<Team> Teams { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Timesheet> Timesheet { get; set; }

    }
}
