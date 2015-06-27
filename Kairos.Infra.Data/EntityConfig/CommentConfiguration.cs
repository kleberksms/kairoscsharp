using System.Data.Entity.ModelConfiguration;
using Kairos.Domain.Entities;

namespace Kairos.Infra.Data.EntityConfig
{
    public class CommentConfiguration : EntityTypeConfiguration<Comment>
    {
        public CommentConfiguration()
        {
            
        }
    }
}
