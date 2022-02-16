using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int kockadobas = rnd.Next(1, 7);
            Console.WriteLine(kockadobas);
            Console.ReadKey();
        }
    }
}
