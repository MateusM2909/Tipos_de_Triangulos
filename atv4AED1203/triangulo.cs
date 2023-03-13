using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4AED1203
{
    internal class triangulo
    {

        private double a;
        private double b;
        private double c;

        public triangulo(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Digite valores maiores que zero:");
                do
                {
                    Console.Write("a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c: ");
                    c = Convert.ToDouble(Console.ReadLine());
                } while (a <= 0 || b <= 0 || c <= 0);
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private bool VerificaTriangulo()
        {
            return a < b + c && b < a + c && c < a + b;
        }

        private bool VerificaRetangulo()
        {
            double hipotenusa = Math.Max(Math.Max(a, b), c);
            double cateto1, cateto2;
            if (hipotenusa == a)
            {
                cateto1 = b;
                cateto2 = c;
            }
            else if (hipotenusa == b)
            {
                cateto1 = a;
                cateto2 = c;
            }
            else
            {
                cateto1 = a;
                cateto2 = b;
            }
            return Math.Pow(hipotenusa, 2) == Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
        }

        private bool VerificaObtusangulo()
        {
            return Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2);
        }

        // private bool VerificaAcutangulo()
        // {
        //     return Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2);
        //  }

        private bool VerificaEquilatero()
        {
            return a == b && b == c && a == c;
        }

        private bool VerificaIsosceles()
        {
            return a != b || b != c || a != c;
        }

        public void ClassificaTriangulo()
        {
            if (!VerificaTriangulo())
            {
                Console.WriteLine("NÃO FORMA TRIÂNGULO");
                return;
            }

            else if (VerificaRetangulo())
                Console.WriteLine("TRIÂNGULO RETÂNGULO");

            else if (VerificaObtusangulo())
                Console.WriteLine("TRIÂNGULO OBTUSÂNGULO");

            //if (VerificaAcutangulo())
            //    Console.WriteLine("TRIÂNGULO ACUTÂNGULO");

            else if (VerificaEquilatero())
                Console.WriteLine("TRIÂNGULO EQUILÁTERO");

            else if (VerificaIsosceles())
                Console.WriteLine("TRIÂNGULO ISÓSCELES");
        }
    }
}

