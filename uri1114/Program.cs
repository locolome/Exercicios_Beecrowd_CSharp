using System;

namespace uri1114
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int teste=int.Parse(Console.ReadLine());
            int senha=2002;
            while (teste!=senha){
                Console.WriteLine("Senha Invalida");
                teste=int.Parse(Console.ReadLine());
                if (teste==senha){
                    break;
                }
            }
            Console.WriteLine("Acesso Permitido");


        }
    }
}
