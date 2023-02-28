using System;

namespace AlgorithmPrograms
{
    internal class Search
    {
        public void searchMethord()
        {
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
                array[i] = i;
            
            int result = BinarySearch(array, 50);

            if (result == -1)
                Console.WriteLine("Data not found");
            else
                Console.WriteLine("Data found At indx: " + result);
        }
        public int BinarySearch(int[] array, int findData)
        {
            Array.Sort(array);
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int value = array[mid];
                Console.WriteLine(value + ": middel data searched");

                if (value < findData) low = mid + 1;
                else if (value > findData) high = mid - 1;
                else return mid;
            }
            return -1;
        }

    }
}
