using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett ord: ");
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string reversedInput = new string(inputArray);

            int isPalindrom = input.CompareTo(reversedInput);

            if(isPalindrom == 0)
                Console.WriteLine("Det är en palindrom.");
            else
                Console.WriteLine("Prova igen!");
        }
    }
}
