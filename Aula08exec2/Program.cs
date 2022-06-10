using System;
using System.Globalization;
namespace Aula08exec2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            string[] linha=Console.ReadLine().Split(' ');
            double[] valores = new double[N];// alocar variaveis na memória ram, [N] define o tamanho do vetor(reservando uma mesa num restaurante)
            double maior=0.0;
            int posicao=0;
            //percorre o vetor da linha
            for (int i=0;i<N ; i++){
                valores[i]=double.Parse(linha[i],CultureInfo.InvariantCulture);

            } 
            //percorre o vetor de valores double
            for (int i=0;i<N;i++){
                //se o vetor na posição i for maior que a var maior
                if(valores[i] > maior){
                    //ela atribui o valor da var maior aos valores na posição i
                    maior = valores[i];
                    //atribui o valor da var posição ao valor do indice i
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);

        }
    }
}
