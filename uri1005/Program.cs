using System;
using System.Globalization;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variaveis    
            double A,B,media;

            // entrada de dados
            A=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // calculo
            media= (  A * 3.5   +  B * 7.5 )  / 11;
            
            // saida de dados
            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
