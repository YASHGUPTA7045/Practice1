using System;
namespace Serialization
{
    [Serializable]
    class Employee
    {
        public int Id;
        public string Name;
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}