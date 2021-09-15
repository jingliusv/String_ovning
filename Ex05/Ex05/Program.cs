using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Detta är en sträng som du skall ändra";
            text.Replace(' ', '*');
            Console.WriteLine(text.Replace(' ', '*'));

            char[] letters = text.Replace(' ', '*').ToCharArray();
            int starNumbers = 0;

            foreach(char letter in letters)
            {
                if (letter == '*')
                    starNumbers++;
            }

            Console.WriteLine($"Det finns {starNumbers} * i strängen.");
        }
    }
}
