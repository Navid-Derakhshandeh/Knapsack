//Navid Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo conkey;
            do
            {
                Console.WriteLine("4 Items");
                Console.WriteLine("Restriction 15 Kilogram");
                Console.WriteLine("1 = h + e + g");
                Console.WriteLine("2 = h + f + g");
                Console.WriteLine("3 = e + f + h");
                Console.WriteLine("4 = e + f + g");
                K1();
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);

        }
        static void K1()
        {
            Console.WriteLine("Please Enter First Weight : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter First Value : ");
            int a1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Weight : ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Value : ");
            int b1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Third Weight : ");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Third Value : ");
            int c1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Fourth Weight : ");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Fourth Value : ");
            int d1 = Int32.Parse(Console.ReadLine());
            int e = a1 / a;
            int f = b1 / b;
            int g = c1 / c;
            int h = d1 / d;
            int i = h + e + g;
            int j = h + f + g;
            int k = e + f + h;
            int l = e + f + g;
            int m;
            int n;
            int u;
            int p;
            if (i > j)
            {
                m = i;
                u = 1;
            }
            else
            {
                m = j;
                u = 2;
            }

            if (k>l)
            {
                n = k;
                p = 3;
            }
            else
            {
                n = l;
                p = 4;
            }

            if (m > n)
            {
                Console.WriteLine("The Best Formula IS : ");
                Console.WriteLine(u);
                Console.WriteLine("The Answer of Formula Equal by : ");
                Console.WriteLine(m);
            }   
            else
            {
                Console.WriteLine("The Best Formula IS : ");
                Console.WriteLine(p);
                Console.WriteLine("The Answer of Formula Equal by : ");
                Console.WriteLine(n);
            }    
        }
    }
}
