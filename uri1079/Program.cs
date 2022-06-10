using System;
using System.Globalization;
namespace uri_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());
            for (int i=0; i< n; i++){
                string [] vet= Console.ReadLine().Split(' ');
                double a=double.Parse(vet[0],CultureInfo.InvariantCulture);
                double b=double.Parse(vet[1],CultureInfo.InvariantCulture);
                double c=double.Parse(vet[2],CultureInfo.InvariantCulture);
                double media=((2*a)+(3*b)+(5*c))/(2+3+5);
                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));


            }
        }
    }
}
