using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
           int valor,ano,mese,dia,resto;
           valor= int.Parse(Console.ReadLine());
           ano=valor/365;
           resto=valor%365;
           mese = resto/30;
           dia = resto%30;

           Console.WriteLine(ano + " ano(s)");
           Console.WriteLine(mese + (" mes(es)"));
           Console.WriteLine(dia + (" dia(s)"));


        }
    }
}
