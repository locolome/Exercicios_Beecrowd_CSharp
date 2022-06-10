using System;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis primitivas
            int idade = 20;
            double peso = 80.5;
            string nome = "Rafael Suarez";
            var sobrenome = "Vieira";
            int distancia;
            char letra = 'A';
            decimal totalVenda = 0;
            bool ehVerdadeEsseBilete = false;

            //declarar variaveis complexas
            string frase = "Quero ver, outra vez, seus olhinhos de noite serena";
            double subtotal = 0;

            string[] var=Console.ReadLine().Split(' ');
            int cod=int.Parse(var[0]);
            int qnt=int.Parse(var[1]);
            Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            sal=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite a sua idade: ");
            //idade recebe string do teclado e converte para inteiro
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.Write("Quantos kilometros você já correu? ");
            distancia = int.Parse(Console.ReadLine());

            Console.Write("Digite o total da venda: ");
            totalVenda = decimal.Parse(Console.ReadLine());

            Console.Write("Você leu os slides da aula passada?(s/n) ");
            var entrada = Console.ReadLine();
            ehVerdadeEsseBilete = entrada == "s" ? true : false;

            //limpando as mensagens da tela
            Console.Clear();
            //altere a cor das letras para verde
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dados formatados");
            Console.WriteLine("---------------------");
            Console.WriteLine("Idade " + idade);
            Console.WriteLine("peso " + peso);
            Console.WriteLine("nome " + nome);
            Console.WriteLine("sobrenome " + sobrenome);
            Console.WriteLine("kms " + distancia);
            Console.WriteLine("total da venda " + totalVenda);
            Console.WriteLine("Leu os slides " + ehVerdadeEsseBilete);
            Console.WriteLine("----------------------");
            //altere a cor das letras novamenete para branco
            Console.ForegroundColor = ConsoleColor.White;








        }
    }
}
