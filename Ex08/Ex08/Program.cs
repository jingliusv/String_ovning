using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1 = "231596874";
            Console.WriteLine(SortString(st1));
        }

        static string SortString(string str)
        {
            char[] letters = str.ToCharArray();
            Array.Sort(letters);
            string charToString = new string(letters);
            return charToString;
        }
    }
}
