namespace Conference.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public int SessionID { get; set; }
        public virtual Session Session { get; set; }

    }
}