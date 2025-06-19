namespace INumerable
{
    class Numberable
    {
        List<int> Numbers = new List<int>()
        { 1, 2, 3, 4, 5, 6,};
        IEnumerable<int> even;
        public Numberable()
        {
            even = Numbers.Where(n => n % 2 == 0);
        }
        public void PrintEvenNumbers()
        {
            foreach (var num in even)
            {
                Console.WriteLine(num);
            }
        }

    }
    class Program
    {
        public static void Main(String[] args)
        {
            Numberable obj = new Numberable();
            obj.PrintEvenNumbers();

        }
    }
}