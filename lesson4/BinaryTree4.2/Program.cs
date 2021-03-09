using System;

namespace BinaryTree4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 6, 3, 2, 15, 7, 55, 56, 18, 9, 12 };

            BinaryTree Tree = new BinaryTree();

            for (int i = 0; i < array.Length; i++)
            {
                Tree.AddItem(array[i]);
            }

            var Root  = Tree.GetRoot();
            
            Console.WriteLine(Root.Value);

            Console.ReadLine();
        }
    }
}
