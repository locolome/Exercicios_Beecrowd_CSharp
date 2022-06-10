using System;
using System.Globalization;
namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double novosal,sal,rea;
            string por;
            sal=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            if (sal<=400){
                por="15 %";
                rea=sal*0.15;
                novosal=sal+(sal*0.15);
                Console.WriteLine("Novo salario: " + novosal.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + rea.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + por);

            }if (sal>=400.01 && sal<=800){
                novosal=sal+(sal*0.12);
                por="12 %";
                rea=sal*0.12;
                Console.WriteLine("Novo salario: " + novosal.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + rea.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + por);

            }if (sal>=800.01 && sal<=1200){
                novosal=sal+(sal*0.10);
                por="10 %";
                rea=sal*0.10;
                Console.WriteLine("Novo salario: " + novosal.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + rea.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + por);

            }if (sal>=1200.01 && sal<=2000){
                novosal=sal+(sal*0.07);
                por="7 %";
                rea=sal*0.07;
                Console.WriteLine("Novo salario: " + novosal.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + rea.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + por);

            }if (sal>2000){
                novosal=sal+(sal*0.04);
                por="4 %";
                rea=sal*0.04;
                Console.WriteLine("Novo salario: " + novosal.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + rea.ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + por);

            }
            

        }
    }
}
