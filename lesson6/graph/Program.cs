using System;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {                                  
            int[,] graphMatrix = new int[6,6]{
                                                  {0,1,0,0,1,0},
                                                  {1,0,1,0,0,1},
                                                  {0,1,0,1,0,1},
                                                  {0,0,1,0,1,0},
                                                  {1,0,0,1,0,1},
                                                  {0,1,1,0,1,0}
                                             };

            Graff graph = new Graff { graphMatrix = graphMatrix};

            graph.DFSSetSize(graphMatrix.GetLength(0));
            Console.WriteLine("Вывод шагов DFSearch алгоритма:");
            graph.DFSearch(0);
            graph.DFSPrint();

            graph.BFSearch(graphMatrix);
            Console.ReadLine();
        }
    }
}
