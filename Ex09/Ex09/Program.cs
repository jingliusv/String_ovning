using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            Console.WriteLine($"Du har matat in {words.Length} ord.");
        }
    }
}
