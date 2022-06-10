using System;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {  double raio, area;
        raio = double.Parse(Console.ReadLine());
        area=3.1415*Math.Pow(raio,2);
        Console.WriteLine("A="+area.ToString("0.0000"));
        Console.ReadKey();
    
           
        }
    }
}
