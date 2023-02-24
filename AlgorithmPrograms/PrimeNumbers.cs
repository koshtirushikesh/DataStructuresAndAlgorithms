using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class PrimeNumbers
    {
        public void Check(int minNum,int maxNum)
        {
            Console.WriteLine("prime number: ");
            for (int i = minNum; i <= maxNum; i++)
            {
                bool IsPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if(IsPrime)
                    Console.Write(i+" ");
            }
        }
    }
}
