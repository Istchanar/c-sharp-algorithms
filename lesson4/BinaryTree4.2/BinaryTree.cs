using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree4._2
{
    public class BinaryTree : ITree
    {
        public TreeNode RootNode { get; set; }

        public int count { get; set; }


        public TreeNode GetRoot() // Возвращаем корневой элемент;
        {
            if (RootNode.Parent == null)
            {
                return RootNode;
            }
            else
            {
                TreeNode Root;

                while (RootNode.Parent != null)
                {
                    RootNode = RootNode.Parent;
                }

                Root = RootNode;

                return Root;
            }
        }

        public void AddItem(int value) // Добавляем узел;
        {
            if (RootNode == null)
            {
                RootNode = new TreeNode { Value = value };
            }

            var Next = new TreeNode { Value = value };

            var current = RootNode;

            while (current != null)
            { 
                if (value < current.Value)
                {
                    if (current.LeftChild != null)
                    {
                        current = current.LeftChild;
                    }
                    else
                    {
                        current.LeftChild = Next;

                        break;
                    }
                }
                else if (value > current.Value)
                {
                    if (current.RightChild!= null)
                    {
                        current = current.RightChild;
                    }
                    else
                    {
                        current.RightChild = Next;

                        break;
                    }
                }
            }   
        }


        public void RemoveItem(int value) // Удалить узел по значению;
        {

        }

        public TreeNode GetNodeByValue(int value) //получить узел дерева по значению
        {
            var x = new TreeNode { Value = value };

            return x;
        }

        public void PrintTree()
        {
            PrintTree1(RootNode);
        }

        public void PrintTree1(TreeNode RootNode) //вывести дерево в консоль
        {
                if (RootNode == null) return;
                    PrintTree1(RootNode.LeftChild);
                Console.WriteLine(RootNode.Value);
                    PrintTree1(RootNode.RightChild);
        }

       
}   }

