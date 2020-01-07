using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidAndStein.Classes
{
    public class Converter
    {
        public static int[] ConvertToInt(string str)
        {
            char[] delimiterChars = { ',' };

            return Parsing(str, delimiterChars);
        }
        private static int[] Parsing(string str, char[] delimiterChars)
        {
            string[] strNumbers = str.Split(delimiterChars);
            int[] numbers = new int[strNumbers.Length];

            for (int i = 0; i < strNumbers.Length; i++)
            {
                if (int.TryParse(strNumbers[i], out int temp))
                {
                    numbers[i] = temp;
                }
            }
            return numbers;
        }
    }
}
