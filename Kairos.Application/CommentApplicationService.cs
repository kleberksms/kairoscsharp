using Kairos.Domain.Entities;
using Kairos.Domain.Interfaces.Repositories;
using Kairos.Domain.Interfaces.Services;

namespace Kairos.Application
{
    public class CommentApplicationService : BaseApplicationService<Comment>, ICommentRepository
    {
        private readonly ICommentService _commentService;

        public CommentApplicationService(ICommentService commentService) : base(commentService)
        {
            _commentService = commentService;
        }
    }
}
