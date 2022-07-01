using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zad._5._5
{
    class Program
    {
        static void Rysuj(int n, int x, string y)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pionowo:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Poziomo:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Znak:");
            string y = Console.ReadLine();

            Rysuj(x, n, y);
            Console.WriteLine();
            Rysuj(n, x, y);
            Console.ReadKey();
        }
    }
}