using System;
using System.Globalization;
namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int qnt1= int.Parse(vet[1]);
            double prec1 = double.Parse(vet[2],CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet[0]);
            int qnt2= int.Parse(vet[1]);
            double prec2 = double.Parse(vet[2],CultureInfo.InvariantCulture);

            double total =(qnt1 * prec1) + (qnt2* prec2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
