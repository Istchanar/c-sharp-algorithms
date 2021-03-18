using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    class Graff
    {
        public int[,] tree; // Матрица смежности;
        public void SearchDeep()
        {
           
            int height1 = 0; 
            
            int height2 = 0;

            List<int> node = new List<int>();  

            node.Add(0);

            int[,] assist = (int[,])tree.Clone();

            int zero = 0;

            int a, b;

            for (a = zero; a < assist.GetLength(0); a++) 
            {
                if (height2 < height1)
                {
                    height2 = height1;

                    height1 = 0;
                }
                for (b = a + 1; b < assist.GetLength(1); b++)
                {
                    if (assist[a, b] == 1)
                    {
                        height1++;
                        node.Add(b);
                        assist[a, b] = 0;
                        zero = b;
                        break;
                    }

                    else
                    if (a != 0)
                    {
                        zero = 0;

                    }
                }
            }
            Console.WriteLine("DFS список вершин графа:");

            for (int i = 0; i < node.Count; i++)
            {
                Console.Write(node[i] + " ");
            }

            Console.WriteLine("Глубина графа:" + height2);

        }

        public void SearchDeep1()
        {

            int height1 = 0;

            int height2 = 0;

            Queue<int> node = new Queue<int>();

            node.Enqueue(0);

            int[,] assist = (int[,])tree.Clone();

            int zero = 0;

            int a, b;

            for (a = zero; a < assist.GetLength(0); a++)
            {
                if (height2 < height1)
                {
                    height2 = height1;

                    height1 = 0;
                }
                for (b = a + 1; b < assist.GetLength(1); b++)
                {
                    if (assist[a, b] == 1)
                    {
                        height1++;
                        node.Enqueue(b);
                        assist[a, b] = 0;
                        zero = b;
                        break;
                    }

                    else
                    if (a != 0)
                    {
                        zero = 0;

                    }
                }
            }
            Console.WriteLine("BFS список вершин графа:");

            foreach (int i in node)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Глубина графа:" + height2);

        }
    }
}