using System;
using System.Collections.Generic;

namespace BinaryTree4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {10, 9, 11, 8, 10, 7, 6, 5, 15, 19, 14};

            //int[] array = { 10, 100, 1, 4, 50, 0, 19, 45, 14 };

            BinaryTree Tree = new BinaryTree();

            //Тестируем добавление элементов в дерево
            Console.WriteLine("Тестируем добавление элементов в дерево:");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Tree.AddItem(array[i]);
            }
            Console.WriteLine();


            //Реализация BreadthFirstSearch
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            BreadthFirstSearch(Tree, treeNodes);
            Console.WriteLine();

            //Реализация DeepFirstSearch
            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            DeepFirstSearch(Tree, treeStack);

            Console.WriteLine();
            Tree.PrintTree();

            //Тестируем поиск корня в дереве
            PrintText("Тестируем поиск корня в дереве:");
            var Root  = Tree.GetRoot();
            Console.WriteLine($"{Root.Value} корень.");

            //Тестируем поиск значений в дереве
            PrintText("Тестируем поиск значений в дереве:");
            var value = Tree.GetNodeByValue(7);
            var value1 = Tree.GetNodeByValue(15);
            PrintText($"{value.Value}, {value1.Value} найдены");

            //Тестируем удаление
            Console.WriteLine("Тестируем удаление:");
            DeleteNode(Tree, 8, "Удаляем 8:");
            DeleteNode(Tree, 7, "Удаляем 7:");
            DeleteNode(Tree, 15, "Удаляем 15:"); // Тут неправильно работает;

            Console.ReadLine();
        }

        public static void PrintText(string text)
        {
            Console.WriteLine();

            Console.WriteLine(text);

            Console.WriteLine();
        }
        public static void DeleteNode( BinaryTree Tree, int number, string text)
        {
            PrintText(text);

            Tree.RemoveItem(number);

            Tree.PrintTree();
        }

        public static void BreadthFirstSearch(BinaryTree Tree, Queue<TreeNode> treeNodes) // Реализация BreadthFirstSearch
        {
            Console.WriteLine("BreadthFirstSearch");

            var current = Tree.GetRoot();

            Console.Write($"{current.Value}");

            treeNodes.Enqueue(current);

            while (treeNodes.Count != 0)
            {
                var cur = treeNodes.Dequeue();

                if (cur.LeftChild != null)
                {
                    treeNodes.Enqueue(cur.LeftChild);

                    Console.Write($" {cur.LeftChild.Value}");
                }
                if (cur.RightChild != null)
                {
                    treeNodes.Enqueue(cur.RightChild);

                    Console.Write($" {cur.RightChild.Value}");
                }
            }
            Console.WriteLine();
        }

        public static void DeepFirstSearch(BinaryTree Tree, Stack<TreeNode> treeStack) // Реализация DeepFirstSearch;
        {
            Console.WriteLine("DeepFirstSearch");

            var current = Tree.GetRoot();

            Console.Write($"{current.Value}");

            treeStack.Push(current);

            while (treeStack.Count != 0)
            {
                var cur = treeStack.Pop();

                if (cur.LeftChild != null)
                {
                    treeStack.Push(cur.LeftChild);

                    Console.Write($" {cur.LeftChild.Value}");
                }
                if (cur.RightChild != null)
                {
                    treeStack.Push(cur.RightChild);

                    Console.Write($" {cur.RightChild.Value}");
                }
            }
            Console.WriteLine();
        }
    }
}
