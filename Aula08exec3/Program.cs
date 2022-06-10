using System;
using System.Globalization;
namespace Aula08exec3
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma=0.0;
            int menor=0;
            double media=0.0;
            int por=0;
            int n=int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++){
                string[] dados=Console.ReadLine().Split(' ');
                string nome=dados[0];
                int id=int.Parse(dados[1]);
                double alt=double.Parse(dados[2],CultureInfo.InvariantCulture);
                soma+=alt;
                media = soma/n;
                if (id<16){
                    menor+=1;                   
                }
                por=(menor*100)/n;

            }
            Console.WriteLine("Altura média: "+ media.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: "+ por + "%");
        }
    }
}
