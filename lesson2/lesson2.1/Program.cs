using System;
using List;
using NodeBase;
using LinkList;

namespace ListClass
{
    //Задание №1.1 Требуется реализовать на C# функцию согласно блок-схеме. 
    //Блок-схема описывает алгоритм проверки, простое число или нет. Необходимо также выполнить проверку в коде негативных и позитивных кейсов.
    class Program
    {
        static void Main(string[] args)
        {
            //Нужно уносить в отдельный класс.

            int[] array = { -1, 2, 3, 10, 56, 77, 88, 99 };      // Проверочный массив интов.

            List.List List = new List.List();                    // Создаём экземпляр нашего класса;



            // Тест AddNode.

            PrintText($"Тестируем метод AddNode, выводим List:");

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < array.Length; i++)               // С помощью цикла за полняем значениями наш список;
            {
                int value = array[i];

                List.AddNode(value);                             // Используя метод AddNode, проверяем, работает ли FindNode;

                var allNodes = List.FindNode(value);

                Console.Write("{0} ", allNodes.Value);
            }

            Console.ResetColor();


            // Тест GetCount.

            int leigth = List.GetCount();                                                                    // Вызываем метод GetCount, выводим в консоль длинну;
             
            int countFromClass = List.count;

            Console.WriteLine();

            PrintText($"\nТестируем метод GetCount: GetCount = {leigth}, значение в классе {countFromClass}"); // Проверяем, работает ли GetCount;



            // Тест FindNode.

            var newNode = List.FindNode(10);

            PrintText($"Тестируем метод FindNode: {newNode.Value}");



            // Тест AddNodeAfter.

            List.AddNodeAfter(newNode, 1111);

            var addNode = List.FindNode(1111);

            PrintText($"Тестируем метод AddNodeAfter: {addNode.Value}");



            // Тест RemoveNode по значению.

            PrintText("Тестируем метод RemoveNode(Node):");

            PrintText("\n  List до удаления элемента:");

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < List.count; i++)
            {
                Console.Write(" {0}", List.FindValueByIndex(i));
            }

            Console.ResetColor();

            Console.WriteLine();


            List.RemoveNode(List.FindNode(1111));


            PrintText("\n  List после удаления элемента:");

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < List.count; i++)
            {
                Console.Write(" {0}", List.FindValueByIndex(i));
            }

            Console.ResetColor();

            Console.WriteLine();




            // Тест RemoveNode по индексу. Нужен общий метод.


            PrintText("\nТестируем метод RemoveNode(index):");

            PrintText("\n  List до удаления первого элемента:");

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < List.count; i++)
            {
                Console.Write(" {0}", List.FindValueByIndex(i));
            }

            Console.ResetColor();

            Console.WriteLine();




            PrintText("\n  List после удаления первого элемента:");

            Console.ForegroundColor = ConsoleColor.Magenta;

            int first = 1;

            List.RemoveNode(first);

            for (int i = 0; i < List.count; i++)
            {
                Console.Write(" {0}", List.FindValueByIndex(i));
            }

            Console.ResetColor();

            Console.WriteLine();

            


            PrintText("\n  List после удаления последнего элемента:");

            Console.ForegroundColor = ConsoleColor.Magenta;

            int last = 7;

            List.RemoveNode(last);

            for (int i = 0; i < List.count; i++)
            {
                Console.Write(" {0}", List.FindValueByIndex(i));
            }

            Console.ResetColor();

            Console.WriteLine();





            PrintText("\n  List после удаления среднего элемента:");

            Console.ForegroundColor = ConsoleColor.Magenta;

            int middle = 4;

            List.RemoveNode(middle);

            for (int i = 0; i < List.count; i++)
            {
                Console.Write(" {0}", List.FindValueByIndex(i));
            }

            Console.ResetColor();

            Console.WriteLine();
        }

        static void PrintText(string text)
        {
            Console.WriteLine(text);

            Console.WriteLine();
        }


    }
}