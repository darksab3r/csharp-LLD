namespace LLD.ConsoleApp.Observer.TaskManagement;

public class ObserverRegistry:IObserverRegistry
{
    private List<IObserver> _observers = new List<IObserver>();
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
    {
        if (_observers.Contains(observer))
            _observers.Remove(observer);
    }
    public void NotifyObservers(long taskId, long userId)
    {
        foreach (var observer in _observers)
        {
            observer.Notify(taskId, userId);
        }
    }
}