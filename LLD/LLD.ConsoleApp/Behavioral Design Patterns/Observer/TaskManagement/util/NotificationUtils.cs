namespace LLD.ConsoleApp.Observer.TaskManagement.Utils
{
    public class NotificationUtils
    {
        public static void SendEmail(string subject, string content)
        {
            Console.WriteLine($"Sending Email Notification: {subject} - {content}");
        }

        public static void SendSlack(string subject, string content)
        {
            Console.WriteLine($"Sending Slack Notification: {subject} - {content}");
        }
        public static void SendPush(string subject, string content)
        {
            Console.WriteLine($"Sending Push Notification: {subject} - {content}");
        }
    }
}