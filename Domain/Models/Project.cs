namespace Domain.Models;

/// <summary>
/// Model biznesowy i bazodanowy projektu.
/// </summary>
public class Project
{
    private readonly List<TaskItem> _tasks;

    public int ProjectId { get; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ProjectStatus Status { get; private set; }
    public DateTime? StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public User CreatedBy { get; } // pomocne w nawigacji między projektem i użytkownikiem
    public DateTime CreatedAt { get; }
    public User? ModifiedBy { get; private set; } // pomocne w nawigacji między projektem i użytkownikiem
    public DateTime? ModifiedAt { get; private set; }
    public IEnumerable<TaskItem> Tasks => _tasks.AsReadOnly();

    public Project(int projectId, string name, string description, ProjectStatus status,
        DateTime startDate, DateTime? endDate,
        User createdBy, DateTime createdAt,
        User modifiedBy, DateTime? modifiedAt,
        List<TaskItem> tasks)
    {
        ProjectId = projectId;
        Name = name;
        Description = description;
        Status = status;
        StartDate = startDate;
        EndDate = endDate;
        CreatedBy = createdBy;
        CreatedAt = createdAt;
        ModifiedBy = modifiedBy;
        ModifiedAt = modifiedAt;
        _tasks = tasks;
    }
}