class Employee
{
    private int Age;
    private string Name;
    private double Salary;

    public int age
    {
        get
        {
            return Age;
        }
        set
        {
            if (age > 18 && age < 60)
            {
                Age = value;

            }
            else
            {
                Console.WriteLine("enter valid number");
            }
        }
    }
    public string name
    {
        get
        {
          
    
                return Name;
            

        }
        set
        {
            if (Name == null || Name == string.Empty)
            {
                Console.WriteLine("not valid string");
            }
            else
            {
                Name = value;
            }
        }
    }
    public double salary
    {
        get
        {

            return Salary;

        }
        set
        {
            Salary = value;
            Console.WriteLine($"Salary updated successfully to {value}");
        }
    }
    public static void Main()
    {
        Employee s = new Employee();
        s.Name = "Admin";
        s.Age = 25;
        s.Salary = 1245;
        Console.WriteLine(s.Salary);
        Console.WriteLine(s.Age);
        Console.WriteLine(s.Name);
    }


}

//class Program
//{
//    private int Num;
//    public int Age
//    {
//        get
//        {
//            return Num;
//        }
//        set
//        {
//            Num = value;
//        }
//    }
//    public static void Main()
//    {
//        Program s = new Program();
//        s.Num = 25;

//    }
//}

















//class Program
//{
//    public static void First(Action cd)
//    {
//        Console.WriteLine("hshshs");
//        cd();
//    }
//    public static void Second(Action cd)
//    {
//        Console.WriteLine("2");
//        cd();
//    }
//    public static void collection()
//    {
//        Console.WriteLine("callback");

//    }

//    public static void Main()
//    {
//        First(() => { Second(collection); });
//    }
//}





























//class Program
//{
//    //public static void Interger()
//    //{
//    //    int[] arr1 = { 1, 2000, 3, 4 };
//    //    int[] arr2 = { 2, 3000, 3, 4, };
//    //    if (arr1.Length != arr2.Length)
//    //    {
//    //        Console.WriteLine("not anangram");
//    //        return;
//    //    }
//    //    else
//    //    {
//    //        int[] arr3 = new int[20000];
//    //        for (int i = 0; i < arr1.Length; i++)
//    //        {
//    //            arr3[arr1[i]]++;
//    //            arr3[arr2[i]]--;
//    //        }
//    //        foreach (int count in arr3)
//    //        {
//    //            if (count != 0)
//    //            {
//    //                Console.WriteLine("not aani");
//    //                return;
//    //            }

//    //        }
//    //        Console.WriteLine("anagram");
//    //    }

















//        //public static void first(Action cd)
//        //{
//        //    Console.WriteLine("first bolte");
//        //    cd();
//        //}
//        //public static void Second(Action cd)
//        //{
//        //    Console.WriteLine("second bolte");
//        //    cd();
//        //}
//        //public static void third(Action cd)
//        //{
//        //    Console.WriteLine("hdhdhdhd=");
//        //    cd();
//        //}

//        //public static void Callback()
//        //{
//        //    Console.WriteLine("callback ayaya");
//        //}


//        //public static void Main()
//        //{
//        //    first(() => { Second(() => { third(Callback); }); });

//        //}


//    }
//    public static void Main()
//    {
//        Interger();
//    }
//}