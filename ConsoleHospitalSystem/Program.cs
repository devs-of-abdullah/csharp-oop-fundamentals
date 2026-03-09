using HospitalSystem.Core;
using HospitalSystem.Interfaces;
using HospitalSystem.Models;

namespace HospitalSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Learn OOP Project, HOSPITAL SYSTEM\n");

            Doctor doctor1 = new Doctor("Ahmad", 45, "Cardiology", "LIC-001");
            Doctor doctor2 = new Doctor("Abdullah", 38, "Neurology", "LIC-002");
            Nurse nurse1 = new Nurse("Muhammed", 30, "ICU");
            Patient patient1 = new Patient("Kerem", 25, "Flu");
            Patient patient2 = new Patient("Majd", 34, "Fracture");

            Console.WriteLine("Descriptions");
            List<Person> people = new List<Person> { doctor1, nurse1, patient1, patient2 };
            foreach (Person p in people)
            {
                p.Describe();
            }

            Console.WriteLine("\n Introductions");
            doctor1.Introduce();

            Console.WriteLine("\nStaff Working");
            List<IWorkable> staff = new List<IWorkable> { doctor1, doctor2, nurse1 };
            foreach (IWorkable worker in staff)
            {
                worker.Work();
            }

            Console.WriteLine("\n Prescriptions");
            doctor1.Prescribe("Aspirin");
            doctor1.Prescribe("Aspirin", 7);
            doctor1.Prescribe("Aspirin", 7, "Take after meals");

            Console.WriteLine("\n--- Patient Bills ---");
            patient1.AddBill(200);
            patient1.AddBill(150);
            patient2.AddBill(500);
            patient1.AddBill(-50);  

            Console.WriteLine($"\nAll staff work at: {Person.HospitalName}");

            Console.WriteLine($"Doctor license (readonly): {doctor1.LicenseNumber}");
        }
    }
}
