using System;
using System.Globalization;
namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp,velo;
            temp=int.Parse(Console.ReadLine());
            velo=int.Parse(Console.ReadLine());
            double lt=(temp*velo)/12.0;
            Console.WriteLine(lt.ToString("F3",CultureInfo.InvariantCulture));
        
        }

    }
}
