using System;
using System.Globalization;
namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet= Console.ReadLine().Split(' ');
            double a=double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b=double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c=double.Parse(vet[2], CultureInfo.InvariantCulture);
            double pi=3.14159;
            double tri,cir,trap,qua,ret;
            tri=(a*c)/2;
            cir=pi*(c*c);
            trap=((a+b)*c)/2;
            qua=b*b;
            ret=a*b;
            Console.WriteLine("TRIANGULO: "+tri.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + cir.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trap.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + qua.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + ret.ToString("F3",CultureInfo.InvariantCulture));

            
        }
    }
}
