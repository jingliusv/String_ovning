using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Modulus10Method
    {
        public string CheckIDNumber(int[] inputArray)
        {
            int[] multiplyArray = new int[inputArray.Length - 1];

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (i % 2 == 0)
                    multiplyArray[i] = inputArray[i] * 2;
                else
                    multiplyArray[i] = inputArray[i];
            }

            int[] calculated = new int[multiplyArray.Length];
            for (int i = 0; i < multiplyArray.Length; i++)
            {
                if (multiplyArray[i] > 9)
                    calculated[i] = 1 + multiplyArray[i] % 10;
                else
                    calculated[i] = multiplyArray[i];
            }

            int sum = 0;
            for (int i = 0; i < calculated.Length; i++)
                sum += calculated[i];
            //use % to check
            string answer = string.Empty;
            if ((sum + inputArray[inputArray.Length - 1]) % 10 == 0)
                return answer = "Det är ett giltigt personnummer.";
            else
                return answer = "Fel personnummer.";
        }
    }
}
