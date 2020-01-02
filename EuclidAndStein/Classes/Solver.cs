using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidAndStein.Classes
{
    public class Solver
    {
        private static int _result;
        public static int EuclidGCD(int firstN, int secondN)
        {
            return Solver.GCD(firstN, secondN);
        }

        public static int EuclidGCD(int firstN, int secondN, int thirdN)
        {
            int[] array = { firstN, secondN, thirdN };

            return Solver.Simpler(array);
        }

        public static int EuclidGCD(int firstN, int secondN, int thirdN, int fourthN)
        {
            int[] array = { firstN, secondN, thirdN, fourthN };

            return Solver.Simpler(array);
        }

        public static int EuclidGCD(int firstN, int secondN, int thirdN, int fourthN, int fifthN)
        {
            int[] array = { firstN, secondN, thirdN, fourthN, fifthN };

            return Solver.Simpler(array);
        }

        public static int EuclidGCD(params int[] numbers)
        {
            return Solver.Simpler(numbers);

        }

        public static int SteinGCD(int firstN, int secondN)
        {
            return 0;
      
        }

        private static int GCD(int firstN, int secondN)
        {
            if (firstN == secondN) { return secondN; }

            while (firstN != 0 && secondN != 0)
            {
                if (firstN > secondN)
                {
                    firstN %= secondN;
                }
                else
                {
                    secondN %= firstN;
                }
            }
            return firstN + secondN;
        }

        private static int Simpler(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                _result = Solver.GCD(numbers[i], numbers[i + 1]);
            }
            return _result;
        }
    }
}
