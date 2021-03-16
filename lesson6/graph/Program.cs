using System;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tree = new int[8, 8]    {{0,1,1,1,0,0,0,0},
                                            {0,0,0,0,1,0,0,0},
                                            {1,0,0,0,0,0,0,0},
                                            {1,0,0,0,0,1,1,0},
                                            {1,0,0,0,0,0,0,0},
                                            {0,0,0,1,0,0,0,1},
                                            {0,0,0,1,0,0,0,0},
                                            {0,0,0,0,0,1,0,0}};

            Graff graph = new Graff { tree = tree };

            graph.SearchDeep();

            Console.WriteLine();
        }
    }
}
