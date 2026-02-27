using LLD.ConsoleApp.Observer.TaskManagement.Utils;

namespace LLD.ConsoleApp.Observer.TaskManagement.Services
{
    public class EmailService:IObserver
    {
        public void Notify(long id, long taskId)
        {
            string subject = "New task assigned";
            string message = $"Task {taskId} assigned to user {id}";
            NotificationUtils.SendEmail(subject, message);
        }
    }
}