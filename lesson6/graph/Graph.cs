using System;
using System.Collections.Generic;

namespace graph
{
    class Graff
    {
        public int[,] graphMatrix; // Матрица смежности;

        public bool[] visited;

        private List<int> DFSvertex = new List<int>();

        public void DFSearch(int v)
        {
            visited[v] = true;
            for (int index = 0; index != graphMatrix.GetLength(0); index++)
            {
                if (graphMatrix[index, v] != 0 && visited[index] != true)
                {
                    DFSAdd(index);
                    DFSearch(index);
                    Console.Write(index + " ");
                }
            }
        }
        public void SetSize(int n) // Установить размер массива в поле как длинну graphMatrix; 
        {
            visited = new bool[n];
        }
        public void DFSAdd(int index) // Добавляем в лист;
        {
            DFSvertex.Add(index);
            foreach (int step in DFSvertex)
            {
                Console.Write(step + " ");
            }
            Console.WriteLine();
        }
        public void DFSPrint() // Отрисовываем лист;
        {
            Console.WriteLine("\nDFS список вершин графа:");
            foreach (int step in DFSvertex)
            {
                Console.Write(step + " ");
            }
            Console.WriteLine("\n");
        }
        public void BFSearch(int[,] graphMatrix)
        {
            Queue<int> vertex = new Queue<int>();   // Создаём очередь;
            vertex.Enqueue(0);  // Добавляем в очередь граф со значением 0;
            bool[ ] visited = new bool[graphMatrix.GetLength(0)]; //Создаём массив равный одному из измерений массива-графа, для хранения состояния вершины графа;
            visited[0] = true; // Для нуля сразу устанавливаем тру, т.е. мы его посетили;
            int i = 0;  //Счётчик нумерации волн;
            List<int> graphValues = new List<int>();
            graphValues.Add(0);
            Console.WriteLine("Вывод волн BFSearch алгоритма:");
            Console.WriteLine($"Волна {i}");
            Console.WriteLine($"{i}");

            while (vertex.Count != 0)
            {
                int vertexNode = vertex.Dequeue();                             //Удаляем вершину графа;
                for (int index = 0; index < graphMatrix.GetLength(0); index++) //Для нас связи графа - это значения матрицы, где индекс - это значение вершины графа, 
                {                                                              //а присуствие значение в матрице, по индексу значение говорит о связи с другой вершиной.
                    if (graphMatrix[index, vertexNode] != 0 && visited[index] != true)   // проверка есть ли связь и посещали ли мы вершину;
                    {
                        visited[index] = true;
                        graphValues.Add(index);
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
            Console.WriteLine();
            Console.WriteLine("BFS список вершин графа:");
            foreach (int graphVal in graphValues)
            {
                Console.Write(graphVal+" ");
            }
        }

        /*
        public void DFSearch1()
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
                foreach (int t in node)
                {
                    Console.Write(t + " ");
                }
            }
            Console.WriteLine("\nDFS список вершин графа:");
            Console.WriteLine();
            for (int i = 0; i < node.Count; i++)
            {
                Console.Write(node[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Глубина графа:" + height2);
            Console.WriteLine();
        }
        */
    }
}