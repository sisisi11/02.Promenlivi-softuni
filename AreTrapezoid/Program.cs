using System;

namespace AreTrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gorna osnova =");
            var topBase = double.Parse(Console.ReadLine());
            Console.WriteLine("dolna osnova =");
            var bottomBase = double.Parse(Console.ReadLine());
            Console.WriteLine("visochina =");
            var height = double.Parse(Console.ReadLine());
            var area = (topBase + bottomBase) * height / 2.0;
            Console.WriteLine("Trapezoid area = {0}", area);
        }
    }
}
