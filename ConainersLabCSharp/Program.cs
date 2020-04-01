using System;

namespace ConainersLabCSharp
{
    public class Program
    {
        static void Main()
        {
            Item ball2 = new Item("Мяч баскетбольный", 1.5, "Red", false);
            ball2.getInfo();
            Console.WriteLine("Hello world");
            Console.ReadKey();
        }
    }
}
