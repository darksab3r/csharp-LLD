namespace LLD.ConsoleApp.Observer.TaskManagement
{
    public interface IObserver
    {
        void Notify(long id, long taskId);
    }
}