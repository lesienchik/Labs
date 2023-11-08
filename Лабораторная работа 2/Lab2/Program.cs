using System;

class Program
{
    static void Main(string[] args)
    {
        // Задание 1.
        task1(10, 0.01);

        // Задание 2
        double x1 = 1 / Math.Sqrt(3); // Контрольное значение аргумента x
        double x2 = -1 / Math.Sqrt(3); // Контрольное значение аргумента x
        double x3 = 1; // Контрольное значение аргумента x

        Console.WriteLine("Значения функции y(x) для заданных аргументов:");
        Console.WriteLine($"Для x = 1/sqrt(3): y({x1}) = {CalculateY(x1)}");
        Console.WriteLine($"Для x = -1/sqrt(3): y({x2}) = {CalculateY(x2)}");
        Console.WriteLine($"Для x = 1: y({x3}) = {CalculateY(x3)}");
    }

    // Задание 1.
    static double fibbonaci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            double a = 0;
            double b = 1;
            for (int i = 2; i <= n; i++)
            {
                double c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }

    static void task1(int n, double precision)
    {
        double fib1 = fibbonaci(n);
        double fib2 = fibbonaci(n + 1);
        double prevRatio = fib2 / fib1;
        double currentRatio;
        do
        {
            n++;
            fib1 = fib2;
            fib2 = fibbonaci(n + 1);
            currentRatio = fib2 / fib1;
        } while (Math.Abs(currentRatio - prevRatio) > precision);
        Console.WriteLine($"Предел отношения двух чисел ряда Фибоначчи при точности {precision} равен: {currentRatio}");
    }

    // Задание 2.
    static double CalculateY(double x)
        {
            double sum = 0;
            double term;
            int n = 1;
            double epsilon = 1e-6; // Точность вычислений

            do
            {
                term = Math.Pow(-1, n + 1) * Math.Pow(x, 2 * n - 1) / (2 * n - 1);
                sum += term;
                n++;
            } while (Math.Abs(term) > epsilon);

            return sum;
        }
    }   
