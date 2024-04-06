namespace Domain.Models;

/// <summary>
/// Model biznesowy i bazodanowy komentarza.
/// </summary>
public class Comment
{
    private readonly List<User> _likedBy = new List<User>(); // lista osób, które polubiły komentarz 

    public int CommentId { get; }
    public int TaskId { get; }
    public string Text { get; private set; }
    public User CreatedBy { get; } // pomocne w nawigacji między komentarzem i użytkownikiem
    public DateTime CreatedAt { get; }
    public User? ModifiedBy { get; } // pomocne w nawigacji między komentarzem i użytkownikiem
    public DateTime? ModifiedAt { get; }
    public int Likes => _likedBy.Count;

    public Comment(int commentId, int taskId, string text,
        User createdBy, DateTime createdAt,
        User modifiedBy, DateTime? modifiedAt,
        List<User> likedBy)
    {
        CommentId = commentId;
        TaskId = taskId;
        Text = text;
        CreatedBy = createdBy;
        CreatedAt = createdAt;
        ModifiedBy = modifiedBy;
        ModifiedAt = modifiedAt;
        _likedBy = likedBy;
    }
}