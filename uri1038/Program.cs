using System;
using System.Globalization;
namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] var=Console.ReadLine().Split(' ');
            int cod=int.Parse(var[0]);
            int qnt=int.Parse(var[1]);
            double pr, total;
            pr=0;
            if (cod==1){
                pr=4.00;
            }
            if (cod==2){
                pr=4.5;
            }
            if (cod==3){
                pr=5.00;
            }
            if (cod==4){
                pr=2.00;
            }
            if (cod==5){
                pr=1.50;
            }
            total=qnt * pr;
            Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
