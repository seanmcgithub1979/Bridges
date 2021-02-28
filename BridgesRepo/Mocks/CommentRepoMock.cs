using System.Collections.Generic;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace BridgesRepo.Mocks
{
    public class CommentRepoMock : ICommentRepo
    {
        public IEnumerable<Comment> GetAllComments()
        {
            IList<Comment> comments = new List<Comment>();
            for (var i = 0; i < 20; i++)
            {
                comments.Add(new Comment($"Comment: {i + 1}", "from ...", "emailAddress..."));
            }

            return comments;
        }

        public void AddComment(Comment comment)
        {
        }
    }
}