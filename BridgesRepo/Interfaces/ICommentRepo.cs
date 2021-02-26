using System.Collections.Generic;
using BridgesDomain.Model;

namespace BridgesRepo.Interfaces
{
    public interface ICommentRepo
    {
        IEnumerable<Comment> GetAllComments();
        
        void AddComment(Comment comment);
    }
}