using System;
using System.Collections.Generic;
using System.Text;

namespace Euler.Problems
{
    public class Problem10
    {

        public long findSumOfNaturalsUnder(int max)
        {
            
            long sum = 0;
            for (int i = 2; i < max; i++)
            {
                if (isPrime(i))
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public bool isPrime(int naturalNumber)
        {
            double sqrtOfNatural = Math.Sqrt(Convert.ToDouble(naturalNumber));
            if (naturalNumber <= 1)
            {
                return false;
            }
            else if (naturalNumber <= 3)
            {
                return true;
            }
            else if (naturalNumber % 2 == 0 || naturalNumber % 3 == 0)
            {
                return false;
            }
            for (int i = 3; i <= sqrtOfNatural; i++)
            {
                if(naturalNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
