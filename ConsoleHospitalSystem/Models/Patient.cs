using HospitalSystem.Core;

namespace HospitalSystem.Models
{
    public class Patient : Person
    {
        public string? Diagnosis { get; set; }

        double _bill;
        public double Bill
        {
            get { return _bill; }
            private set { _bill = value; }
        }

        public Patient(string name, int age, string diagnosis) : base(name, age)
        {
            Diagnosis = diagnosis;
            _bill = 0;
        }

        public override void Describe()
        {
            Console.WriteLine($"Patient {Name} | Diagnosis: {Diagnosis} | Bill: ${Bill}");
        }

        public void AddBill(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid amount!");
                return;
            }
            _bill += amount;
            Console.WriteLine($"${amount} added to {Name}'s bill. Total: ${_bill}");
        }
    }
}
