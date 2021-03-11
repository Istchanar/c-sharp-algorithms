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

                        Next.Parent = current;

                        break;
                    }
                }
                else if (value > current.Value)
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


        public void RemoveItem(int value) // Удалить узел по значению; НУЖЕН ФИКС УДАЛЕНИЯ, ПОКА СТРАННО УДАЛЯЕТ И ЛЕВЫЙ ЭЛЕМЕНТ ТЕРЯЕТСЯ
        {
            var deleteNode = GetNodeByValue(value);

            if (deleteNode.LeftChild == null && deleteNode.RightChild == null)
            {
                var Parent = deleteNode.Parent;

                if (Parent.RightChild != null)
                {
                    Parent.RightChild = null;
                }
                else if (Parent.LeftChild != null)
                {
                    Parent.LeftChild = null;
                }

                deleteNode.Parent = null;

            }
            else if (deleteNode.LeftChild != null && deleteNode.RightChild == null)
            {
                var Parent = deleteNode.Parent;

                deleteNode.LeftChild.Parent = Parent;

                if (Parent.RightChild != null)
                {
                    Parent.RightChild = deleteNode.LeftChild;
                }
                else if (Parent.LeftChild != null)
                {
                    Parent.LeftChild = deleteNode.LeftChild;
                }

                deleteNode.Parent = null;

                deleteNode.LeftChild = null;
            }
            else if (deleteNode.LeftChild == null && deleteNode.RightChild != null)
            {
                var Parent = deleteNode.Parent;

                deleteNode.RightChild.Parent = Parent;

                if (Parent.RightChild != null)
                {
                    Parent.RightChild = deleteNode.RightChild;
                }
                else if (Parent.LeftChild != null)
                {
                    Parent.LeftChild = deleteNode.RightChild;
                }

                deleteNode.Parent = null;

                deleteNode.RightChild = null;
            }
            else if (deleteNode.LeftChild != null && deleteNode.RightChild != null)
            {
                if (deleteNode.RightChild.RightChild == null && deleteNode.RightChild.LeftChild == null)
                {
                    var Parent = deleteNode.Parent;

                    deleteNode.RightChild.Parent = Parent;

                    deleteNode.LeftChild.Parent = deleteNode.RightChild;

                    if (Parent.RightChild!=null)
                    {
                        Parent.RightChild = deleteNode.RightChild;
                    }
                    else if (Parent.LeftChild!=null)
                    {
                        Parent.LeftChild = deleteNode.RightChild;
                    }

                    deleteNode.Parent = null;

                    deleteNode.LeftChild = null;

                    deleteNode.RightChild = null;
                }
                else if (deleteNode.RightChild.LeftChild != null)
                {
                    var Parent = deleteNode.Parent;

                    deleteNode.RightChild.LeftChild.Parent = Parent;

                    deleteNode.LeftChild.Parent = deleteNode.RightChild.LeftChild;

                    deleteNode.RightChild.LeftChild.RightChild = deleteNode.RightChild;

                    deleteNode.RightChild.LeftChild.LeftChild = deleteNode.LeftChild;

                    if (Parent.RightChild!=null)
                    {
                        Parent.RightChild = deleteNode.RightChild.LeftChild;
                    }
                    else if (Parent.LeftChild!=null)
                    {
                        Parent.LeftChild = deleteNode.RightChild.LeftChild;
                    }

                    deleteNode.Parent = null;

                    deleteNode.LeftChild = null;

                    deleteNode.RightChild = null;
                }
            }
            count--;
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
                if (value < current.Value)
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
                else if (value > current.Value)
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

