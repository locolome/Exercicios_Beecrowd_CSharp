using System;

namespace uri1115
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){
                string[] vet = Console.ReadLine().Split(' ');
                int x= int.Parse(vet[0]);
                int y= int.Parse(vet[1]);
                if (x>0 && y>0){
                    Console.WriteLine("primeiro");
                    
                }if (x<0 && y>0){
                    Console.WriteLine("segundo");

                }if (x<0 && y<0){
                    Console.WriteLine("terceiro");

                }if (x>0 && y<0){
                    Console.WriteLine("quarto");

                }if (x==0 || y==0){
                    break;
                }
            }
        }
    }
}
