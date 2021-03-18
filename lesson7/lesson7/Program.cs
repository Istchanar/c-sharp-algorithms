using System;

namespace lesson7
{
    class Program
    {
        const int size = 8;
        static void Main(string[] args)
        {
            Desk desk = new Desk();

            desk.SetSize(size);

            int N = desk.Height;

            int M = desk.Width;

            int[,] A = new int[N, M];  // Наша доска;

            int i, j;

            for (j = 0; j < M; j++)
            {
                A[0, j] = 1;           //Первая строка заполнена единицами, т.к. пройти по первую строчку возможно только вправо (попасть в след. ячейку только из одной);
            }
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;            // Первый столбец заполнен единицами, т.к. пройти по первому столбику возможно только вниз (попасть в след. ячейку только из одной);

                for (j = 1; j < M; j++)
                {
                    A[i, j] = A[i, j - 1] + A[i - 1, j]; // В точку i, j можно попасть из i, j-1 и из i-1,j элементов, т.е. сверху или слева.
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
                    string line = Line(a[i, j]);

                    Console.Write(a[i, j] + line);
                }

                Console.Write("\r\n");
            }
                    
            Console.Write("\r\nВозможностей перехода в точку " + n + " равно "+ a[n-1, m-1]);
               
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
