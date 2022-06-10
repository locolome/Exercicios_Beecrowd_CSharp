using System;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet=Console.ReadLine();
            int a=int.Parse(vet[0]);
            int b=int.Parse(vet[1]);
            int c=int.Parse(vet[2]);
            if(a>b>c){
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine();

            }
            else if(b>a>c){
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine();
                
            }
            else if(c>a>b){
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine();
            }
            else if(a>c>b){
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine();
            }
            else if(b>c>a){
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine();
            }
            else if(c>b>a){
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine();

            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
