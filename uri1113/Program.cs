using System;

namespace uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor;
            int x, y;

            vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            while(x != y){
                
                if(x<y){
                    Console.WriteLine("Crescente");
                
                }else{
                    Console.WriteLine("Decrescente");

                }
                vetor = Console.ReadLine().Split(' ');
                x=int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);
                
            }



        }
    }
}
