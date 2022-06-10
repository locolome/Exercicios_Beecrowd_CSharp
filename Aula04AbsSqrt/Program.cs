using System;
using System.Globalization;

namespace Aula04AbsSqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor,raiz;
            Console.Write("Informe um valor: ");

            valor=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            raiz=Math.Sqrt(valor);

            Console.WriteLine("Raiz quadrada de " + valor+": " + raiz);

        }
    }
}
