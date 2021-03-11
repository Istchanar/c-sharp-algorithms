using System;

namespace BinaryTree4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {10, 9, 11, 8, 10, 7, 6, 5, 15, 19, 14};

            BinaryTree Tree = new BinaryTree();

            Console.WriteLine("Тестируем добавление элементов в дерево:");

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Tree.AddItem(array[i]);
            }

            Tree.PrintTree();

            PrintText("Тестируем поиск корня в дереве:");

            var Root  = Tree.GetRoot();

            Console.WriteLine($"{Root.Value} корень.");

            PrintText("Тестируем поиск значений в дереве:");

            var value = Tree.GetNodeByValue(7);

             var value1 = Tree.GetNodeByValue(15);

            PrintText($"{value.Value}, {value1.Value} найдены");

            Console.WriteLine("Тестируем удаление:");

            DeleteNode(Tree, 8, "Удаляем 8:");

            DeleteNode(Tree, 7, "Удаляем 7:");

            DeleteNode(Tree, 15, "Удаляем 15:");

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
        
    }
}
