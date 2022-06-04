using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfgroups = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kalimandjaro = 0;
            int K2 = 0;
            int everest = 0;
            for (int i = 0; i < coutOfgroups; i++)
            {
                int coutOFClimbers = int.Parse(Console.ReadLine());
                if (coutOFClimbers <= 5)
                {
                    musala += coutOFClimbers;
                }
                else if (coutOFClimbers > 5 && coutOFClimbers <= 12 )
                {
                    monblan += coutOFClimbers;
                }
                else if (coutOFClimbers > 12 && coutOFClimbers <= 25)
                {
                    kalimandjaro += coutOFClimbers;
                }
                else if (coutOFClimbers > 25 && coutOFClimbers <= 40)
                {
                    K2 += coutOFClimbers;
                }
                else
                {
                    everest += coutOFClimbers;
                }
            }
            int total = musala + monblan + kalimandjaro + K2 + everest;
            double percentMusala = (double)musala / total * 100.00;
            double percentMonblan = (double)monblan / total * 100.00;
            double percentKalimandjaro = (double)kalimandjaro / total * 100.00;
            double percentK2 = (double)K2 / total * 100.00;
            double percentEverest = (double)everest / total * 100.00;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKalimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
