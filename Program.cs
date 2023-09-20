using System;

namespace Uppgift2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar person 1 i ditt företag?");
            float X = float.Parse(Console.ReadLine());
            Console.WriteLine(" Hur mycket tjänar person 2 i ditt företag?");
            float Y = float.Parse(Console.ReadLine());
            Console.WriteLine(" Hur mycket tjänar person 3 i ditt företag?");
            float Z = float.Parse(Console.ReadLine());
            float medel = (X + Y + Z) / 2;
            Console.WriteLine("Medelönen för personalen är" + medel);
        }
    }
}
