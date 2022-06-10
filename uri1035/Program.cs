using System;

namespace uri1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] var=Console.ReadLine().Split(' ');
            int A,B,C,D;
            A=int.Parse(var[0]);
            B=int.Parse(var[1]);
            C=int.Parse(var[2]);
            D=int.Parse(var[3]);

            if (B>C && D>A && (C+D)>(A+B) && C>0 && D>0 && (A%2)==0){

                Console.WriteLine("Valores aceitos");

            }
            else{
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}
