using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mailadress: ");
            string input = Console.ReadLine();
            bool hasAT = input.Contains('@');

            if (hasAT)
            {
                string[] parts = input.Split('.');
                bool rightEmail = parts[1].Length <= 3 && parts[1].Length >= 2;

                if(rightEmail)
                    Console.WriteLine("Det är rätt.");
                else
                    Console.WriteLine("Det är felaktig adress.");
            }
            else
                Console.WriteLine("Det är felaktig adress.");
        }
    }
}
