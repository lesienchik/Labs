using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharpTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            int[] array = GenerateRandomArray(10002);
            Array.Sort(array);
            Console.WriteLine("Массив отсортирован.");

            // Ввод числа для поиска
            Console.WriteLine("Введите целое число для поиска:");
            int searchNumber = Convert.ToInt32(Console.ReadLine());
            int position = InterpolationSearch(array, searchNumber);
            if (position != -1)
                Console.WriteLine($"Позиция числа {searchNumber} в массиве: {position}");
            else
                Console.WriteLine($"Число {searchNumber} не найдено в массиве.");

            // Задание 2
            Console.WriteLine("Введите слово для поиска в текстовом файле:");
            string word = Console.ReadLine();
            List<long> positions = FindWordInFile("example.txt", word);
            Console.WriteLine($"Позиции слова {word} в файле: {string.Join(", ", positions)}");

            // Задание 3
            CreateGlossaryFile("example.txt", "glossary.txt");
            Console.WriteLine("Файл-глоссарий создан.");
        }

        // Задание 1
        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 1000);
            }
            return array;
        }

        static int InterpolationSearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high && target >= array[low] && target <= array[high])
            {
                int pos = low + ((target - array[low]) * (high - low)) / (array[high] - array[low]);

                if (array[pos] == target)
                    return pos;

                if (array[pos] < target)
                    low = pos + 1;
                else
                    high = pos - 1;
            }
            return -1;
        }

        // Задание 2
        static List<long> FindWordInFile(string filePath, string word)
        {
            List<long> positions = new List<long>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                long position = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(word))
                        positions.Add(position);
                    position = reader.BaseStream.Position;
                }
            }
            return positions;
        }

        // Задание 3
        static void CreateGlossaryFile(string sourceFilePath, string glossaryFilePath)
        {
            Dictionary<string, List<int>> glossary = new Dictionary<string, List<int>>();

            using (StreamReader reader = new StreamReader(sourceFilePath))
            {
                string line;
                int lineNumber = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (glossary.ContainsKey(word))
                        {
                            glossary[word].Add(lineNumber);
                        }
                        else
                        {
                            glossary.Add(word, new List<int> { lineNumber });
                        }
                    }
                    lineNumber++;
                }
            }

            using (StreamWriter writer = new StreamWriter(glossaryFilePath))
            {
                foreach (var entry in glossary)
                {
                    string line = $"{entry.Key} | {string.Join(", ", entry.Value)}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
