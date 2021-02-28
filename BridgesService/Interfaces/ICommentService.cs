using System.Collections.Generic;
using BridgesDomain.Model;

namespace BridgesService.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetAllComments();
        
        void AddComment(string comment, string from, string emailAddress);
    }
}