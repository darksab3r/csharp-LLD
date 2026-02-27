namespace LLD.ConsoleApp.Observer.TaskManagement
{
    public interface IObserverRegistry
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(long taskId, long userId);
    }
}