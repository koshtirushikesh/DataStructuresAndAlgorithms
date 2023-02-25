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
        public bool CheckForAnagram(int number)
        {
            int inputNumber = number;
            int revers = 0;
            while (number !=0) 
            {
                int rem = number % 10;
                revers = revers*10 + rem;
                number = number/10;
            }
            if (revers == inputNumber) 
                return true;
            else 
                return false;
        }
        public void CheckAnagramAndPrime(int minNum,int maxNum)
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
                if(IsPrime && CheckForAnagram(i))
                    Console.Write(i+" ");
            }
        }
    }
}
