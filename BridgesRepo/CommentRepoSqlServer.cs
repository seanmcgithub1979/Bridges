using System;
using System.Collections.Generic;
using BridgesDomain.Model;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class CommentRepoSqlServer : ICommentRepo
    {
        private readonly BridgesDbContext _context;

        public CommentRepoSqlServer(BridgesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _context.Comments;
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}