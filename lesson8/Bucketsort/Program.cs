using System;
using System.Collections.Generic;

namespace Bucketsort
{
    class Program
    {
        
        static void Main(string[] args)
        {
			int[] testArray = { 2, 10, 55, 8, 7, 15, 11, 128, 0, 458, 7954 };
			int[] testExArray = { 0, 2, 7, 8, 10, 11, 15, 55, 128, 458, 7954 };

			PrintArray("Ожидаемый массив: ", testExArray);
			PrintArray("Исходный массив: ", testArray);
           
			BucketSort(ref testArray);

			PrintArray("Отсортированный массив: ", testArray);
		}

		static void BucketSort( ref int[] testArray)
		{

			int min = testArray[0];
			int max = testArray[0];

			for (int i = 1; i < testArray.Length; i++)
			{
				if (testArray[i] > max)
				{
					max = testArray[i];
				}
				if (testArray[i] < min)
				{
					min = testArray[i];
				}
			}

			List<int>[] bucket = new List<int>[max - min + 1];

			for (int i = 0; i < bucket.Length; i++)
			{
				bucket[i] = new List<int>();
			}

			for (int i = 0; i < testArray.Length; i++)
			{
				bucket[testArray[i] - min].Add(testArray[i]);
			}

			int k = 0;
			for (int i = 0; i < bucket.Length; i++)
			{
				if (bucket[i].Count > 0)
				{
					for (int j = 0; j < bucket[i].Count; j++)
					{
						testArray[k] = bucket[i][j];
						k++;
					}
				}
			}
		}


		static void PrintArray(string text, int[] array)
        {

            Console.WriteLine(text);
            Console.WriteLine();
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
