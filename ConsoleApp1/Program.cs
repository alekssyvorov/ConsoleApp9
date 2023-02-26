using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "5";
            string b = "1";

            Add(a, b);

            Console.ReadLine();
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Add(string a, string b)
        {
            Console.WriteLine(a + b);
        }
    }
}
