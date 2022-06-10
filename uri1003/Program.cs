using System;

namespace uri1003
{
    class Program
    {
        static void Main(string[] args)
        {
            // declara variavel
            int A,B;
            int soma;

            // atribui o valor
            // atraves da leitura do teclado
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            // calculo
            soma = A + B;
            
            // imprimindo a saida
            Console.WriteLine("SOMA = " + soma);


        }
    }
}
