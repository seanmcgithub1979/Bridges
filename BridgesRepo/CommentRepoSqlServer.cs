using System.Collections.Generic;
using BridgesDomain.Model;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class CommentRepoSqlServer : ICommentRepo
    {
        private readonly CommentsDbContext context;

        public CommentRepoSqlServer(CommentsDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return context.Comments;
        }

        public void AddComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
        }
    }
}