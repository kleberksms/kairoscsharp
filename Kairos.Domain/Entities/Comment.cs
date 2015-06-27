using System;

namespace Kairos.Domain.Entities
{
    public class Comment
    {
        public int  Id { get; set; }

        public string Text { get; set; }

        public int AuthorId { get; set; }

        public int SolverId { get; set; }

        public int  Type { get; set; } //se vai ser um comentario do tipo Sprint, Task ou Ticket

        public int TypeId { get; set; }//Id do typo

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }
    }
}
