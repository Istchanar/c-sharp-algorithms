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
                if (value > current.Value)
                {
                    if (current.LeftChild != null)
                    {
                        current = current.LeftChild;
                    }
                    else
                    {
                        current.LeftChild = Next;

                        Next.Parent = current;

                        break;
                    }
                }
                else if (value < current.Value)
                {
                    if (current.RightChild != null)
                    {
                        current = current.RightChild;
                    }
                    else
                    {
                        current.RightChild = Next;

                        Next.Parent = current;

                        break;
                    }
                }
                else if (value == current.Value)
                {

                    current = Next;

                    break;
                }
            }

            count++;
        }


        public void RemoveItem(int value) // Удалить узел по значению;
        {
            var deleteNode = GetNodeByValue(value);

            if (deleteNode.RightChild == null)
            {
                if (deleteNode.LeftChild != null)
                {
                    var LeftNode = deleteNode.LeftChild;

                    ParetnCalc(deleteNode, LeftNode);

                    deleteNode.LeftChild.Parent = deleteNode.Parent;

                    deleteNode.LeftChild = null;
                    deleteNode.Parent = null;
                }
                else if (deleteNode.LeftChild == null)
                {
                    TreeNode nullValue = null;

                    ParetnCalc(deleteNode, nullValue);

                    deleteNode.Parent = null;
                }
            }
            else if (deleteNode.RightChild.LeftChild == null)
            {
                if (deleteNode.LeftChild != null)
                {
                    var RightNode = deleteNode.RightChild;

                    ParetnCalc(deleteNode, RightNode);

                    deleteNode.LeftChild.Parent = deleteNode.RightChild;
                    deleteNode.RightChild.LeftChild = deleteNode.LeftChild;
                    deleteNode.RightChild.Parent = deleteNode.Parent;

                    deleteNode.LeftChild = null;
                    deleteNode.RightChild = null;
                    deleteNode.Parent = null;
                }
                else if (deleteNode.LeftChild == null)
                {
                    var RightNode = deleteNode.RightChild;

                    ParetnCalc(deleteNode, RightNode);

                    RightNode.Parent = deleteNode.Parent;

                    deleteNode.RightChild = null;
                    deleteNode.Parent = null;
                }
            }
            else if (deleteNode.RightChild.LeftChild != null)
            {
                if (deleteNode.LeftChild != null)
                {

                    var RightLeftNode = deleteNode.RightChild.LeftChild;

                    deleteNode.LeftChild.Parent = RightLeftNode;

                    RightLeftNode.LeftChild = deleteNode.LeftChild;
                    RightLeftNode.Parent = deleteNode.Parent;
                    RightLeftNode.RightChild = deleteNode.RightChild;

                    ParetnCalc(deleteNode, RightLeftNode);

                    deleteNode.RightChild.Parent = RightLeftNode;
                    deleteNode.RightChild.LeftChild = null;

                    deleteNode.LeftChild = null;
                    deleteNode.RightChild = null;
                    deleteNode.Parent = null;
                }
                else if (deleteNode.LeftChild == null)
                {
                    var RightLeftNode = deleteNode.RightChild.LeftChild;

                    RightLeftNode.Parent = deleteNode.Parent;
                    RightLeftNode.RightChild = deleteNode.RightChild;

                    ParetnCalc(deleteNode, RightLeftNode);

                    deleteNode.RightChild.Parent = RightLeftNode;
                    deleteNode.RightChild.LeftChild = null;

                    deleteNode.RightChild = null;
                    deleteNode.Parent = null;
                }
            }
            count--;
        }

        public void ParetnCalc(TreeNode deleteNode, TreeNode value)
        {
            if (deleteNode.Parent.RightChild != null && deleteNode.Parent.LeftChild != null)
            {
                if (deleteNode.Parent.RightChild.Value > deleteNode.Value)
                {
                    deleteNode.Parent.LeftChild = value;
                }
                if (deleteNode.Parent.RightChild.Value < deleteNode.Value)
                {
                    deleteNode.Parent.RightChild = value;
                }
            }
            else if (deleteNode.Parent.RightChild != null && deleteNode.Parent.LeftChild == null)
            {
                deleteNode.Parent.RightChild = value;
            }
            else if (deleteNode.Parent.RightChild == null && deleteNode.Parent.LeftChild != null)
            {
                deleteNode.Parent.LeftChild = value;
            }
        }
            

        public TreeNode GetNodeByValue(int value) //Получить узел дерева по значению;
        {
            if (value == RootNode.Value)
            {
                return RootNode;
            }

            var current = RootNode;

            while (current != null)
            {
                if (value > current.Value)
                {
                    if (current.Value != value)
                    {
                        current = current.LeftChild;
                    }
                    else
                    {
                        return current;
                    }

                }
                else if (value < current.Value)
                {
                    if (current.Value != value)
                    {
                        current = current.RightChild;
                    }
                    else
                    {
                        return current;
                    }

                }
                else if (value == current.Value)
                {
                    return current;
                }

            }

            return null;
        }

        public void PrintTree()
        {
            RootNode.Print("", true);
        }
    } }

