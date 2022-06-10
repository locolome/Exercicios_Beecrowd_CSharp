using System;
using System.Globalization;
namespace Aula_7_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            char resposta;
            //Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em farenhait.Perguntar se o usuario deseja repetir(s/n). Caso seja s, repete o programa. 
            do{
                //imprime o que o usuario deve informar
                Console.Write("Digite a temperatura em Celsius: ");
                //criar variavel double atrinbui o valor do teclado a ela
                double celsius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                double farenhait = (celsius*9)/5+32;
                
                Console.WriteLine("Equivalente em fahrenheit " + 
                farenhait.ToString("F1",CultureInfo.InvariantCulture));
                
                //Atribui a variavel repetir o valor digitado no teclado
                // e passa 
                Console.Write("Deseja repetir (s / n)?");
                resposta = char.Parse(Console.ReadLine().ToLower());
            }
            while(resposta == 's');
        }   
    }
}
