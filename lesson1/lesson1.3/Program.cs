using System;

namespace lesson1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка числа Фибоначи");

            int[] array = {-1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16}; //Скармливаем массив чисел;

            
        // Если на вход попадут минусы, отлавливаем их, т.к. будут лишние нули.

            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];

                if(number<0)
                { 
                    int FibReq = FibonacciCicl(number);

                    Console.WriteLine($"Число Фибоначчи циклом {FibReq}");
                }
                else
                {
                    Console.WriteLine($"Число меньше единицы");
                }
            }
                
            // Если пойдет число с минусом в рекурсию, получим переполнение, поэтому используем try

            for (int i = 0; i < array.Length; i++)
                {

                uint number;

                try
                {
                    number = Convert.ToUInt32(array[i]);

                    uint FibReq = FibonacciReq(number);

                    Console.WriteLine($"Число Фибоначчи рекурсией {FibReq}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }


        static int FibonacciCicl(int number)
        {
            int a = 0;

            int b = 1;

            int start;

            for (int i = 0; i < number; i++)
            {
                start = a;

                a = b;

                b += start;
            }

            return a;
        }

        static uint FibonacciReq(uint number)
        {
            uint numberUint = Convert.ToUInt32(number);

            if (numberUint == 0 || numberUint == 1)
            {
                return numberUint;
            }

            return FibonacciReq(numberUint - 1) + FibonacciReq(numberUint - 2);

        }
    }
}
