using LLD.ConsoleApp.Observer.TaskManagement.Services;

namespace LLD.ConsoleApp.Observer.TaskManagement;

public class TaskManagementClient
{
    public void Run()
    {
        TaskManager _taskManager = new TaskManager();
        
        _taskManager.AddObserver(new EmailService());
        _taskManager.AddObserver(new SlackService());
        _taskManager.AddObserver(new AppService());
        
        _taskManager.AssignTask(123, 456);
    }
}