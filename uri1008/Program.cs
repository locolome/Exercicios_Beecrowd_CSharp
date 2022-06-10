using System;
using System.Globalization;
namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor,salario;
            int horas,num;
            num=int.Parse(Console.ReadLine());
            horas=int.Parse(Console.ReadLine());
            valor=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            salario=valor*horas;

            Console.WriteLine("NUMBER = "+num);
            Console.WriteLine("SALARY = U$ "+salario.ToString("F2",CultureInfo.InvariantCulture));

            

            


        }
    }
}
