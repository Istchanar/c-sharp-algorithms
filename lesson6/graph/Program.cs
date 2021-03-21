﻿using System;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {                                  //0 1 2 3 4 5
            int[,] graphMatrix = new int[6, 6]   {{0,1,0,0,1,0},
                                            {1,0,1,0,0,1},
                                            {0,1,0,1,0,1},
                                            {0,0,1,0,1,0},
                                            {1,0,0,1,0,1},
                                            {0,1,1,0,1,0}};

            Graff graph = new Graff { tree = graphMatrix };
            graph.SearchDeep();
            Console.WriteLine("Вывод вол BFSearch алгоритма:");
            Console.WriteLine();
            graph.BFSearch(graphMatrix);
            Console.ReadLine();
        }
    }
}