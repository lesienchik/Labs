using System;

class Program
{
    static void Main(string[] args)
    {
        int[] A = new int[20];
        Console.WriteLine("Введите 20 элементов массива:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Индексы положительных элементов:");
        for (int i = 0; i < 20; i++)
        {
            if (A[i] > 0)
            {
                Console.WriteLine($"Индекс {i}: {A[i]}");
            }
        }

        Console.ReadLine();
    }
}
