using System;
using System.Globalization;
namespace Aula06exec1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double nota1, nota2, notafinal;

            //entrada
            //45.5
            //31.3
            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            notafinal = (nota1 + nota2) / 2.0;

            //saida
            //nota final = 57.5
            //reprovado
            Console.WriteLine("nota final = " + 
            notafinal.ToString("F1",CultureInfo.InvariantCulture));

            if(notafinal<60){
                Console.WriteLine("reprovado");
            }
            else{
                Console.WriteLine("aprovado");
            }

            
        }
    }
}
