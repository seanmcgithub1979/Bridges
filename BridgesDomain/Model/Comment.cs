using System;

namespace BridgesDomain.Model
{
    public class Comment
    {
        public Comment()
        {
            CommentDate = DateTime.Now;
        }

        public Comment(string commentContent, string from, string emailAddress)
        {
            CommentDate = DateTime.Now;
            CommentContent = commentContent;
            From = from;
            EmailAddress = emailAddress;
        }

        public int Id { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
        public string From { get; set; }
        public string EmailAddress { get; set; }
    }
}
