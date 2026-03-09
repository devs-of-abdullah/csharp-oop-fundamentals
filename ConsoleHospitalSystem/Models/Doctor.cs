using HospitalSystem.Core;
using HospitalSystem.Interfaces;

namespace HospitalSystem.Models
{
    public class Doctor : Person, IWorkable
    {
        public string? Specialty { get; set; }

        public readonly string LicenseNumber;

        public Doctor(string name, int age, string specialty, string licenseNumber) : base(name, age)  
        {
            Specialty = specialty;
            LicenseNumber = licenseNumber;
        }

        public override void Describe()
        {
            Console.WriteLine($"Doctor {Name} | Specialty: {Specialty} | License: {LicenseNumber}");
        }

        public override void Introduce()
        {
            base.Introduce();   
            Console.WriteLine($"I am a {Specialty} specialist.");
        }

        public void Work()
        {
            Console.WriteLine($"Dr. {Name} is examining patients.");
        }

        public void Prescribe(string medicine)
        {
            Console.WriteLine($"Dr. {Name} prescribed: {medicine}");
        }

        public void Prescribe(string medicine, int days)
        {
            Console.WriteLine($"Dr. {Name} prescribed: {medicine} for {days} days");
        }

        public void Prescribe(string medicine, int days, string notes)
        {
            Console.WriteLine($"Dr. {Name} prescribed: {medicine} for {days} days | Notes: {notes}");
        }
    }
}
