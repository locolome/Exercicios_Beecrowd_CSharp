﻿using System;
using System.Globalization;
namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            string[] vet=Console.ReadLine().Split(' ');
            a=double.Parse(vet[0],CultureInfo.InvariantCulture);
            b=double.Parse(vet[1],CultureInfo.InvariantCulture);
            c=double.Parse(vet[2],CultureInfo.InvariantCulture);
            double delta=(b*b-4*a*c);
            if (delta<=0 || a==0){
                Console.WriteLine("Impossivel calcular");

            }
            else{
                double x2=(-b+Math.Sqrt(Math.Pow(b,2)-4*a *c))/(2*a);
                double x1=(-b-Math.Sqrt(Math.Pow(b,2)-4*a *c))/(2*a);
                Console.WriteLine("R1 = " + x2.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x1.ToString("F5",CultureInfo.InvariantCulture));


            }


            
        }
    }
}
