using System;
using System.Globalization;
namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome;
           double sal,vendas,montante;

            nome=Console.ReadLine();
            sal=double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);

            vendas=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            montante=(vendas*0.15)+sal;

            Console.WriteLine("TOTAL = R$ "+ montante.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
