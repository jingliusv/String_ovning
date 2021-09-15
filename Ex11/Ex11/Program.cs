using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ditt personnummer: ");
            string input = Console.ReadLine();

            InputToArrayConverter inputToArray = new InputToArrayConverter();
            int[] personnummer = inputToArray.Converter(input);

            Modulus10Method mo10 = new Modulus10Method();
            Console.WriteLine(mo10.CheckIDNumber(personnummer));
        }
    }
}
