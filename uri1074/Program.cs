using System;

namespace uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            n = int.Parse(Console.ReadLine());
            for (int y = 0; y < n; y++)//y++ encrementar valor da variavel
            {

                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");

                }
                if (x > 0)
                {
                    // positivo
                    // par
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");

                    }else{
                        // impar
                        Console.WriteLine("ODD POSITIVE");
                    }


                }
                if (x<0){
                    if (x%2==0){
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else{
                        Console.WriteLine("ODD NEGATIVE");
                    }
                    // negativo

                    //par
                    // impar
                }

            }

        }
    }
}
