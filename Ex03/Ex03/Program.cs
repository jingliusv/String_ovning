using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "I am a C# hacker";

            //a. Skriv ut vilken position sista a har
            Console.WriteLine($"a har position {b.LastIndexOf('a')}");
            //Skriv ut i vilken position ”C” har i strängen ovan. Skriv samtidigt ut längden på hela strängen ovan
            Console.WriteLine($"C har position { b.IndexOf('C')}, och längd är {b.Length}"); ;
            //Skriv ut varje ord för sig under varandra i en skärmutskrift
            Console.WriteLine("------");
            string[] words = b.Split(' ');
            foreach(string word in words)
                Console.WriteLine(word);
            Console.WriteLine("------");
            //Plocka ut delsträngen ' hacker' ur b ovan via kod och skriv på skärmen
            Console.WriteLine(b.Substring(10, 6));

            string newB = b.Replace('a', 'A').Replace('I', 'i').Replace('k', 'K').Replace('r', 'R');
            Console.WriteLine(newB);

        }
    }
}
