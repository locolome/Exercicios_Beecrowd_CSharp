using System;
using System.Globalization;
namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] notas = { 100.00M, 50.00M, 20.00M, 10.00M, 5.00M, 2.00M };
            int[] qntnotas = { 0, 0, 0, 0, 0, 0 };
            decimal[] moedas = { 1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };
            int[] qntmoedas = { 0, 0, 0, 0, 0, 0, };
            decimal entrada = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //se a entrada for maior que 100
            if (entrada >= notas[0])
            {
                //qntnotas recebe entrada /100
                qntnotas[0] = (int)Math.Floor(entrada / 100);
                //entrada recebe o resto da divisao
                entrada = entrada % 100;
            }

            if (entrada >= notas[1])
            {
                qntnotas[1] = (int)Math.Floor(entrada / 50);
                entrada = entrada % 50;
            }

            if (entrada >= notas[2])
            {
                qntnotas[2] = (int)Math.Floor(entrada / 20);
                entrada = entrada % 20;
            }

            if (entrada >= notas[3])
            {
                qntnotas[3] = (int)Math.Floor(entrada / 10);
                entrada = entrada % 10;
            }

            if (entrada >= notas[4])
            {
                qntnotas[4] = (int)Math.Floor(entrada / 5);
                entrada = entrada % 5;
            }

            if (entrada >= notas[5])
            {
                qntnotas[5] = (int)Math.Floor(entrada / 2);
                entrada = entrada % 2;
            }

            //moedas
            if (entrada >= moedas[0])
            {//1.00
                qntmoedas[0] = (int)Math.Floor(entrada / moedas[0]);
                entrada = entrada % moedas[0]; //1.00
            }
            if (entrada >= moedas[1])
            {//0.50
                qntmoedas[1] = (int)Math.Floor(entrada / moedas[1]);
                entrada = entrada % moedas[1]; //0.50
            }
            if (entrada >= moedas[2])
            {//0.25
                qntmoedas[2] = (int)Math.Floor(entrada / moedas[2]);
                entrada = entrada % moedas[2]; //0.25
            }
            if (entrada >= moedas[3])
            {//0.10
                qntmoedas[3] = (int)Math.Floor(entrada / moedas[3]);
                entrada = entrada % moedas[3]; //0.10
            }
            if (entrada >= moedas[4])
            {//0.05
                qntmoedas[4] = (int)Math.Floor(entrada / moedas[4]);
                entrada = entrada % moedas[4]; //0.05
            }
            if (entrada >= moedas[5])
            {//0.01
                qntmoedas[5] = (int)Math.Floor(entrada / moedas[5]);
                entrada = entrada % moedas[5]; //0.01

            }
            Console.WriteLine("NOTAS:");

            for (int i = 0; i <= 5; i++)
            {
                //para que i=0 até que i<=5,incrementando i com 1

                Console.WriteLine(qntnotas[i] + " nota(s) de R$ " + notas[i].ToString("F2",CultureInfo.InvariantCulture));

                //Console.WriteLine(qntnotas[0]+ "notas(s) de R$100.00");
                // Console.WriteLine(qntnotas[1]+ "notas(s) de R$50.00");
                // Console.WriteLine(qntnotas[2]+ "notas(s) de R$25.00");
                // Console.WriteLine(qntnotas[3]+ "notas(s) de R$10.00");
                // Console.WriteLine(qntnotas[4]+ "notas(s) de R$5.00");
                // Console.WriteLine(qntnotas[5]+ "notas(s) de R$2.00");
            }
            Console.WriteLine("MOEDAS:");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(qntmoedas[i] + " moeda(s) de R$ " + moedas[i].ToString("F2",CultureInfo.InvariantCulture));
                // Console.WriteLine(qntmoedas[0] + "moeda(s) de R$1.00");
                // Console.WriteLine(qntmoedas[1] + "moeda(s) de R$0.50");
                // Console.WriteLine(qntmoedas[2] + "moeda(s) de R$0.25");
                // Console.WriteLine(qntmoedas[3] + "moeda(s) de R$0.10");
                // Console.WriteLine(qntmoedas[4] + "moeda(s) de R$0.05");
                // Console.WriteLine(qntmoedas[5] + "moeda(s) de R$0.01");
            }
        }
    }
}

