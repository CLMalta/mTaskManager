namespace Domain.Models;

/// <summary>
/// Model biznesowy i bazodanowy zadania.
/// </summary>
public class TaskItem
{
    private readonly List<Comment> _comments = new List<Comment>();

    public int TaskId { get; }
    public int? ProjectId { get; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public TaskItemPriority Priority { get; private set; }
    public TaskItemStatus Status { get; private set; }
    public User? AssignedTo { get; private set; } // pomocne w nawigacji między zadaniem i użytkownikiem
    public User CreatedBy { get; } // pomocne w nawigacji między zadaniem i użytkownikiem
    public DateTime CreatedAt { get; }
    public DateTime? DueDate { get; private set; }
    public User? ModifiedBy { get; private set; } // pomocne w nawigacji między zadaniem i użytkownikiem
    public DateTime? ModifiedAt { get; private set; }
    public IEnumerable<Comment> Comments => _comments.AsReadOnly();

    public TaskItem(int taskId, int? projectId, string title, string description,
        TaskItemPriority priority, TaskItemStatus status, User assignedTo,
        User createdBy, DateTime createdAt, DateTime? dueDate,
        User modifiedBy, DateTime? modifiedAt,
        List<Comment> comments)
    {
        TaskId = taskId;
        ProjectId = projectId;
        Title = title;
        Description = description;
        Priority = priority;
        Status = status;
        AssignedTo = assignedTo;
        CreatedBy = createdBy;
        CreatedAt = createdAt;
        DueDate = dueDate;
        ModifiedBy = modifiedBy;
        ModifiedAt = modifiedAt;
        _comments = comments;
    }
}