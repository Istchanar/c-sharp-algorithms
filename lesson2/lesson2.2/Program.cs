using System;

namespace lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputArray = { 10, 1, 24, 4, 2, 112, 234, 4, 0, 15 };

            PrintAndType("Выводим массив:", inputArray);

            BubbleSort(inputArray);

            PrintAndType("Выводим отсортированный массив:", inputArray);

            int testData = 10;
            
            Test(testData, inputArray);

        }

        // Используем пузырьковую сортировку.

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j + 1];

                        array[j + 1] = array[j];

                        array[j] = temp;
                    }
                }
            }
        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            // Итоговая сложность: O(3+3*log2(N)), можно упростить до log2(N).

            int min = 0;                                 // Сложность O(1)

            int max = inputArray.Length - 1;             // O(1)

            while (min <= max)
            {
                int mid = (min + max) / 2;               // log2(N), поскольку мы постоянно в два раза уменьшаем кол-во вариантов поиска, т.е., например, у нас 16 вариантов, потом 8, потом 4, потом 2, потом 1.

                if (searchValue == inputArray[mid])      // O(1)
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])  // O(1)
                {
                    max = mid - 1;
                }
                else                                     // O(1) , в 3х if'ax - els'aх будет выполнено от одной до трёх операций, возмём максимум.
                {
                    min = mid + 1;
                }
            }
            return -1;                                   // O(1)
        }

        static void Test(int targetValue, int [] inputArray)
        {
            Console.WriteLine($"Искомое значение - {targetValue}.");

            int generateValue = BinarySearch(inputArray, targetValue);

            Console.WriteLine($"Искомое значение - номер в массиве {generateValue}, значение {inputArray[generateValue]}");
        }


        static void PrintAndType(string text, int[] inputArray)
        {
            Console.WriteLine(text);

            Console.WriteLine("{0}", string.Join("\n", inputArray));

            Console.WriteLine();
        }


    }
}
