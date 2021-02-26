using System.Collections.Generic;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;
using BridgesService.Interfaces;

namespace BridgesService.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepo repo;

        public CommentService(ICommentRepo repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return repo.GetAllComments();
        }

        public void AddComment(string comment)
        {
            repo.AddComment(new Comment(comment));
        }
    }
}