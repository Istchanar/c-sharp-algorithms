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
           
            int height1 = 0; int height2 = 0;

            List<int> nodeDFS = new List<int>();  

            nodeDFS.Add(0);

            int[,] assist = (int[,])tree.Clone();
            int var = 0;
            int a, b;

            for (a = var; a < assist.GetLength(0); a++) 
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
                        nodeDFS.Add(b);
                        assist[a, b] = 0;
                        var = b;
                        break;
                    }

                    else
                    if (a != 0)
                    {
                        var = 0;

                    }
                }
            }
            Console.WriteLine("Выведем список вершин при обходе дерева в глубину:");

            for (int i = 0; i < nodeDFS.Count; i++)
            {
                Console.WriteLine("\t" + nodeDFS[i]);
            }

            Console.WriteLine("Высота дерева:" + height2);

        }
    }

}