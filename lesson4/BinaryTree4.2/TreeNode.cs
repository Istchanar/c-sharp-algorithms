using System;
using System.Collections.Generic;

namespace BinaryTree4._2
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode Parent { get; set; }
        public void Print(string symbol, bool last)
        {
            Console.Write(symbol);

            if (last)
            {
                Console.Write("└─");
                symbol += "  ";
            }

            else
            {
                Console.Write("├─");
                symbol += "| ";
            }

            Console.WriteLine(Value);

            var child = new List<TreeNode>();

            if (this.LeftChild != null)
            {
                child.Add(this.LeftChild);
            }

            if (this.RightChild != null)
            {
                child.Add(this.RightChild);
            }

            for (int i = 0; i < child.Count; i++)
            {
                child[i].Print(symbol, i == child.Count - 1);
            }

        }
    }
}
