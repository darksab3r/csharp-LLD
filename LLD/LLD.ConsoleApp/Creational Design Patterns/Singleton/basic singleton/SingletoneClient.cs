namespace LLD.ConsoleApp.Singleton.basic;

using System;
public class BasicSingletonClient
{
    public static void Run()
    {
        Console.WriteLine("Singleton Client Running...\n");

        var instance1 = Singleton.GetInstance();
        var instance2 = Singleton.GetInstance();
        
        Console.WriteLine(
            $"Are both instances same? {ReferenceEquals(instance1, instance2)}"
        );
    }
}
