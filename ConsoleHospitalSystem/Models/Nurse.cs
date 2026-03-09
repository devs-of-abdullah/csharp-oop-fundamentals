using HospitalSystem.Core;
using HospitalSystem.Interfaces;

namespace HospitalSystem.Models
{
    public class Nurse : Person, IWorkable
    {
        public string? Ward { get; set; }

        public Nurse(string name, int age, string ward)
            : base(name, age)
        {
            Ward = ward;
        }

        public override void Describe()
        {
            Console.WriteLine($"Nurse {Name} | Ward: {Ward}");
        }

        public void Work()
        {
            Console.WriteLine($"Nurse {Name} is administering medicine in {Ward} ward.");
        }
    }
}
