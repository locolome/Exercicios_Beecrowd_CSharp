using System;
using System.Globalization;
namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet=Console.ReadLine().Split(' ');
            double a=double.Parse(vet[0],CultureInfo.InvariantCulture);
            double b=double.Parse(vet[1],CultureInfo.InvariantCulture);
            double c=double.Parse(vet[2],CultureInfo.InvariantCulture);

            if (a<b+c&&b<c +a&&c<a+b)
            {
                double pe=a+b+c;
                Console.WriteLine("Perimetro = "+pe.ToString("F1",CultureInfo.InvariantCulture));

            }
            else
            {
                double ar=((a+b)*c)/2;
                Console.WriteLine("Area = "+ar.ToString("F1",CultureInfo.InvariantCulture));
            }
        }
    }
}
