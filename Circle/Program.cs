using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vuvedete Radiusa: ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * (r * r);
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area is {0}, Perimeter is {1}", area, perimeter);
        }
    }
}
