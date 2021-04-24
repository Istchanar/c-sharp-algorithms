using System;

namespace test
{
    //Задание №1.1 Требуется реализовать на C# функцию согласно блок-схеме. 
    //Блок-схема описывает алгоритм проверки, простое число или нет. Необходимо также выполнить проверку в коде негативных и позитивных кейсов.
    class Program
    {
        static void Main(string[] args)
        {

            // SetAndCheckNumber(out int number); - ввод с консоли, можно не использовать;

            Console.WriteLine($"Проверка простых и сложных чисел:");

            uint[] checkNums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 131, 132, 133, 139, 197 };

            for (int i = 0; i < checkNums.Length; i++)
            {
                uint number = checkNums[i];
                PrimeOrNotNumber(number);
            }

        }

        static void PrimeOrNotNumber(uint number)

        {
            int d = 0;
            int i = 2;



            while (i < number)
            {

                if (number % i == 0)
                {
                    d += 1;
                    i += 1;
                }
                else
                {
                    i += 1;
                }
            }


            if (d == 0)
            {
                // Нужно исключить ноль, чтобы он не попал.
                if (number == 0)
                {
                    Console.WriteLine($"Ноль не может быть простым числом.");
                }
                else
                {
                    Console.WriteLine($"{number} простое число.");
                }
            }

            else
            {
                Console.WriteLine($"{number} сложное число.");
            }
        }

        /*
        static void SetAndCheckNumber(out int number)

        {
            bool parse;

            do
            {
                Console.WriteLine("Введите число, для определения простое оно или нет:");

                parse = Int32.TryParse(Console.ReadLine(), out number);

            } while (parse == false);
        }
        */
    }
}

