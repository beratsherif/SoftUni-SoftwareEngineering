using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatientCount = 0;
            int untreatedPatientCount = 0;
            for (int i = 1; i <= days; i++)
            {
                int patient = int.Parse(Console.ReadLine());
                if (untreatedPatientCount > treatedPatientCount && i % 3 == 0)
                {
                    doctors++;
                }
                if (patient <= doctors)
                {
                    treatedPatientCount += patient;
                }
                else
                {
                    treatedPatientCount += doctors;
                    untreatedPatientCount += patient - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatientCount}.");
            Console.WriteLine($"Untreated patients: {untreatedPatientCount}.");
        }
    }
}
