using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree4._2
{
    public class BinaryTree : ITree
    {
        public TreeNode RootNode { get; set; }

        public TreeNode RigthNode { get; set; }

        public TreeNode LeftNode { get; set; }

        public TreeNode GetRoot()
        {
            if (RootNode == null)
                return null;
            else if (RootNode != null)
            { 
            
            }

        }

        public void AddItem(int value) // добавить узел
        {
            if (RootNode == null)
            {
                RootNode = new TreeNode { Value = value };
            }
            else if (RootNode.LeftChild == null)
            {
                LeftNode = new TreeNode { Value = value };

                LeftNode.Parent = RootNode;

                RootNode.LeftChild = LeftNode;
            }
            else if (RootNode.RightChild == null)
            {
                RigthNode = new TreeNode { Value = value };

                RigthNode.Parent = RootNode;

                RootNode.RightChild = RigthNode;
            }
        }

        public void RemoveItem(int value) // удалить узел по значению
        {

        }

        public TreeNode GetNodeByValue(int value) //получить узел дерева по значению
        {
           var x = TreeNode x;

            return x;
        }
        public void PrintTree() //вывести дерево в консоль
        { 
        
        }
    }
}
