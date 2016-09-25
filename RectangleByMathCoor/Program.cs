using System;

namespace RectangleByMathCoor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vuvedete kooridnata(x1)");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete kooridnata(y1)");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete kooridnata(x2)");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete kooridnata(y2)");
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = {0}", width * height);
            Console.WriteLine("Perimeter = {0}", 2 * (width + height));
        }
    }
}
