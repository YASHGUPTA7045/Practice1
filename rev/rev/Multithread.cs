using System;
using System.Threading.Tasks; 

public class Multithread
{
    public static void Print()
    {

        Task t = Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Background Task {i}");
            }
        }); 

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Main Task {i}");
        }

        t.Wait(); 
        Console.WriteLine("Completed task both"); 
    }
}
