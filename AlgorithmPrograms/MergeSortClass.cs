using System;

namespace AlgorithmPrograms
{
    public class MergeSortClass
    {
        public void Sort()
        {
            int[] array = { 10, 60, 30, 20, 40, 50, 70, 90, 80 };
            Console.Write("Before sorting Array: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            MergeSort(array);

            Console.Write("\nSorted array(Merge)  : ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        private void MergeSort(int[] array)
        {
            int length = array.Length;
            if (length <= 1) return;

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];

            int i = 0;   // right Array
            int j = 0;   // left Array
            while (i < length)
            {
                if (i < middle)
                {
                    leftArray[i] = array[i];
                    i++;
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                    i++;
                }
            }
            MergeSort(leftArray);
            MergeSort(rightArray);
            Merge(leftArray, rightArray, array);
        }

        private void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int i=0,l=0,r=0;
            while (l < leftSize && r < rightSize) 
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            
            }
            while(l < leftSize )
            {
                array[i] = leftArray[l];
                l++;
                i++;
            }
            while(r < rightSize )
            {
                array[i] = rightArray[r];
                r++;
                i++;
            }

        }
    }
}
