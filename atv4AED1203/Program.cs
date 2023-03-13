using System;
using System.Globalization;

namespace atv4AED1203
{
    internal class Progam
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            triangulo triangulo = new triangulo(a, b, c);
            triangulo.ClassificaTriangulo();

            Console.ReadKey();
        }
    }
}
