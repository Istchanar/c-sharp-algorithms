using System;

namespace BinaryTree4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 3, 10, 12, 15, 7, 55};

            BinaryTree Tree = new BinaryTree();

            for (int i = 0; i < array.Length; i++)
            {
                Tree.AddItem(array[i]);
            }

            Tree.PrintTree();

            var Root  = Tree.GetRoot();
            
            Console.WriteLine(Root.Value);

            Console.ReadLine();
        }
    }
}
