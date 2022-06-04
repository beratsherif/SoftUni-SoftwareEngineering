using System;

namespace B09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) * 0.01;

            double totalVolumeLittres = (lenght * width * height) * 0.001;
            double freeSpace = totalVolumeLittres * (1 - percent);
            Console.WriteLine(freeSpace);




        }
    }
}
