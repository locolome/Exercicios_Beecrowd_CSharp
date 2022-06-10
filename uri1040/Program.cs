using System;
using System.Globalization;
namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet=Console.ReadLine().Split(' ');
            double x=double.Parse(vet[0],CultureInfo.InvariantCulture);
            double y=double.Parse(vet[1],CultureInfo.InvariantCulture);
            if (x==0 && y==0){
                Console.WriteLine("Origem");

            }
            else if(x== 0.0){
                Console.WriteLine("Eixo Y");

            }
            else if(y== 0.0){
                Console.WriteLine("Eixo x");
            }
            if (x>0 && y>0){
                Console.WriteLine("Q1");

            }
            if (x>0 && y<0){
                Console.WriteLine("Q4");

            }
            if (x<0 && y>0){
                Console.WriteLine("Q2");

            }
            if (x<0 && y<0){
                Console.WriteLine("Q3");
            }
        }   
    }
}
