using System;
using System.Globalization;
namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio=double.Parse(Console.ReadLine());
            double pi=3.14159;
            double vol=(4.0/3)*pi*(raio*raio*raio);
            Console.WriteLine("VOLUME = " + vol.ToString("F3",CultureInfo.InvariantCulture));



        }
    }
}
