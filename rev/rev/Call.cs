namespace rev
{
    class Call
    {
        //public delegate void MyApp();
        public static void DoWork(Action cd)
        {
            Console.WriteLine("jijjjj");
            cd();
        }
        public static void DoneWork()
        {
            Console.WriteLine("done");

        }
    }
}
