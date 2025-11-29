using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    internal class Program
    {
        static void WelcomeUser(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        static int Square(int number)
        {
            return number * number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));
            Console.WriteLine(Square(9));
            Console.WriteLine(Square(13));
            Console.ReadKey();
        }
    }
}
