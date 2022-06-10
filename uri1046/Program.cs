using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet=Console.ReadLine().Split(' ');
            int resultado,ini,fim;
            ini=int.Parse(vet[0]);
            fim=int.Parse(vet[1]);
            if (ini>=fim){
                resultado=24-ini+fim;
            }
            else{
                resultado=fim-ini;
            }
            Console.WriteLine("O JOGO DUROU " + resultado +" HORA(S)");
        }
    }
}
