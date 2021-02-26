using System;

namespace BridgesDomain.Model
{
    public class Comment
    {
        public Comment()
        {
            CommentDate = DateTime.Now;
        }

        public Comment(string commentContent)
        {
            CommentDate = DateTime.Now;
            CommentContent = commentContent;
        }

        public int Id { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
    }
}
