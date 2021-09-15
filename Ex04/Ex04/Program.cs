using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "kurt andersson";
            string firstname, lastname;
            string[] names = name.Split(' ');
            firstname = ToUppercase(names[0]);
            lastname = ToUppercase(names[1]);
            Console.WriteLine($"{firstname} {lastname}");
        }

        static string ToUppercase(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
