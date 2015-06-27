using System.Data.Entity.ModelConfiguration;
using Kairos.Domain.Entities;

namespace Kairos.Infra.Data.EntityConfig
{
    public class TicketConfiguration : EntityTypeConfiguration<Ticket>
    {
        public TicketConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Description)
                .IsRequired()
                .HasColumnType("TEXT");

        }
    }
}
