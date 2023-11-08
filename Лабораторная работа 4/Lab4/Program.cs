using System;

class Program
{
    static void Main()
    {
        int[,] B = new int[4, 4];
        
        // Ввод исходных данных из клавиатуры
        Console.WriteLine("Введите элементы массива B(4,4):");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"B[{i},{j}]: ");
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(B);

        // Выполнение перестановки
        SwapDiagonalElements(B);

        // Вывод измененного массива
        Console.WriteLine("Измененный массив:");
        PrintArray(B);
    }

    // Процедура перестановки элементов на диагоналях
    static void SwapDiagonalElements(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int temp = arr[i, i];
            arr[i, i] = arr[i, arr.GetLength(0) - 1 - i];
            arr[i, arr.GetLength(0) - 1 - i] = temp;
        }
    }

    // Вспомогательная функция для вывода массива
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
