﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Kairos.Domain.Entities;
using Kairos.Infra.Data.EntityConfig;

namespace Kairos.Infra.Data.Context
{
    public class KairosContext : DbContext
    {
        public KairosContext() : base("Kairos"){}

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Measure> Measures { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<Ranking> Rankings { get; set; }

        public DbSet<Sprint> Sprints { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Issue> Issues { get; set; }        

        public DbSet<Team> Teams { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Timesheet> Timesheet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id"))
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(75));

            modelBuilder.Configurations.Add(new TicketConfiguration());

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Created") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Created").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Created").IsModified = false;
                }

            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Modified") != null))
            {
                entry.Property("Modified").CurrentValue = DateTime.Now;
            }


            return base.SaveChanges();
        }
    }
}
