using System;

namespace lesson1._2
{
    class Program
    {
        //Задание №1.2 Вычислите асимптотическую сложность функции из примера ниже.
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Сложность алгоритма равна \n O(2+3N^3)");
            Console.WriteLine("Итоговая сложность равна O(2+3N^3) - два внешних шага, 3 прохода по массиву, и в самом внутреннем цикле - выполнение трёх дополнительных операций.");

        }

  //Итоговая сложность равна O(2+3N^3) - два внешних шага, 3 прохода по массиву, и в самом внутреннем цикле - выполнение трёх дополнительных операций.
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; // Сложность равна O(1)

            for (int i = 0; i < inputArray.Length; i++)     // Сложность равна O(N)
            {
                for (int j = 0; j < inputArray.Length; j++) // Сложность равна O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) // Сложность равна О(N), с учётом трёх внутренних шаго - O(3N);
                    {
                        int y = 0;  // Сложность равна O(1)

                        if (j != 0)  // Сложность равна O(1)
                        {
                            y = k / j; // Сложность равна O(1), но так как проверка на if имеет более широкую область определения, мы пренебрегаем этим.
                        }

                        sum += inputArray[i] + i + k + j + y; // Сложность равна O(1)
                    }
                }
            }

            return sum;  // Сложность равна O(1)
        }


    }
}
