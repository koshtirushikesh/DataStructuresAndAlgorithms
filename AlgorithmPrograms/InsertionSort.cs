using System;

namespace AlgorithmPrograms
{
    internal class InsertionSort
    {
        public void Sort()
        {
            int[] array = { 10, 60, 30, 20, 40, 50, 70, 90, 80 };
            int temp = 0, j = 0, flage = 0;

            Console.Write("Before sorting Array    : ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                flage = 0;

                for (j = i - 1; j >= 0 && flage != 1;)
                {
                    if (array[j] > temp)
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = temp;
                    }
                    else
                    {
                        flage = 1;
                    }
                }
            }
            Console.Write("\nSorted array(Inserction): ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
