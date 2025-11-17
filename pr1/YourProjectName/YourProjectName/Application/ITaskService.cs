using TaskManager.Domain;

namespace TaskManager.Application;

public interface ITaskService
{
    IEnumerable<TaskItem> GetAll();
    TaskItem Add(string title);
}
