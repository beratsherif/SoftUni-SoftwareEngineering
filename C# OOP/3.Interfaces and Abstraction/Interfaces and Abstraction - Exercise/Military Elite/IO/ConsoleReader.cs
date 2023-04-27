namespace Military_Elite.IO
{
    using System;

    using Interfaces;
    public class ConsoleReader : IReader
   {
       public string ReadLine()
           => Console.ReadLine();
   }
}
