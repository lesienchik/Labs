using System;

namespace CubeSurfaceAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1.");
            Console.Write("Введите длину стороны куба: ");

            // Чтение значения длины стороны куба с клавиатуры
            double sideLength = Convert.ToDouble(Console.ReadLine());

            // Вычисление объема поверхности куба
            double surfaceArea = 6 * sideLength * sideLength;

            // Вывод результата
            Console.WriteLine($"Объем поверхности куба при длине стороны {sideLength} равен {surfaceArea}.");


            // Задание 2
            Console.WriteLine("\nЗадание №2. ");
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
        
            double yy = Math.Pow(x,2);
            bool n1 = (y >= yy) && (x <= 0);
            bool n2 = (y >= yy) && !n1;
            bool n3 = (x*y >=0) && !n2;
            bool n4 = !n1 && !n2 && !n3;
        
            int nn1 = BitConverter.GetBytes(n1)[0];
            int nn2 = BitConverter.GetBytes(n2)[0];
            int nn3 = BitConverter.GetBytes(n3)[0];
            int nn4 = BitConverter.GetBytes(n4)[0];
        
            int nn = 1*nn1 + 2*nn2 + 3*nn3 + 4*nn4;
        
            Console.WriteLine("Результат: "+nn);

        }
    }
}
