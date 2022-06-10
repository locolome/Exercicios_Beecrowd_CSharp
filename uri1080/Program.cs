using System;

namespace uri_1080
{
    class Program
    {
        static void Main(string[] args)

        {
            int maior;
            int posicao = 1;

            int a = int.Parse(Console.ReadLine());

            maior = a;

            for (int y = 2; y <= 100; y++)
            {
                a = int.Parse(Console.ReadLine());

                if (a > maior)
                {
                    maior = a;
                    posicao = y;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            
        }
    }
}
