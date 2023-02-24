using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("1.Anagram");
            Console.Write("Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Anagram anagram = new Anagram();
                    anagram.Check("heart", "earth");
                    break;
            }
            Console.WriteLine("Press {y]: continue or [n]:Exist");
            char run = Convert.ToChar(Console.ReadLine());
            if (run == 'y')
                goto start;
        }
    }
}
