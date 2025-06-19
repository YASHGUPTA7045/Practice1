using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization
{

    class Program
    {
        public static void Main(String[] args)
        {
            Employee emp = new Employee(1234, "yashGupta");
            String path = @"C:\Users\DELL\source\new.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, emp);
            Console.WriteLine("the path of created file is" + path);

        }
    }
}