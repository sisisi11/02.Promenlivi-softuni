using System;

namespace Converter
{
    class CmToInches
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete inchove :");
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.Write("Santimetrite sa : ");
            Console.WriteLine(cm);
        }
    }
}
