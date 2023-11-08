using System;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Задание 1. Сортировка массива");
            Console.WriteLine("Выберите тип элементов массива: ");
            Console.WriteLine("1. Целые числа");
            Console.WriteLine("2. Строки");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int[] intArray = { 5, 2, 6, 3, 1, 4 };
                    TestSortingAlgorithms<int>(intArray);
                    break;
                case 2:
                    string[] stringArray = { "b", "f", "a", "e", "c", "d" };
                    TestSortingAlgorithms<string>(stringArray);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }

            // Задание 2
            Console.WriteLine("\nЗадание 2. Блочная сортировка");
            Console.Write("Введите количество элементов: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное значение элемента: ");
            int maxVal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество блоков: ");
            int numBlocks = Convert.ToInt32(Console.ReadLine());
            BlockSort(size, maxVal, numBlocks);
        }

        static void TestSortingAlgorithms<T>(T[] array) where T : IComparable
        {
            Console.WriteLine("Исходный массив: [{0}]", string.Join(", ", array));

            // Измеряем время для каждого метода сортировки
            var watch = Stopwatch.StartNew();
            BubbleSort(array);
            watch.Stop();
            Console.WriteLine("Сортировка обменами: [{0}]. Время: {1} ticks", string.Join(", ", array), watch.ElapsedTicks);

            watch = Stopwatch.StartNew();
            SelectionSort(array);
            watch.Stop();
            Console.WriteLine("Сортировка выбором: [{0}]. Время: {1} ticks", string.Join(", ", array), watch.ElapsedTicks);

            watch = Stopwatch.StartNew();
            InsertionSort(array);
            watch.Stop();
            Console.WriteLine("Сортировка включением: [{0}]. Время: {1} ticks", string.Join(", ", array), watch.ElapsedTicks);

            watch = Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            watch.Stop();
            Console.WriteLine("Быстрая сортировка: [{0}]. Время: {1} ticks", string.Join(", ", array), watch.ElapsedTicks);
        }

        static void BubbleSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                T temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        static void QuickSort<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        static int Partition<T>(T[] array, int left, int right) where T : IComparable
        {
            T pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j].CompareTo(pivot) < 0)
                {
                    i++;
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            T temp1 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp1;
            return i + 1;
        }

        static void BlockSort(int size, int maxVal, int numBlocks)
        {
            // Реализуйте блочную сортировку здесь
            // Ваш код здесь
        }
    }
}
