using TaskManager.Domain;

namespace TaskManager.Application;

public class TaskService : ITaskService
{
    private readonly List<TaskItem> _tasks = new();
    private int _id = 1;

    public IEnumerable<TaskItem> GetAll() => _tasks;

    public TaskItem Add(string title)
    {
        var task = new TaskItem { Id = _id++, Title = title };
        _tasks.Add(task);
        return task;
    }
}
