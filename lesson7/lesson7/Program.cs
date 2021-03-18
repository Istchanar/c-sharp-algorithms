using System;

namespace lesson7
{
    class Program
    {
        const int N = 8;
        const int M = 8;
        static void Main(string[] args)
        {
            int[,] A = new int[N, M];

            int i, j;

            for (j = 0; j < M; j++)
            {
                A[0, j] = 1;           //Первая строка заполнена единицами;
            }
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;

                for (j = 1; j < M; j++)
                {
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
                }
            }

            Print(N, M, A);

        }

        static void Print(int n, int m, int[,] a)
        {
            int i, j;

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    string line = Line(a[i,j]);
                    Console.Write(a[i, j]+ line);
                }
                Console.Write("\r\n");
            }
        }

        static string Line(int arrayValue)
        {
            string line;

            if (arrayValue >= 1000)
            {
               return line = "  ";
            }
            else if (arrayValue >= 100)
            {
               return line = "   ";
            }
            else if (arrayValue >= 10)
            {
              return  line = "    ";
            }
            else if (arrayValue < 10)
            {
               return line = "     ";
            }

            return null;
        }

    }
}
