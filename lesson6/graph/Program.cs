using System;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {                                  //1 2 3 4 5 6
            int[,] tree = new int[6, 6]    {{0,1,0,0,1,0},
                                            {1,0,1,0,0,1},
                                            {0,1,0,1,0,1},
                                            {0,0,1,0,1,0},
                                            {1,0,0,1,0,1},
                                            {0,1,1,0,1,0}};

            Graff graph = new Graff { tree = tree };

            graph.SearchDeep();

            Console.WriteLine();
        }
    }
}
