using System;
using System.Collections.Generic;
using BridgesDomain.Model;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class CommentRepoSqlServer : ICommentRepo
    {
        private readonly BridgesDbContext context;

        public CommentRepoSqlServer(BridgesDbContext context)
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