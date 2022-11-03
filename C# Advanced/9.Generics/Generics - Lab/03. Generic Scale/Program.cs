using System;

namespace _03._Generic_Scale
{
    public class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(5, 5);
            Console.WriteLine(scale.AreEqual());

            EqualityScale<string> scale2 = new EqualityScale<string>("Hello", "hello");
            Console.WriteLine(scale2.AreEqual());
        }
    }
}
