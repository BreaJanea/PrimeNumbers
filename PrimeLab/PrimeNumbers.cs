using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeLab
{
    public class PrimeNumbers
    {
        private static int[] num = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
        public static int GetPrime(int n)
        {
            return num[n - 1];

        }
    }
}
