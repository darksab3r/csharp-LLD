namespace LLD.ConsoleApp.Observer.TaskManagement;

public class TaskManager
{
    private IObserverRegistry _observerRegistry = new ObserverRegistry();

    public void AddObserver(IObserver observer)
    {
        _observerRegistry.AddObserver(observer);
    }

    public void AssignTask(long taskId, long userId)
    {
        Console.WriteLine($"Task {taskId} is assigned to user {userId}");
        _observerRegistry.NotifyObservers(taskId, userId);
    }
}