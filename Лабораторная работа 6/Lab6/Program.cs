using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1
        Queue<int> queue = new Queue<int>();
        // Добавляем 8 чисел в очередь
        for (int i = 1; i <= 8; i++)
        {
            queue.Enqueue(i);
        }

        // Находим сумму 2-го и 4-го чисел из очереди
        int secondNumber, fourthNumber;
        if (queue.Count >= 4)
        {
            secondNumber = queue.ToArray()[1];
            fourthNumber = queue.ToArray()[3];
            int sum = secondNumber + fourthNumber;
            // Результат помещаем в очередь
            queue.Enqueue(sum);
        }
        
        // Печать очереди
        Console.WriteLine("Очередь после добавления суммы 2-го и 4-го чисел:");
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }

        // Задание 2
        Queue<int> selectionSortedQueue = SelectionSortQueue(queue);

        // Печать отсортированной очереди
        Console.WriteLine("\nОтсортированная очередь с помощью сортировки выбором:");
        foreach (int item in selectionSortedQueue)
        {
            Console.Write(item + " ");
        }
    }

    // Реализация сортировки выбором для очереди
    static Queue<int> SelectionSortQueue(Queue<int> inputQueue)
    {
        List<int> list = new List<int>(inputQueue);
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (list[j] < list[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = list[minIndex];
            list[minIndex] = list[i];
            list[i] = temp;
        }
        return new Queue<int>(list);
    }
}
