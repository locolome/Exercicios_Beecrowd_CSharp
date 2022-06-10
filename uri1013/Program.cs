using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet=Console.ReadLine().Split(' ');
            int a=int.Parse(vet[0]);
            int b= int.Parse(vet[1]);
            int c= int.Parse(vet[2]);
            int maiorAB,maior;
            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
