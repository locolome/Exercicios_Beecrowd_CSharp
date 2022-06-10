using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor string com 3 posições
            string[] vetor = new string[3];
            Console.WriteLine("Digite 3 palavras separadas por espaço e tecle enter.");
            //vetor recebe a leitura do teclado e divida o texto quando encontrar espaço
            vetor = Console.ReadLine().Split(' ');
            //imprime os valores do vetor e cada posição
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);

            string nome;
            int idade;
            double peso;

            Console.WriteLine("Informe o nome do cliente, idade e peso: ");
            string[] infos=new string[3];
            infos=Console.ReadLine().Split(' ');
            
            nome= infos[0];
            idade=int.Parse(infos[1]);
            peso=double.Parse(infos[2]);

            Console.WriteLine("Dados informados: ");
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(peso.ToString("F2"));
        }
    }
}
