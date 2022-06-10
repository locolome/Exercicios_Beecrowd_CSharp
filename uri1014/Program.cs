using System;
using System.Globalization;
namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int dis=int.Parse(Console.ReadLine());
            double com=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double media=dis/com;
            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
