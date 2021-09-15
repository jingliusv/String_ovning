using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ett, två, tre, fyra, fem, sex, sju";
            string newText = text.Insert(0, "noll, ");

            string[] numbers = newText.Split(',');
            foreach(string number in numbers)
                Console.WriteLine(number);
        }
    }
}
