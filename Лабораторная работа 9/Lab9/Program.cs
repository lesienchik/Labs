using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1.
        // Рекурсивная функция для вычисления длины строки
        string testString = "Hello, world!";
        Console.WriteLine($"Длина строки \"{testString}\" равна {CalculateStringLength(testString)}.");

        // Задание 2.
        // Рекурсивный факториал
        int n = 5;
        Console.WriteLine($"Факториал числа {n} равен {CalculateFactorial(n)}.");

        // Задание 3.
        // Рекурсивное вычисление чисел Фибоначчи
        int fibNumber = 9;
        Console.WriteLine($"Число Фибоначчи под номером {fibNumber} равно {CalculateFibonacci(fibNumber)}.");

        // Задание 4.
        // Решение головоломки Ханойская башня
        int disksCount = 3;
        SolveHanoi(disksCount, 'A', 'B', 'C');
    }

    // Задание 1.
    // Рекурсивная функция для вычисления длины строки
    static int CalculateStringLength(string s)
    {
        if (s == "")
            return 0;
        else
            return 1 + CalculateStringLength(s.Substring(1));
    }

    // Задание 2.
    // Рекурсивный факториал
    static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }

    // Задание 3.
    // Рекурсивное вычисление чисел Фибоначчи
    static int CalculateFibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
    }

    // Задание 4.
    // Решение головоломки Ханойская башня
    static void SolveHanoi(int n, char source, char auxiliary, char target)
    {
        if (n == 1)
        {
            Console.WriteLine($"{source} {target}");
        }
        else
        {
            SolveHanoi(n - 1, source, target, auxiliary);
            Console.WriteLine($"{source} {target}");
            SolveHanoi(n - 1, auxiliary, source, target);
        }
    }
}
