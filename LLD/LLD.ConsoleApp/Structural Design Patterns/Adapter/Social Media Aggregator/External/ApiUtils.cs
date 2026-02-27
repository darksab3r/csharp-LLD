using System;

namespace LLD.ConsoleApp.Adapter.SocialMediaAggregator.External
{
    public class ApiUtils
    {
        public static void LogFacebookGetPosts()
        {
            Console.WriteLine("Fetching Facebook posts");
        }

        public static void LogFacebookPostStatus()
        {
            Console.WriteLine("Posting status on Facebook");
        }

        public static void LogTwitterGetPosts()
        {
            Console.WriteLine("Fetching Twitter posts");
        }

        public static void LogTwitterPostStatus()
        {
            Console.WriteLine("Posting status on Twitter");
        }
    }
}