using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    class Graff
    {
        public int[,] graphMatrix; // Матрица смежности;
        public void SearchDeep()
        {
            int height1 = 0; 
            int height2 = 0;
            List<int> node = new List<int>();
            node.Add(0);
            int[,] assist = (int[,])graphMatrix.Clone();
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
                    else if (a != 0)
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
        
        public void BFSearch(int[,] graphMatrix)
        {
            Queue<int> vertex = new Queue<int>();   // Создаём очередь;
            vertex.Enqueue(0);  // Добавляем в очередь граф со значением 0;
            bool[ ] used = new bool[graphMatrix.GetLength(0)]; //Создаём массив равный одному из измерений массива-графа, для хранения состояния вершины графа;
            used[0] = true; // Для нуля сразу устанавливаем тру, т.е. мы его посетили;
            int i = 0;  //Счётчик нумерации волн;
            Console.WriteLine($"Волна {i}, голова 0");
            Console.WriteLine();

            while (vertex.Count != 0)
            {
                int vertexNode = vertex.Dequeue(); //Удаляем вершину графа;
                for (int index = 0; index < graphMatrix.GetLength(0); index++) //Для нас связи графа - это значения матрицы, где индекс - это значение вершины графа, 
                {                                                        //а присуствие значение в матрице, по индексу значение говорит о связи с другой вершиной.
                    if (graphMatrix[index, vertexNode] != 0 && used[index] != true)          // проверка есть ли связь и посещали ли мы вершину;
                    {
                        used[index] = true;
                        vertex.Enqueue(index);
                    }
                }
                i++;
                Console.WriteLine($"Волна {i}");
                foreach (int vert in vertex)
                { 
                    Console.Write(vert);
                }
                Console.WriteLine();
                
            }
            Console.WriteLine(vertex.Count);
        }
    }
}