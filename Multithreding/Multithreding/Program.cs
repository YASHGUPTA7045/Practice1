namespace Multithreding;
class Program
{
    public static void Number()
    {
        for (int i = 1; i < 50; i++)
        {
            Console.WriteLine($"Number S1:{i}");
        }
    }
    public static void Number1()
    {
        for (int i = 1; i < 50; i++)
        {
            Console.WriteLine($"Number S2:{i}");
            Thread.Sleep(1000);
        }
    }
    public static void Number2()
    {
        for (int i = 1; i < 50; i++)
        {
            Console.WriteLine($"Number S3:{i}");
        }
    }
    public static void Main()
    {
        Thread s1 = new Thread(Number);
        Thread s3 = new Thread(Number2);
        Thread s2 = new Thread(Number1);
        //Console.WriteLine("s1 start");
        s1.Start();
        s1.Join();
        //Console.WriteLine("S2 start")
        s2.Start();
        s2.Join();
        s3.Start();
        s2.Join();
        //Number();
        //Number1();
        //Number2();
        Console.ReadLine();


    }
}