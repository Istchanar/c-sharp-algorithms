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


            else
            {
                var current = RootNode;

                if (current.Value <= value)
                {
                    var Next = new TreeNode { Value = value };

                    if (current.LeftChild == null)
                    {
                        current.LeftChild = Next;

                        Next.Parent = current;
                    }
                    else
                    {
                        while (current.LeftChild != null)
                        {
                            if (current.LeftChild == null)
                            {
                                break;
                            }

                            current = current.LeftChild;
                        }

                        current.LeftChild = Next;

                        Next.Parent = current;
                    }
                }


                else if (current.Value > value)
                {
                    var Next = new TreeNode { Value = value };

                    if (current.RightChild == null)
                    {
                        current.RightChild = Next;

                        Next.Parent = current;
                    }
                    else
                    {
                        while (current.RightChild != null)
                        {
                            if (current.RightChild == null)
                            {
                                break;
                            }

                            current = current.RightChild;
                        }

                        current.RightChild = Next;

                        Next.Parent = current;
                    }
                }
            
            }
        }


        public void RemoveItem(int value) // удалить узел по значению
        {

        }

        public TreeNode GetNodeByValue(int value) //получить узел дерева по значению
        {
            var x = new TreeNode { Value = value };

            return x;
        }
        public void PrintTree() //вывести дерево в консоль
        {

        }
}   }

