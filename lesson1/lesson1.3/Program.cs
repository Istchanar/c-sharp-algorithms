using System;

namespace lesson1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка числа Фибоначи");


            uint FibCicl = FibonacciCicl(uint number);

            uint FibReq = FibonacciReq(uint number);
        }


        static uint FibonacciCicl(uint number)
        {
            uint a = 0;
            uint b = 1;
            uint start;

            for (uint i = 0; i < number; i++)
            {
                start = a;
                a = b;
                b += start;
            }

            return a;
        }

        static uint FibonacciReq(uint number)
        {

            if (number == 0 || number == 1)
            {
                return number;
            }

            if (number == 1)
            {
                return 1;
            }

            return FibonacciReq(number - 1) + FibonacciReq(number - 2);

        }
    }
}
