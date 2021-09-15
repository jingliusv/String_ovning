using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class InputToArrayConverter
    {
        public int[] Converter(string input)
        {
            int[] intArray = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                intArray[i] = (int)(input[i] - 48);
            }
            return intArray;
        }
    }
}
