using System.Collections.Generic;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;
using BridgesService.Interfaces;

namespace BridgesService.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepo _repo;

        public CommentService(ICommentRepo repo)
        {
            _repo = repo;
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _repo.GetAllComments();
        }
        
        public void AddComment(string comment, string from, string emailAddress)
        {
            _repo.AddComment(new Comment(comment, from, emailAddress));
        }
    }
}