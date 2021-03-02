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

            PrintText($"Тестируем метод AddNode:");

            for (int i = 0; i < array.Length; i++)               // С помощью цикла за полняем значениями наш список;
            {
                int value = array[i];

                List.AddNode(value);                             // Используя метод AddNode, проверяем, работает ли FindNode;

                var allNodes = List.FindNode(value);

                Console.WriteLine($"{allNodes.Value}");
            }

            Console.WriteLine();


            // Тест GetCount.

            int leigth = List.GetCount();                                                                    // Вызываем метод GetCount, выводим в консоль длинну;
             
            int countFromClass = List.count;

            PrintText($"Тестируем метод GetCount: GetCount = {leigth}, значение в классе {countFromClass}"); // Проверяем, работает ли GetCount;


            // Тест FindNode.

            var newNode = List.FindNode(10);

            PrintText($"Тестируем метод FindNode: {newNode.Value}");


            // Тест AddNodeAfter.

            List.AddNodeAfter(newNode, 1111);

            var addNode = List.FindNode(1111);

            PrintText($"Тестируем метод AddNodeAfter: {addNode.Value}");


            // Тест RemoveNode по значению.

            List.RemoveNode(List.FindNode(1111));

            if (List.FindNode(1111) != null)
            {
                PrintText("Тестируем метод RemoveNode(Node): Удаление по ноде не сработало.");
            }
            else
            {
                PrintText("Тестируем метод RemoveNode(Node): Удаление по ноде сработало.");
            }


            // Тест RemoveNode по индексу.

            // Срабатывает через раз, хотя в стеке (и сам метод) - всё удаляется правильно. Надо исправить.

            int[] testArr = { -1, 99, 56 };

            for (int i = 0; i < testArr.Length; i++)
            {
                List.RemoveNode(testArr[i]);

                if (List.FindNode(testArr[i]) != null)
                {
                   
                    PrintText("Тестируем метод RemoveNode(index): Удаление по индексу не сработало.");
                }
                else
                {
                    PrintText("Тестируем метод RemoveNode(index): Удаление по индексу сработало.");
                }
            }

            Console.ReadLine();

        }

        static void PrintText(string text)
        {
            Console.WriteLine(text);

            Console.WriteLine();
        }
    }
}