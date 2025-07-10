namespace BridgesRepo.Interfaces;

public interface ICommentRepo
{
    IEnumerable<Comment> GetAllComments();
        
    void AddComment(Comment comment);
}