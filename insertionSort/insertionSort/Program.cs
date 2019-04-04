using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 4, 1, 2, 8, 3, 5 };
            int[] sortedArray = { 4, 1, 2, 8, 3, 5 };
            int[] test = { 4, 1, 2 };
            insertionSort(sortedArray);

            //Print the original array
            Console.Write("Original Array: {");
            foreach (int num in originalArray)
            {
                Console.Write($"{num}");
            }
            Console.Write("}\n");


            //Print the sorted array
            Console.Write("Sorted Array: {");
            foreach (int num in sortedArray)
            {
                Console.Write($"{num}");
            }
            Console.Write("}");

            Console.ReadKey();
        }

        static void insertionSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++) //controls which element we are working on
            {
                if(array[0] > array[1]) //Performs the first swap
                {
                    temp = array[i+1];
                    array[i+1] = array[i];
                    array[i] = temp;

                }
                for (int j = i; j > 0; j--) //Logic to take the smallest number out of an array and place it into the beginning of the array
                {
                    if (array[j] < array[j-1])
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
