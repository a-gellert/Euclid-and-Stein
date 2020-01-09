using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EuclidAndStein.Classes
{
    public class Solver
    {
        private static int _result;
        public static double Time { get; set; }

        public static int EuclidGCD(int firstN, int secondN)
        {
            
            using (Watcher.Start(t => Time = t.TotalMilliseconds ))
            {
                int result = Solver.GCD(firstN, secondN);
                return result;
            }
        }
        public static int EuclidGCD(string numbers)
        {
            using (Watcher.Start(t => Time = t.TotalMilliseconds))
            {
                int[] array = Converter.ConvertToInt(numbers);
                int result = Solver.Simpler(array);
                return result;
            }
        }
        public static int EuclidGCD( params int[] numbers)
        {
            using (Watcher.Start(t => Time = t.TotalMilliseconds))
            {
                return Solver.Simpler(numbers);
            }
        }

        public static int SteinGCD(int firstN, int secondN)
        {
            using (Watcher.Start(t => Time = t.TotalMilliseconds))
            {
                
                if (firstN == 0)
                { 
                    return secondN;
                }
                if (secondN == 0)
                {
                    return firstN;
                }
                int range;
                for (range = 0; ((firstN | secondN) & 1) == 0; ++range)
                {
                    firstN >>= 1;
                    secondN >>= 1;
                }
                while ((firstN & 1) == 0)
                    firstN >>= 1;
                do
                {
                    while ((secondN & 1) == 0)
                        secondN >>= 1;

                    if (firstN > secondN)
                    {
                        int temp = firstN;
                        firstN = secondN;
                        secondN = temp;
                    }
                    secondN = (secondN - firstN);
                } while (secondN != 0);
                return firstN << range;

            }
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
                numbers[i + 1] = _result;
            }
            return _result;
        }
    }
}
