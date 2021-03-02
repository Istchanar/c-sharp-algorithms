﻿using System;
using List;
using NodeBase;

namespace ListClass
{
    //Задание №1.1 Требуется реализовать на C# функцию согласно блок-схеме. 
    //Блок-схема описывает алгоритм проверки, простое число или нет. Необходимо также выполнить проверку в коде негативных и позитивных кейсов.
    class Program
    {
        static void Main(string[] args)
        {
            //Нужно уносить в отдельный класс.

            int[] array = { -1, 2, 3, 10, 56, 77, 88, 99};      // Проверочный массив интов.

            List List = new List();                             // Создаём экземпляр нашего класса;

            Console.WriteLine($"Тестируем метод AddNode:");

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)              // С помощью цикла за полняем значениями наш список;
            {
                int value = array[i];

                List.AddNode(value);                            // Используя метод AddNode, проверяем, работает ли FindNode;

                var allNodes = List.FindNode(value);

                Console.WriteLine($"{allNodes.Value}");
            }

            Console.WriteLine();

            int leigth = List.GetCount();                       // Вызываем метод GetCount, выводим в консоль длинну;

            int countFromClass = List.count;

            Console.WriteLine($"Тестируем метод GetCount: GetCount = {leigth}, значение в классе {countFromClass}"); // Проверяем, работает ли GetCount;

            Console.WriteLine();

            var newNode = List.FindNode(10);

            Console.WriteLine($"Тестируем метод FindNode: {newNode.Value}");

            Console.WriteLine();

            List.AddNodeAfter(newNode, 1111);

            var addNode = List.FindNode(1111);

            Console.WriteLine($"Тестируем метод AddNodeAfter: {addNode.Value}");

            Console.WriteLine();

            // Пока не понял, как тестировать удаления.

            List.RemoveNode(List.FindNode(1111));

            List.RemoveNode(Array.IndexOf(array, -1));

            List.RemoveNode(Array.IndexOf(array, 99));

            List.RemoveNode(Array.IndexOf(array, 56));

            Console.ReadLine();

        }

    }

    public class List : ILinkedList
    {
        Node head; // Объявление головы;

        Node tail; // Объявление хвоста;

        public int count;

        // Возвращает количество элементов в списке.
        public int GetCount()
        {

            var currentNode = head;                     // Берём головную ноду;

            int countNode = 1;                          // Счётчик устанавливаем на единицу;

            while (currentNode.NextNode != null)        // Если существует ссылка на следующую ноду;
            {
                currentNode = currentNode.NextNode;     // Берём за currentNode следующую ноду и проверяем, есть ли ссылка на следущую и т.д.;

                countNode++;                            // Счётчик увеличиваем на один;
            }

            return countNode;                           // Возвращаем кол-во узлов.
        }

        // Добавляем новый элемент в список.
        public void AddNode(int value)
        {
            var node = new Node { Value = value };   // Объявляем новый узел с полем value;

            if (head == null)                        // Если головы нет;
            {
                head = node;                         // То объявленную ноду мы берём за голову;
            }
            else
            {
                tail.NextNode = node;                // Если голова есть, то мы помещаем ссылку следующей от хвоста ноды на нашу ноду; 

                node.PrevNode = tail;                // А наша нода предыдущей ссылкой берёт хвостовую ноду;
            }

            tail = node;                             // Хвост теперь принимает значение нашей ноды;

            count++;                                 // Увеличиваем на один счётчик класс.
        }

        // Метод, который добавляет новый элемент списка после определённого элемента.
        public void AddNodeAfter(Node oldNode, int value)
        {
            var newNode = new Node { Value = value };       // Создаём новую ноду для указанного значения;

            oldNode.NextNode.PrevNode = newNode;            // Берём у старой ноды ссылку на следующую ноду, у которой пердыдущую ноду меняем на новую;

            newNode.PrevNode = oldNode;                     // У новой ноды предыдущей ставим старую;

            newNode.NextNode = oldNode.NextNode;            // У новой ноды следующей нодой ставим следующую ноду от старой;

            oldNode.NextNode = newNode;                     // Следующую ноду для старой ноды ставим ношу новую.

            count++;                                        // Увеличиваем счётчик класса.
        }

        // Удаляем элемент по индексу.
        public void RemoveNode(int index)
        {


            if (index == 0)                          //    Если индекс нулевой;
            {
                var newHead = head.NextNode;         //    Достаём ноду следующую за головой, которая будет новой головой;

                newHead.PrevNode = null;             //    Голове ссылку на предыдущую ноду устанавливаем на null;

                head.NextNode = null;                //    Старой голове ссылку на следующую устанавливаем на null;

                head = newHead;                      //    Устанавливаем ноду как голову;

                count--;                             //    Счётчик класса - отнимаем значение.
            }

            else 
            { 
                int  number = 0;                     //    В ином случае объявляем переменную число, с нуля;

                var current = head;                  //    Берём головную ноду;

                while (current != null)              //    Пока ссылка на следующую ноду возвращает не null;      
                {
                    if (current.NextNode == null)    //    Если ссылка null;     
                    {
                        var newTail = tail.PrevNode; //    Новый хвост это хвост, из ссылки на предыдущую ноду из старого;

                        newTail.NextNode = null;     //    Устанавливаем новому хвосту ссылку на следующую ноду null;

                        tail.PrevNode = null;        //    Старому хвосту на предыдущую null;

                        tail = newTail;              //    В поле класса назначаем новый хвост;

                        count--;

                        break;
                    }

                    if (number == index - 1)         //    Если введённое число равно разнице индекса и одного; 
                    {
                        RemoveNode(current);         //    Используя метод удаляем текущую ноду;

                        break;
                    }

                    current = current.NextNode;      //   Если ничего не подходит нам, берём следующую ноду;

                    number++;                        //   Число увеличиваем на один.
                }
            }

        }

        // Удаляем указанный узел.
        public void RemoveNode(Node node)
        {
            var current = head;           // Устанавливаем ссылку на голову;

            while (current != null)       // Если ссылка не на null;
            {
                if (current == node)      // И введенный узел равен нужной ноде - выходим;
                {
                    break;
                }

                current = current.NextNode; // Если нет - продолжаем перебор;
            }

            if (current != null)                                    // Найдя нужную ноду - проверям на null;
            {
                if (current.NextNode != null)                       // Если следующая нода от текущей не null;
                {
                    current.NextNode.PrevNode = current.PrevNode;   // Мы обратную ссылку следующей ноды устанавливаем на обратную ссылку текущей ноды;
                }
                else                                                // В противном случае, если следующей ноды нет - то хвостом будет то, что в обратной ссылке;
                {
                    tail = current.PrevNode;
                }

                if (current.PrevNode != null)                       // Если обратная ссылка не null;
                {
                    current.PrevNode.NextNode = current.NextNode;   // То обратная ссылка следующей ноды устанавливается в следующую ссылку текущей;
                }
                else                                                // В противном случае головой станет то, что находится в ссылке текущей ноды, указывающей на следующую ноду.
                {
                    head = current.NextNode;
                }

                count--;
            }

        }

        // Ищем элемент по значению.
        public Node FindNode(int searchValue)
        {
            var current = head;                    // Устанавливаем старт с головы;

            while (current != null)                // Если голова не null, и там лежит какой-то объект;
            {
                if (current.Value == searchValue)  // Если текущее значение нам подходит - выйдем из цикла;
                {
                    return current;
                }

                current = current.NextNode;        // Если нет - переходим на новый объект;
            }

            return null;                           // Если всё плохо вернём null.
        }
    }
}

