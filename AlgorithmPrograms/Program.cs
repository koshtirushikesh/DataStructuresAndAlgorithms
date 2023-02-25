using System;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("1.Anagram");
            Console.WriteLine("2.Prime number And Palindrome number");
            Console.WriteLine("3.Bubble Sorted");
            Console.Write("Enter Option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Anagram anagram = new Anagram();
                    anagram.Check("heart", "earth");
                    break;
                case 2:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    primeNumbers.CheckAnagramAndPrime(1, 1000);
                    break;
                case 3:
                    BubbleSort bubblesort = new BubbleSort();
                    bubblesort.Sort();
                    break;
                default:
                    Console.WriteLine("Please enter the currect option");
                    break;
            }
            Console.Write("\nPress {y]: continue or [n]:Exist  ->");
            char run = Convert.ToChar(Console.ReadLine());
            if (run == 'y')
                goto start;
        }
    }
}
