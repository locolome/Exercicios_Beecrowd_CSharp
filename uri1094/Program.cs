using System;
using System.Globalization;
namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total= int.Parse(Console.ReadLine());
            int coe=0;
            int rat=0;
            int sap=0;
            int soma=0;
            int qnt;
            char tipo;

            for (int i=0; i < Total;i++){
                string[] vet=Console.ReadLine().Split(' ');
                qnt=int.Parse(vet[0]);
                tipo=char.Parse(vet[1]);
                soma+=qnt;
                if (tipo=='C'){
                    coe+=qnt;
                }
                if (tipo=='R'){
                    rat+=qnt;
                }
                if (tipo=='S'){
                    sap+=qnt;
                }

            }
            double Totalcobaia =(coe+rat+sap)*1.00;

            Console.WriteLine("Total: " + Totalcobaia.ToString("F0") + " cobaias");
            Console.WriteLine("Total de coelhos: " + coe);
            Console.WriteLine("Total de ratos: " + rat);
            Console.WriteLine("Total de sapos: " + sap);
            double porcoel = (coe/Totalcobaia)*100.00;
            double porrat = (rat/Totalcobaia)*100.00;
            double porsapo = (sap/Totalcobaia)*100.00;
            Console.WriteLine("Percentual de coelhos: " + porcoel.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + porrat.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + porsapo.ToString("F2",CultureInfo.InvariantCulture) + " %");


            

        }
    }
}
