using HospitalSystem.Interfaces;

namespace HospitalSystem.Core
{
    public abstract class Person : IDescribable
    {
        string? _name;
        int _age;
        public const string HospitalName = "Istanbul City Hospital";

        public string? Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty!");
                    return;
                }
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Invalid age!");
                    return;
                }
                _age = value;
            }
        }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Describe();

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, Age: {Age} at {HospitalName}");
        }
    }
}
