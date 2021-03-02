using System;
using list;

namespace test
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

            for (int i = 0; i < array.Length; i++)              // С помощью цикла за полняем значениями наш список;
            {
                int value = array[i];

                List.AddNode(value);                            // Используя метод AddNode, проверяем, работает ли FindNode;

                var allNodes = List.FindNode(value);

                Console.WriteLine($"Тестируем метод AddNode: \n {allNodes.Value}");
            }

            int leigth = List.GetCount();                       // Вызываем метод GetCount, выводим в консоль длинну;

            int countFromClass = List.count;

            Console.WriteLine($"Тестируем метод GetCount: GetCount = {leigth}, значение в классе {countFromClass}"); // Проверяем, работает ли GetCount;

            var newNode = List.FindNode(10);

            Console.WriteLine($"Тестируем метод FindNode: {newNode.Value}");

            List.AddNodeAfter(newNode, 1111);

            var addNode = List.FindNode(1111);

            Console.WriteLine($"Тестируем метод AddNodeAfter: {addNode.Value}");

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

            var currentNode = head;                     // Берём головной узел;

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
                tail.NextNode = node;                // Если голова есть, то мы помещаем ссылку следующей ноды хваста на нашу ноду; 

                node.PrevNode = tail;                // А наша нода предыдущей ссылкой берёт хвостовую ноду; 
            }

            tail = node;                             // Хвост теперь принимает значение нашей ноды;

            count++;                                 // Увеличиваем на 1 счётчик.
        }

        // Метод, который добавляет новый элемент списка после определённого элемента.
        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };   // Создаём новый узел указанного значения;

            var nextItem = node.NextNode;               // Получаем ссылку на следующие узел от входной ноды;

            node.NextNode = newNode;                    // Предыдущую ноду заставляем ссылаться на нашу;

            newNode.NextNode = nextItem;                // А ссылку старой ноды на новую отдаём новой ноде;

            var prevItem = node;                        // Берём ноду, от которой добавляем, как ссылку на предыдущую;

            node.NextNode.PrevNode = newNode;           // В ноде, на которую ссылается нода, от которой мы добавляем - меняем обратную ссылку на новую ноду;

            newNode.PrevNode = prevItem;                // Установливаем в новую ноду ссылку на предыдущую;

            count++;                                    // Увеличиваем счётчик.
        }

        // Удаляем элемент по индексу;
        public void RemoveNode(int index)
        {


            if (index == 0)                             
            {
                var newHead = head.NextNode;           

                newHead.PrevNode = null;    

                head.NextNode = null;

                head = newHead;

                count--;
            }

            else { 

                int countX = 0;

                var current = head;

                while (current != null)                      
                {
                    if (current.NextNode == null)           
                    {
                        var newTail = tail.PrevNode;

                        newTail.NextNode = null;

                        tail.PrevNode = null;

                        tail = newTail;

                        count--;

                        break;
                    }

                    if (countX == index - 1)
                    {
                        RemoveNode(current);

                        count--; 

                        break;
                    }

                    current = current.NextNode;

                    countX++;
                }
            }

        }

        // Удаляем указанный узел;
        public void RemoveNode(Node node)
        {
            var current = head;           // Устанавливаем ссылку на голову;

            while (current != null)       // Если голова не равна null;
            {
                if (current == node)      // Если введенный узел равен ноде - выходим;
                {
                    break;
                }

                current = current.NextNode; // Если нет - перебираем;
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

        // Ищем элемент по значению
        public Node FindNode(int searchValue)
        {
            var current = head;                  // Устанавливаем старт с головы;

            while (current != null)              // Если голова не null, и там лежит какой-то объект;
            {
                if (current.Value == searchValue)  // Если текущее значение нам подходит - выйдем из цикла;
                {
                    return current;
                }

                current = current.NextNode;       // Если нет - переходим на новый объект;
            }

            return null;                          // Если всё плохо вернём null.
        }
    }
}

